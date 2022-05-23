-- =============================================
-- Author: alex Lopez
-- Create date: 23-nov-2011
-- Description:	Aplica el proceso de flujo de trabajo del Gastos especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[GastosWorkflow]
	@ID AS Char(18),
	@IdStatus as int,
	@FechaTrabajo as datetime,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON
	SET xact_abort ON
	
	DECLARE @IdPresupuesto int,@IdCategoriaPresupuestal int,@TipoBeneficiario char(1),@IdBeneficiario int,@IdCaja as int,
			@Subtotal decimal(19,4),@TotalImpuestos decimal(19,4),@TotalRetenciones decimal(19,4),@Total decimal(19,4),
			@IdSucursal int,@IdProveedor int,@Serie char(10),@FolioFact int,@AnioAprobacion int,@IdDocumentoRef varchar(18),@ErrorMessage nvarchar(4000)
	
	SELECT	@IdPresupuesto=IdPresupuesto,@IdCategoriaPresupuestal=IdCategoriaPresupuestal,@TipoBeneficiario=TipoBeneficiario,@IdBeneficiario=IdBeneficiario,
			@Subtotal=SubTotal,@TotalImpuestos=MontoImp1+MontoImp2+MontoImp3,@TotalRetenciones=MontoRetencion1+MontoRetencion2+MontoRetencion3,@Total=Total,
			@IdSucursal=G.IdSucursal, @IdProveedor=IdProveedor,@Serie=SerieFactura,@FolioFact=FolioFactura, @AnioAprobacion=AnioAprobacion, @IdCaja=D.IdCaja
	FROM Purchasing.Gastos G
	INNER JOIN Purchasing.Departamentos D ON D.IdDepartamento=G.IdDepartamento
	WHERE IdGasto=@ID AND Fecha=Documents.fxDocumentDate(@ID)
	
	--Validamos q el beneficiario del Gasto exista en la tabla de beneficiarios de tesoreria----------------------------------------------
	DECLARE @IdBeneficiarioCheque as int
	SELECT @IdBeneficiarioCheque=IsNull(IdBeneficiario,0) FROM Treasury.Beneficiarios WHERE IdReferencia=@IdBeneficiario AND TipoBeneficiario=@TipoBeneficiario
	SET @IdBeneficiarioCheque=ISNULL(@IdBeneficiarioCheque,0)
	
	IF @IdBeneficiarioCheque=0
	BEGIN
		DECLARE @RazonSocial Varchar(128),@CLABE Char(18),@Leyenda BIT,@IdCuenta int,@IdEmpresa int,@FechaHoy Datetime,@DiasCredito int
		SELECT @RazonSocial='',@CLABE='',@FechaHoy=GETDATE()
		-- En teoria solo los Empleados son beneficiarios espontaneos y los damos de alta solo cuando se referencien en un gasto
		IF @TipoBeneficiario='E'
			--Obtenemos los datos del Empleado para agregarlo como Beneficiario
			SELECT @RazonSocial=P.Nombre+' '+P.ApellidoP+' '+P.ApellidoM,@Leyenda=0,@IdCuenta=E.IdCuenta,@IdEmpresa=E.IdEmpresa,@DiasCredito=5
			FROM RH.Empleados AS E
			INNER JOIN Personas P ON P.IdPersona=E.IdPersona
		IF @TipoBeneficiario='P'	
			SELECT @RazonSocial=P.RazonSocial,@Leyenda=1,@IdCuenta=P.IdCuenta,@IdEmpresa=P.IdEmpresa,@DiasCredito=30
			FROM Purchasing.Proveedores P
				
		EXEC Treasury.BeneficiariosUPD @IdBeneficiarioCheque out,'',@RazonSocial,@TipoBeneficiario,@IdBeneficiario,0,@CLABE,@Leyenda,@DiasCredito, @IdCuenta,1,@IdSucursal,@IdEmpresa,@FechaHoy,@PCUpdate,@UserUpdate
	END	
	-----------------------------------------------------------------------------------------------------------------------------------------------------	
	
	IF @IdStatus=3 --al aplicar
	BEGIN
		--Afectamos el presupuesto
		IF @IdPresupuesto>0
			EXEC Purchasing.PresupuestoAfectar @IdPresupuesto,@IdCategoriaPresupuestal,@Subtotal,0,'G',@Id
		
		--Validamos que el Comprobante fiscal no se haya referenciado en documentos Pasados
		SELECT @IdDocumentoRef=IdDocumento FROM Purchasing.CFD WHERE IdProveedor=@IdProveedor AND Serie=@Serie AND Folio=@FolioFact	
		IF LTRIM(RTRIM(ISNULL(@IdDocumentoRef,'')))>0
		BEGIN
			SET @ErrorMessage = N'El comprobante que se pretende comprobar ya ha sido registrado en el documento[' + @IdDocumentoRef +']' 
			RAISERROR (@ErrorMessage,18,1)
			RETURN
		END
		
		--Marcamos la Factura del Proveedor como Refernciada para que no se vuelva a utilizar en otra ocasion
		IF @IdProveedor>0 AND @AnioAprobacion>0
			UPDATE Purchasing.CFD SET IdDocumento=@ID WHERE IdProveedor=@IdProveedor AND Serie=@Serie AND Folio=@FolioFact
					
	END
	
	IF @IdStatus=10 --Al autorizar
	BEGIN 
		DECLARE @FechaDocto datetime,@FechaContrarecibo Datetime,@IdContrareciboTit CHAR(18),@LastUpdate datetime,@RefNum int,@RefAlf varchar(18),@FechaPago Datetime
		SELECT @FechaDocto = Documents.fxDocumentDate(@ID),@LastUpdate=getdate(),@IdContrareciboTit='',@RefNum='',@RefAlf=''
		SELECT @FechaContrarecibo=CONVERT(varchar(10),@LastUpdate,112),@RefAlf=LTRIM(RTRIM(@Serie+STR(@FolioFact)))
		
		--Vemos los dias de credito o dias de pago del Tipo de beneficiario
		IF  @TipoBeneficiario='P'
			SELECT @FechaPago=Dateadd(d,DiasCredito,@FechaContrarecibo)FROM Purchasing.Proveedores WHERE IdProveedor=@IdBeneficiario
		ELSE
			SET    @FechaPago=Dateadd(d,5,@FechaContrarecibo)
		
		--Nos ajustamos al Dia de la semana de pago que se acerque a la fecha de pago
		SET @FechaPago=Treasury.fxDiaPagoSiguiente(@FechaContrarecibo) 
		
		--Generamos el contrarecibo correspondiente para programacion de pago
		EXEC Treasury.ContrarecibosTitUPD  @IdContrareciboTit out,@FechaContrarecibo,@IdCaja,@Id,@FechaDocto,@RefNum,@RefAlf,@FechaPago,@IdBeneficiarioCheque,@Subtotal,@TotalImpuestos,@TotalRetenciones,@Total,1,@IdSucursal,@LastUpdate,@PCUpdate,@UserUpdate
		--Detalle
		INSERT INTO Treasury.ContrarecibosDet(	IdContrareciboTit,Fecha,CodigoConcepto,DecripcionConcepto,IdCuenta,Monto,
												IdImpuesto1,IdImpuesto2,IdImpuesto3,IdImpuesto4,IdImpuesto5,PorcImpTras1,PorcImpTras2,PorcImpTras3,PorcImpTras4,PorcImpTras5,MontoImpTras1,MontoImpTras2,MontoImpTras3,MontoImpTras4,MontoImpTras5,
												IdRetencion1,IdRetencion2,IdRetencion3,IdRetencion4,IdRetencion5,PorcImpRet1,PorcImpRet2,PorcImpRet3,PorcImpRet4,PorcImpRet5,MontoImpRet1,MontoImpRet2,MontoImpRet3,MontoImpRet4,MontoImpRet5)
			SELECT  @IdContrareciboTit,@FechaContrarecibo,GC.Codigo,GC.Nombre,GC.IdCuenta,G.SubTotal,G.IdImpuesto1,G.IdImpuesto2,G.IdImpuesto3,0,0,G.PorcImp1,G.PorcImp2,G.PorcImp3,0,0,G.MontoImp1,G.MontoImp2,G.MontoImp3,0,0,
					G.IdRetencion1,G.IdRetencion2,G.IdRetencion3,0,0,G.PorcRetencion1,G.PorcRetencion2,G.PorcRetencion3,0,0,G.MontoRetencion1,G.MontoRetencion2,G.MontoRetencion3,0,0
			FROM Purchasing.Gastos G
			INNER JOIN Purchasing.GastosConceptos GC ON GC.IdGastoConcepto=G.IdGastoConcepto
			WHERE IdGasto=@ID AND Fecha = Documents.fxDocumentDate(@Id)
		--Aplicar Contrarecibo
		EXEC Treasury.ContrarecibosTitWorkflow @IdContrareciboTit,3,@FechaContrarecibo,@UserUpdate,@PCUpdate
				
	END
	
	--Contabilizamos el documento
	EXEC Accounting.Contabilizar   @Id,@FechaTrabajo,@IdStatus,@PCUpdate,@UserUpdate,0
	
	UPDATE Purchasing.Gastos 
	SET IdStatus=@IdStatus, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=getdate()
	WHERE IdGasto=@ID AND Fecha = Documents.fxDocumentDate(@Id)


