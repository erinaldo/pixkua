-- =============================================
-- Author: alex Lopez
-- Create date: 23-nov-2011
-- Description:	Obtiene una lista de búsqueda de Gastos
-- =============================================
CREATE FUNCTION [Purchasing].[fxGastosLST](@IdUsuario AS char(18), @IdSucursal AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.IdGasto, T.Fecha,Drh.Nombre AS Departamento,Per.Nombre AS Periodo, GC.Nombre AS Concepto,CP.Nombre AS [Categoria Presupuestal],
	CASE TipoBeneficiario 
		WHEN 'E' THEN 'Empleado: '+Peo.Nombre+' '+Peo.ApellidoP+' '+Peo.ApellidoM
		WHEN 'P' THEN 'Proveedor:'+P.RazonSocial
	END AS Beneficiario,D.Nombre AS Divisa, T.Total,T.SerieFactura AS Serie,T.FolioFactura AS Factura, S.[Status] AS Estatus
	FROM Purchasing.Gastos T 
	INNER JOIN Documents.[Status] S ON T.IdStatus=S.IdStatus
	INNER JOIN RH.Departamentos AS Drh ON Drh.IdDepartamento=T.IdDepartamento
	LEFT  JOIN Purchasing.Presupuestos as Pto on Pto.IdPresupuesto=T.IdPresupuesto
	LEFT  JOIN Purchasing.Periodos Per ON Per.IdPeriodo=Pto.IdPeriodo
	INNER JOIN Purchasing.GastosConceptos AS GC ON GC.IdGastoConcepto=T.IdGastoConcepto
	LEFT  JOIN Purchasing.CategoriasPresupuestales AS CP ON CP.IdCategoriaPresupuestal=T.IdCategoriaPresupuestal
	LEFT  JOIN Purchasing.Proveedores AS P ON P.IdProveedor=T.IdBeneficiario AND T.TipoBeneficiario='P'
	LEFT  JOIN RH.Empleados E ON E.IdEmpleado=T.IdBeneficiario AND T.TipoBeneficiario='E'
	LEFT  JOIN Personas AS Peo ON Peo.IdPersona=E.IdPersona
	INNER JOIN Accounting.Divisas AS D ON D.IdDivisa=T.IdDivisa
	WHERE T.IdSucursal=@IdSucursal
		)


