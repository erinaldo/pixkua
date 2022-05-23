-- =============================================
-- Author: alez Lopez
-- Create date: 22-ago-2011
-- Description:	Obtiene la información del GruposDescuento especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxGruposDescuentoSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.GruposDescuento WHERE IdGrupoDescuento=@ID)


