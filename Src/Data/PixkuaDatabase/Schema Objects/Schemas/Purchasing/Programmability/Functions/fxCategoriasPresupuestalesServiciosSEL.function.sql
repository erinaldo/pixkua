CREATE FUNCTION [Purchasing].[fxCategoriasPresupuestalesServiciosSEL](@IdCategoriaPresupuestal int)
RETURNS TABLE
AS
RETURN(	SELECT CS.IdServicio,S.Nombre AS Servicio
		FROM Purchasing.CategoriasPresupuestalesServicios CS
		INNER JOIN Purchasing.Servicios S ON S.IdServicio=CS.IdServicio
		WHERE CS.IdCategoriaPresupuestal=@IdCategoriaPresupuestal
)


