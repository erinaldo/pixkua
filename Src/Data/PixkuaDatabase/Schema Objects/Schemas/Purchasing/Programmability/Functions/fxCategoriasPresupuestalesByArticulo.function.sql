CREATE FUNCTION [Purchasing].[fxCategoriasPresupuestalesByArticulo](@IdArticuloStock as int, @IdUsuario as int)
RETURNS TABLE
AS
RETURN	(
			SELECT CP.IdCategoriaPresupuestal, CP.Nombre, A.IdArticuloStock
			FROM Purchasing.CategoriasPresupuestales CP INNER JOIN Purchasing.DepartamentosCategorias DC 
				ON DC.IdCategoriaPresupuestal=CP.IdCategoriaPresupuestal
			INNER JOIN Purchasing.DepartamentosAccesos DA 
				ON DA.IdDepartamento=DC.IdDepartamento
			INNER JOIN Purchasing.CategoriasPresupuestalesArticulos A 
				ON A.IdCategoriaPresupuestal=CP.IdCategoriaPresupuestal
			WHERE DA.IdUSuario=@IdUsuario AND (A.IdArticuloStock=@IdArticuloStock OR @IdArticuloStock=0)
		)


