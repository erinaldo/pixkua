CREATE FUNCTION [Purchasing].[fxPresupuestoCategoriasSEL](@IdPeriodo as int,@IdDepartamento as int)
RETURNS TABLE
AS
RETURN(
		SELECT --IsNull(D.AdmonPresupuesto,'N')AS AdmonPresupuesto, IsNull(P.IdPresupuesto,0)AS IdPresupuesto,IsNull(P.MontoPresupuesto,0)AS Presupuestado,IsNull(P.MontoUtilizado,0)AS Utilizado,ISNULL(P.MontoApartado,0)AS Apartado,
			   DC.IdCategoriaPresupuestal,CP.Nombre AS CategoriaPresupuestal,IsNull(PC.MontoPresupuesto,0)AS Presupuestado,IsNull(PC.MontoUtilizado,0)AS Utilizado,IsNull(PC.MontoApartado,0)AS Apartado,IsNull(PC.MontoPresupuesto,0)-IsNull(PC.MontoUtilizado,0)-IsNull(PC.MontoApartado,0) AS Disponible
		FROM RH.Departamentos Drh
		LEFT JOIN Purchasing.Departamentos D ON D.IdDepartamento=Drh.IdDepartamento
		LEFT JOIN Purchasing.DepartamentosCategorias DC ON DC.IdDepartamento=D.IdDepartamento
		LEFT JOIN Purchasing.Presupuestos P ON P.IdDepartamento=D.IdDepartamento AND P.IdPeriodo=@IdPeriodo
		LEFT JOIN Purchasing.PresupuestosCategorias PC ON PC.IdPresupuesto=P.IdPresupuesto AND PC.IdCategoriaPresupuestal=DC.IdCategoriaPresupuestal
		LEFT JOIN Purchasing.CategoriasPresupuestales CP ON CP.IdCategoriaPresupuestal=DC.IdCategoriaPresupuestal
		WHERE Drh.IdDepartamento=@IdDepartamento 
)


