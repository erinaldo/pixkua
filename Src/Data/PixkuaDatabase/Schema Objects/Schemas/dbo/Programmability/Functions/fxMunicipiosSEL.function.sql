-- =============================================
-- Author: RCO
-- Create date: 23-mar-2009
-- Description:	Obtiene la información del Municipios especificado.
-- =============================================
CREATE FUNCTION [dbo].[fxMunicipiosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT M.*, E.Estado, E.IdPais
	FROM dbo.Municipios M JOIN dbo.Estados E
		ON M.IdEstado=E.IdEstado
	WHERE M.IdMunicipio=@ID
	)


