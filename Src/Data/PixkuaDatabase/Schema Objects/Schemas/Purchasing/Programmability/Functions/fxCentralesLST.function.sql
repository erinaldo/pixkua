-- =============================================
-- Author: alez lopez
-- Create date: 19-oct-2011
-- Description:	Obtiene una lista de búsqueda de Centrales
-- =============================================
CREATE FUNCTION [Purchasing].[fxCentralesLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdCentral,Nombre,NotificarOC,EnviarOC,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Purchasing.Centrales
	WHERE IdSucursal=@IdSucursal
	)


