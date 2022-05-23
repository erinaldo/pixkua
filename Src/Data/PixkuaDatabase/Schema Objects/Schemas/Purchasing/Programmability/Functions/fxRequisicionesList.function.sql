-- =============================================
-- Author: alex lopez
-- Create date: 07-nov-2011
-- Description:	Obtiene una lista de búsqueda de Requisiciones
-- =============================================
CREATE FUNCTION [Purchasing].[fxRequisicionesList](@FechaIni as datetime, @FechaFin as Datetime, @IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT CAST(0 AS BIT)AS Sel, T.IdRequisicion AS ID, T.Fecha, RT.Nombre AS Tipo,Per.Nombre AS Periodo, Drh.Nombre AS Departamento, 
		IsNull(AX.Nombre, S.Nombre) AS Descripcion, T.Cantidad, T.IdStatus,Es.[StatusApplied] AS Estatus, CR.Nombre AS CentroRecepcion, 
		CP.Nombre AS CategoriaPresupuestal
	FROM Purchasing.Requisiciones T JOIN Purchasing.DepartamentosAccesos DA 
		ON DA.IdDepartamento=T.IdDepartamento AND DA.IdUsuario=@IdUsuario
	JOIN RH.Departamentos Drh 
		ON Drh.IdDepartamento=T.IdDepartamento	
	JOIN Purchasing.CentrosRecepcion CR 
		ON CR.IdCentroRecepcion=T.IdCentroRecepcion
	JOIN Purchasing.RequisicionesTipos RT 
		ON RT.IdRequisicionTipo=T.IdRequisicionTipo
	LEFT JOIN Purchasing.Presupuestos P 
		ON P.IdPresupuesto= T.IdPresupuesto
	LEFT JOIN Purchasing.Periodos Per 
		ON Per.IdPeriodo=P.IdPeriodo
	LEFT JOIN Purchasing.Servicios S 
		ON S.IdServicio=T.IdServicio 
	LEFT JOIN Inventory.ArticulosStock AX 
		ON AX.IdArticuloStock=T.IdArticuloStock
	LEFT JOIN Purchasing.CategoriasPresupuestales CP 
		ON CP.IdCategoriaPresupuestal=T.IdCategoriaPresupuestal
	JOIN Documents.[Status] Es 
		ON T.IdStatus=Es.IdStatus
	WHERE Fecha BETWEEN @FechaIni AND @FechaFin
		)


