-- =============================================
-- Author: RCO
-- Create date: 10-sep-2010
-- Description:	Obtiene una lista de búsqueda de Divisas
-- =============================================
CREATE FUNCTION [Accounting].[fxDivisasLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdDivisa, Nombre, Abrev AS Abreviatura, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Accounting.Divisas	
	)


