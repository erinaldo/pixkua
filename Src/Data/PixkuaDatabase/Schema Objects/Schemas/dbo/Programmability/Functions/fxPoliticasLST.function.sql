-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 05-Ene-2006
-- Description:	Obtiene una lista de búsqueda de politicas de seguridad
-- =============================================
CREATE FUNCTION [dbo].[fxPoliticasLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT IdPolitica, Politica
	FROM dbo.Politicas)


