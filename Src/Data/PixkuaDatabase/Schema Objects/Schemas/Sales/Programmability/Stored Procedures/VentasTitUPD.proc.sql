-- =============================================
-- Author: RCO
-- Create date: 06-sep-2010
-- Description:	Agrega o modifica la información de VentasTit
-- =============================================
CREATE PROCEDURE [Sales].[VentasTitUPD]
	@Id AS char(18) out,
	@Fecha AS datetime,
	@Hora AS datetime,
	@IdReferencia AS char(18),
	@IdAlmacen as int,
	@IdCliente AS int,
	@IdVendedor AS int,
	@IdTerminal AS int,
	@IdCaja as int,
	@CondicionesPago AS char(1),
	@Observaciones AS varchar(256),
	@OrdenCompra AS varchar(32),
	@Origen AS char(1),
	@TotalCantidad AS decimal(19,4),
	@IdDivisa as int,
	@TipoCambio as decimal(19,4),
	@SubTotal AS decimal(19,4),
	@TotalImpuestosTras AS decimal(19,4),
	@TotalImpuestosRet AS decimal(19,4),
	@TotalDescuentos AS decimal(19,4),
	@TotalFlete AS decimal(19,4),
	@TotalComision AS decimal(19,4),
	@Total AS decimal(19,4),
	@TotalIVA AS decimal(19,4),
	@TotalIEPS AS decimal(19,4),	
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
		SET @IdTipoDocumento = Cast(dbo.fxParamGetValue('Configuracion/Documentos/Tipos','Venta') as int)

		--Obtenemos el Folio consecutivo del documento
		EXEC Documents.NewDocumentFolio @IdTipoDocumento, @IdSucursal, @Fecha, @Id Out
		
		INSERT INTO Sales.VentasTit(IdVentaTit, Fecha, Hora, IdReferencia, IdCliente, 
			IdVendedor, IdTerminal,IdCaja, CondicionesPago, Observaciones, OrdenCompra, 
			TotalCantidad, IdDivisa, TipoCambio, SubTotal, TotalImpuestosTras, TotalImpuestosRet, TotalDescuentos, 
			TotalFlete, TotalComision, Total, TotalIVA, TotalIEPS, Origen, IdAlmacen,
			IdStatus, IdSucursal, UserUpdate, LastUpdate, PCUpdate)
		VALUES (@Id, @Fecha, @Hora, @IdReferencia, @IdCliente, 
			@IdVendedor, @IdTerminal, @IdCaja, @CondicionesPago, @Observaciones, @OrdenCompra, 
			@TotalCantidad, @IdDivisa, @TipoCambio, @SubTotal, @TotalImpuestosTras, @TotalImpuestosRet, @TotalDescuentos, 
			@TotalFlete, @TotalComision, @Total, @TotalIVA, @TotalIEPS, @Origen, @IdAlmacen,
			@IdStatus, @IdSucursal, @UserUpdate, @LastUpdate, @PCUpdate)
	END
	ELSE
		UPDATE Sales.VentasTit SET Fecha=@Fecha, Hora=@Hora, IdReferencia=@IdReferencia, 
			IdCliente=@IdCliente, IdVendedor=@IdVendedor, IdAlmacen=@IdAlmacen,
			IdTerminal=@IdTerminal, IdCaja=@IdCaja, CondicionesPago=@CondicionesPago, 
			Observaciones=@Observaciones, OrdenCompra=@OrdenCompra, 
			TotalCantidad=@TotalCantidad, IdDivisa=@IdDivisa, TipoCambio=@TipoCambio, 
			SubTotal=@SubTotal, TotalImpuestosTras=@TotalImpuestosTras, 
			TotalImpuestosRet=@TotalImpuestosRet, TotalDescuentos=@TotalDescuentos, 
			TotalFlete=@TotalFlete, TotalComision=@TotalComision, Total=@Total, TotalIVA=@TotalIVA, 
			TotalIEPS=@TotalIEPS, Origen=@Origen, 
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, UserUpdate=@UserUpdate, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate
		WHERE IdVentaTit=@ID and Fecha = Documents.fxDocumentDate(@id)


