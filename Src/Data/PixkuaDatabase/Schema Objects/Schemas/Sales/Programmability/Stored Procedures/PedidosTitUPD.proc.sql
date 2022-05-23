-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Agrega o modifica la información de PedidosTit
-- =============================================
CREATE PROCEDURE [Sales].[PedidosTitUPD]
	@Id AS char(18) out,
	@Fecha AS datetime,
	@Hora AS datetime,
	@IdPedidoTipo AS int,
	@IdCliente AS int,
	@IdVendedor AS int,
	@IdAlmacen AS int,
	@OrdenCompra AS varchar(32),
	@IdReferencia AS char(18),
	@Observaciones AS varchar(256),
	@TotalCantidad AS decimal(19,4),
	@TotalSaldo AS decimal(19,4),
	@IdDivisa AS int,
	@TipoCambio AS decimal(19,4),
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
		SET @IdTipoDocumento = Cast(dbo.fxParamGetValue('Configuracion/Documentos/Tipos','PedidoVenta') as int)

		--Obtenemos el Folio consecutivo del documento
		EXEC Documents.NewDocumentFolio @IdTipoDocumento, @IdSucursal, @Fecha, @Id Out
		
		INSERT INTO Sales.PedidosTit(IdPedidoTit, Fecha, Hora, IdPedidoTipo, IdCliente, IdVendedor, IdAlmacen, 			
			OrdenCompra, IdReferencia, Observaciones, 
			TotalCantidad, TotalSaldo, IdDivisa, TipoCambio, SubTotal, TotalImpuestosTras, TotalImpuestosRet, 
			TotalDescuentos, TotalFlete, TotalComision, Total, TotalIVA, TotalIEPS, 
			IdStatus, IdSucursal, UserUpdate, LastUpdate, PCUpdate)
		VALUES (@Id, @Fecha, @Hora, @IdPedidoTipo, @IdCliente, @IdVendedor, @IdAlmacen, 			
			@OrdenCompra, @IdReferencia, @Observaciones, 
			@TotalCantidad, @TotalSaldo, @IdDivisa, @TipoCambio, @SubTotal, @TotalImpuestosTras, @TotalImpuestosRet, 
			@TotalDescuentos, @TotalFlete, @TotalComision, @Total, @TotalIVA, @TotalIEPS, 
			@IdStatus, @IdSucursal, @UserUpdate, @LastUpdate, @PCUpdate)
	END
	ELSE
		UPDATE Sales.PedidosTit SET Fecha=@Fecha, Hora=@Hora, IdPedidoTipo=@IdPedidoTipo, IdCliente=@IdCliente, 
			IdVendedor=@IdVendedor, IdAlmacen=@IdAlmacen, OrdenCompra=@OrdenCompra, IdReferencia=@IdReferencia, Observaciones=@Observaciones, 
			TotalCantidad=@TotalCantidad, TotalSaldo=@TotalSaldo, IdDivisa=@IdDivisa, TipoCambio=@TipoCambio, SubTotal=@SubTotal, 
			TotalImpuestosTras=@TotalImpuestosTras, TotalImpuestosRet=@TotalImpuestosRet, TotalDescuentos=@TotalDescuentos, TotalFlete=@TotalFlete, 
			TotalComision=@TotalComision, Total=@Total, TotalIVA=@TotalIVA, TotalIEPS=@TotalIEPS, 
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, UserUpdate=@UserUpdate, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate
		WHERE IdPedidoTit=@ID and Fecha = Documents.fxDocumentDate(@id)


