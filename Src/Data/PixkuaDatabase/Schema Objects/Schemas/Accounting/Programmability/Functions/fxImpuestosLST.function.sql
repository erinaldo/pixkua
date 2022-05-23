-- =============================================
-- Author: RCO
-- Create date: 09-sep-2010
-- Description:	Obtiene una lista de búsqueda de Impuestos
-- =============================================
CREATE FUNCTION [Accounting].[fxImpuestosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdImpuesto, Nombre, Abrev AS Abreviatura, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Accounting.Impuestos
	)


