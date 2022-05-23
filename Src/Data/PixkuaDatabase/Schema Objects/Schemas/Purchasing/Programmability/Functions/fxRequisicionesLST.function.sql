-- =============================================
-- Author: alex lopez
-- Create date: 07-nov-2011
-- Description:	Obtiene una lista de búsqueda de Requisiciones
-- =============================================
CREATE FUNCTION [Purchasing].[fxRequisicionesLST](@IdUsuario AS char(18), @IdSucursal AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.IdRequisicion, T.Fecha, RT.Nombre AS Tipo,Per.Nombre AS Periodo,Drh.Nombre AS Departamento,(CASE WHEN T.IdServicio>0 THEN S.Nombre ELSE AX.Descripcion END) AS Descripcion,T.Cantidad,  
	T.IdStatus,Es.[Status] AS Estatus,CR.Nombre AS CentroRecepcion,CP.Nombre AS CategoriaPresupuestal
	FROM Purchasing.Requisiciones T 
	JOIN Purchasing.RequisicionesTipos RT ON RT.IdRequisicionTipo=T.IdRequisicionTipo
	JOIN Purchasing.Presupuestos P ON P.IdPresupuesto= T.IdPresupuesto
	JOIN Purchasing.Periodos Per on Per.IdPeriodo=P.IdPeriodo
	JOIN RH.Departamentos Drh ON Drh.IdDepartamento=T.IdDepartamento
	JOIN Purchasing.CentrosRecepcion CR ON CR.IdCentroRecepcion=T.IdCentroRecepcion
	LEFT JOIN Purchasing.Servicios S ON S.IdServicio=T.IdServicio 
	LEFT JOIN Inventory.ArticulosStock AX ON AX.IdArticuloStock=T.IdArticuloStock
	LEFT JOIN Purchasing.CategoriasPresupuestales CP ON CP.IdCategoriaPresupuestal=T.IdCategoriaPresupuestal
	JOIN Documents.[Status] Es ON T.IdStatus=Es.IdStatus
	WHERE T.IdSucursal=@IdSucursal
		)


