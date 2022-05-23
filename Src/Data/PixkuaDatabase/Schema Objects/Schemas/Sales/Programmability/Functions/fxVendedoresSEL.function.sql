-- =============================================
-- Author: alez lopez
-- Create date: 29-ago-2011
-- Description:	Obtiene la información del Vendedores especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxVendedoresSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.Vendedores WHERE IdVendedor=@ID)


