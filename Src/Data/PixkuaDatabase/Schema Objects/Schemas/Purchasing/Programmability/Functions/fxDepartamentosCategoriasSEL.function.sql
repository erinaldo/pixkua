CREATE FUNCTION [Purchasing].[fxDepartamentosCategoriasSEL](@IdDepartamento as int)
RETURNS TABLE
AS
RETURN(	SELECT DC.IdCategoriaPresupuestal,CP.Nombre AS CategoriaPres
		FROM  Purchasing.DepartamentosCategorias DC
		INNER JOIN Purchasing.CategoriasPresupuestales CP ON CP.IdCategoriaPresupuestal=DC.IdCategoriaPresupuestal
		WHERE dc.IdDepartamento=@IdDepartamento
)


