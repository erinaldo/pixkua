-- =============================================
-- Author: RCO
-- Create date: 11-oct-2010
-- Description:	Obtiene una lista de búsqueda de Turnos
-- =============================================
CREATE FUNCTION [Inventory].[fxTurnosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdTurno, Nombre, Codigo, HoraInicial, HoraFinal,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Inventory.Turnos
	)


