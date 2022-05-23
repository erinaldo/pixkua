-- =============================================
-- Author: alex Lopez
-- Create date: 23-nov-2011
-- Description:	Agrega o modifica la información de Gastos
-- =============================================
CREATE PROCEDURE [Purchasing].[GastosUPD]
	@Id AS char (18)out,
	@Fecha AS datetime,
	@IdGastoConcepto AS int,
	@IdDepartamento AS int,
	@IdPresupuesto AS int,
	@IdCategoriaPresupuestal AS int,
	@IdDivisa AS int,
	@TipoCambio AS decimal(19,4),
	@ModalidadPago AS char(1),
	@IdBeneficiario AS int,
	@TipoBeneficiario AS char(1),
	@Notas AS varchar(128),
	@IdProveedor AS int,
	@SerieFactura AS char(10),
	@FolioFactura AS int,
	@AnioAprobacion AS int,
	@NumAprobacion AS int,
	@SubTotal AS decimal(19,4),
	@IdImpuesto1 AS int,
	@IdImpuesto2 AS int,
	@IdImpuesto3 AS int,
	@PorcImp1 AS decimal(7,6),
	@PorcImp2 AS decimal(7,6),
	@PorcImp3 AS decimal(7,6),
	@MontoImp1 AS decimal(19,4),
	@MontoImp2 AS decimal(19,4),
	@MontoImp3 AS decimal(19,4),
	@IdRetencion1 AS int,
	@IdRetencion2 AS int,
	@IdRetencion3 AS int,
	@PorcRetencion1 AS decimal(7,6),
	@PorcRetencion2 AS decimal(7,6),
	@PorcRetencion3 AS decimal(7,6),
	@MontoRetencion1 AS decimal(19,4),
	@MontoRetencion2 AS decimal(19,4),
	@MontoRetencion3 AS decimal(19,4),
	@Total AS decimal(19,4),
	@IdStatus AS int,
	@IdSucursal AS int,
	@IdEmpresa AS int,
	@UserUpdate AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32)
AS
	SET NOCOUNT ON
	
	IF @Id=''
	BEGIN
		DECLARE @IdTipoDocumento AS Int
		SET @IdTipoDocumento = Cast(dbo.fxParamGetValue('Configuracion/Documentos/Tipos','Gasto') as int)

		--Obtenemos el Folio consecutivo del documento
		EXEC Documents.NewDocumentFolio @IdTipoDocumento, @IdSucursal, @Fecha, @Id Out
		
		INSERT INTO Purchasing.Gastos(IdGasto, Fecha, IdGastoConcepto, IdDepartamento, IdPresupuesto, IdCategoriaPresupuestal, IdDivisa, TipoCambio, ModalidadPago, IdBeneficiario, TipoBeneficiario, Notas, IdProveedor, SerieFactura, FolioFactura, AnioAprobacion, NumAprobacion, SubTotal, IdImpuesto1, IdImpuesto2, IdImpuesto3, PorcImp1, PorcImp2, PorcImp3, MontoImp1, MontoImp2, MontoImp3, IdRetencion1, IdRetencion2, IdRetencion3, PorcRetencion1, PorcRetencion2, PorcRetencion3, MontoRetencion1, MontoRetencion2, MontoRetencion3, Total, IdStatus, IdSucursal, IdEmpresa, UserUpdate, LastUpdate, PCUpdate)
		VALUES (@Id, @Fecha, @IdGastoConcepto, @IdDepartamento, @IdPresupuesto, @IdCategoriaPresupuestal, @IdDivisa, @TipoCambio, @ModalidadPago, @IdBeneficiario, @TipoBeneficiario, @Notas, @IdProveedor, @SerieFactura, @FolioFactura, @AnioAprobacion, @NumAprobacion, @SubTotal, @IdImpuesto1, @IdImpuesto2, @IdImpuesto3, @PorcImp1, @PorcImp2, @PorcImp3, @MontoImp1, @MontoImp2, @MontoImp3, @IdRetencion1, @IdRetencion2, @IdRetencion3, @PorcRetencion1, @PorcRetencion2, @PorcRetencion3, @MontoRetencion1, @MontoRetencion2, @MontoRetencion3, @Total, @IdStatus, @IdSucursal, @IdEmpresa, @UserUpdate, @LastUpdate, @PCUpdate)
	END
	ELSE
		UPDATE Purchasing.Gastos SET Fecha=@Fecha, IdGastoConcepto=@IdGastoConcepto, IdDepartamento=@IdDepartamento, IdPresupuesto=@IdPresupuesto, IdCategoriaPresupuestal=@IdCategoriaPresupuestal, IdDivisa=@IdDivisa, TipoCambio=@TipoCambio, ModalidadPago=@ModalidadPago, IdBeneficiario=@IdBeneficiario, TipoBeneficiario=@TipoBeneficiario, Notas=@Notas, IdProveedor=@IdProveedor, SerieFactura=@SerieFactura, FolioFactura=@FolioFactura, AnioAprobacion=@AnioAprobacion, NumAprobacion=@NumAprobacion, SubTotal=@SubTotal, IdImpuesto1=@IdImpuesto1, IdImpuesto2=@IdImpuesto2, IdImpuesto3=@IdImpuesto3, PorcImp1=@PorcImp1, PorcImp2=@PorcImp2, PorcImp3=@PorcImp3, MontoImp1=@MontoImp1, MontoImp2=@MontoImp2, MontoImp3=@MontoImp3, IdRetencion1=@IdRetencion1, IdRetencion2=@IdRetencion2, IdRetencion3=@IdRetencion3, PorcRetencion1=@PorcRetencion1, PorcRetencion2=@PorcRetencion2, PorcRetencion3=@PorcRetencion3, MontoRetencion1=@MontoRetencion1, MontoRetencion2=@MontoRetencion2, MontoRetencion3=@MontoRetencion3, Total=@Total, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, UserUpdate=@UserUpdate, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate
		WHERE IdGasto=@ID and Fecha = Documents.fxDocumentDate(@id)


