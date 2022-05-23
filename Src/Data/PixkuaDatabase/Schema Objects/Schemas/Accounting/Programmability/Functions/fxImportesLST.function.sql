-- =============================================
-- Author: alez Lopez
-- Create date: 18-oct-2010
-- Description:	Obtiene una lista de búsqueda de Importes
-- =============================================
CREATE FUNCTION [Accounting].[fxImportesLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdImporte,Descripcion,Importe,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Accounting.Importes
	)


