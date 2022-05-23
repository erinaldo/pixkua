CREATE FUNCTION [Purchasing].[fxPresupuestoRPT](@IdPeriodo as int,@IdUsuario as int)
RETURNS TABLE
AS
RETURN(
		SELECT  Drh.Nombre AS Departamento,IsNull(CP.Nombre,'Presupuesto Global') AS CategoriaPresupuestal,
			CASE WHEN D.AdmonPresupuesto='G'THEN P.MontoPresupuesto ELSE PC.MontoPresupuesto END AS MontoPresupuesto,
			CASE WHEN D.AdmonPresupuesto='G'THEN P.MontoApartado ELSE PC.MontoApartado END AS MontoApartado,
			CASE WHEN D.AdmonPresupuesto='G'THEN P.MontoUtilizado ELSE PC.MontoUtilizado END AS MontoUtilizado,
			CASE WHEN D.AdmonPresupuesto='G'THEN P.MontoApartado-P.MontoApartado-P.MontoUtilizado ELSE PC.MontoApartado-PC.MontoApartado-PC.MontoUtilizado END AS Disponible
		FROM Purchasing.Presupuestos P
		INNER JOIN RH.Departamentos Drh ON Drh.IdDepartamento=P.IdDepartamento
		INNER JOIN Purchasing.Departamentos D ON D.IdDepartamento=P.IdDepartamento
		LEFT JOIN Purchasing.PresupuestosCategorias AS PC ON PC.IdPresupuesto=P.IdPresupuesto
		LEFT JOIN Purchasing.CategoriasPresupuestales CP ON CP.IdCategoriaPresupuestal=PC.IdCategoriaPresupuestal
		WHERE P.IdPeriodo=@IdPeriodo
)


