-- =============================================
-- Author: alex opez
-- Create date: 13-oct-2010
-- Description:	Obtiene una lista de búsqueda de Tipos
-- =============================================
CREATE FUNCTION [Documents].[fxTiposLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdDocumentoTipo,Nombre,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Documents.Tipos
	)


