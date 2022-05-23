-- =============================================
-- Author: RCO
-- Create date: 23-mar-2009
-- Description:	Obtiene una lista de búsqueda de Municipios
-- =============================================
CREATE FUNCTION [dbo].[fxMunicipiosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT M.IdMunicipio, M.Nombre, E.Estado, M.Codigo
	FROM dbo.Municipios M JOIN Estados E
		ON M.IdEstado=E.IdEstado
	)


