CREATE FUNCTION [Purchasing].[fxCategoriasPresupuestalesByServicio](@IdServicio as int, @IdUsuario as int)
RETURNS TABLE
AS
RETURN	(
		SELECT CP.IdCategoriaPresupuestal, CP.Nombre, S.IdServicio
		FROM Purchasing.CategoriasPresupuestales CP INNER JOIN Purchasing.DepartamentosCategorias DC 
			ON DC.IdCategoriaPresupuestal=CP.IdCategoriaPresupuestal
		INNER JOIN Purchasing.DepartamentosAccesos DA 
			ON DA.IdDepartamento=DC.IdDepartamento
		INNER JOIN Purchasing.CategoriasPresupuestalesServicios S 
			ON S.IdCategoriaPresupuestal=CP.IdCategoriaPresupuestal								
		WHERE DA.IdUSuario=@IdUsuario AND (S.IdServicio=@IdServicio OR @IdServicio=0)
		)


