CREATE FUNCTION [Accounting].[fxFacturaGlobal](@Fecha as datetime, @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Result as int

	SELECT @Result=F.Folio 
	FROM Accounting.CFD F JOIN Sales.Clientes C
		ON F.IdCliente=C.IdCliente
	WHERE IdCFDTipo=1 AND C.RFC='XAXX010101000'
		AND F.FechaComprobante=@Fecha AND F.IdSucursal=@IdSucursal
		AND F.Activa=1
	
	RETURN IsNull(@Result, 0)
END


