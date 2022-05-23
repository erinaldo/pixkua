-- =============================================
-- Author: RCO
-- Create date: 02-dic-2011
-- Description:	Agrega o modifica la información de OrdenesTit
-- =============================================
CREATE PROCEDURE [Purchasing].[OrdenesTitUPD]
	@Id AS char(18) out,
	@Fecha AS datetime,
	@IdPeriodo AS int,
	@IdProveedor AS int,
	@IdDepartamento as int,
	@IdPresupuesto AS int,
	@IdCentroRecepcion AS int,
	@FechaEntrega AS datetime,
	@Referencia AS varchar(32),
	@IdReferencia AS char(18),
	@Origen AS char(1),
	@IdDivisa AS int,
	@TipoCambio AS decimal(19,4),
	@SubTotal AS decimal(19,4),
	@TotalImpuestosTras AS decimal(19,4),
	@TotalImpuestosRet AS decimal(19,4),
	@TotalDescuentos AS decimal(19,4),
	@TotalFlete AS decimal(19,4),
	@Total AS decimal(19,4),
	@Obaservaciones AS varchar(128),
	@IdStatus AS int,
	@IdSucursal AS int,
	@UserUpdate AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32)
AS
	SET NOCOUNT ON
	
	IF @Id=''
	BEGIN
		DECLARE @IdTipoDocumento AS Int
		SET @IdTipoDocumento = Cast(dbo.fxParamGetValue('Configuracion/Documentos/Tipos','OrdenCompra') as int)

		--Obtenemos el Folio consecutivo del documento
		EXEC Documents.NewDocumentFolio @IdTipoDocumento, @IdSucursal, @Fecha, @Id Out
		
		INSERT INTO Purchasing.OrdenesTit(IdOrdenTit, Fecha, IdPeriodo, IdProveedor, IdDepartamento, 
			IdPresupuesto, IdCentroRecepcion, FechaEntrega, Referencia, IdReferencia, Origen, IdDivisa, 
			TipoCambio, SubTotal, TotalImpuestosTras, TotalImpuestosRet, TotalDescuentos, TotalFlete, 
			Total, Obaservaciones, IdStatus, IdSucursal, UserUpdate, LastUpdate, PCUpdate)
		VALUES (@Id, @Fecha, @IdPeriodo, @IdProveedor, @IdDepartamento, 
			@IdPresupuesto, @IdCentroRecepcion, @FechaEntrega, @Referencia, @IdReferencia, @Origen, @IdDivisa, 
			@TipoCambio, @SubTotal, @TotalImpuestosTras, @TotalImpuestosRet, @TotalDescuentos, @TotalFlete, 
			@Total, @Obaservaciones, @IdStatus, @IdSucursal, @UserUpdate, @LastUpdate, @PCUpdate)
	END
	ELSE
		UPDATE Purchasing.OrdenesTit SET Fecha=@Fecha, IdPeriodo=@IdPeriodo, IdProveedor=@IdProveedor, 
			IdDepartamento=@IdDepartamento, IdPresupuesto=@IdPresupuesto, IdCentroRecepcion=@IdCentroRecepcion, 
			FechaEntrega=@FechaEntrega, Referencia=@Referencia, IdReferencia=@IdReferencia, Origen=@Origen, 
			IdDivisa=@IdDivisa, TipoCambio=@TipoCambio, SubTotal=@SubTotal, TotalImpuestosTras=@TotalImpuestosTras, 
			TotalImpuestosRet=@TotalImpuestosRet, TotalDescuentos=@TotalDescuentos, TotalFlete=@TotalFlete, 
			Total=@Total, Obaservaciones=@Obaservaciones, 
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, UserUpdate=@UserUpdate, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate
		WHERE IdOrdenTit=@ID and Fecha = Documents.fxDocumentDate(@id)


