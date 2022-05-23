CREATE FUNCTION [Purchasing].[fxGastosList](@FechaIni as Datetime,@FechaFin as Datetime,@IdUsuario as int,@IdSucursal as int)
RETURNS TABLE
AS
RETURN(
	SELECT CAST(0 AS bit)as Sel, G.IdGasto AS ID,Fecha,D.Nombre AS Departamento,Pe.Nombre AS Periodo, CC.Nombre AS ConceptoCategoria, GC.Nombre AS Concepto,CP.Nombre AS CategoriaPresupuestal, CASE WHEN ModalidadPago='R'THEN'Reposicion'ELSE'Comprobacion'END AS Modalidad,
			CASE G.TipoBeneficiario 
			WHEN 'P' THEN 'Proveedor'
			WHEN 'E' THEN 'Empleado'
			WHEN 'O' THEN 'Beneficiario'
			END AS TipoBeneficiario,
			CASE G.TipoBeneficiario 
			WHEN 'P' THEN P.Nombre
			WHEN 'E' THEN Per.Nombre+' '+Per.ApellidoP+' '+Per.ApellidoM
			END AS Beneficiario,
			G.TipoCambio,G.Total,SerieFactura AS Serie,FolioFactura As Factura,S.StatusApplied AS Estatus,G.IdStatus
	FROM Purchasing.Gastos G
	INNER JOIN RH.Departamentos D ON D.IdDepartamento=G.IdDepartamento
	INNER JOIN Purchasing.DepartamentosAccesos DA ON DA.IdDepartamento=G.IdDepartamento AND DA.IdUsuario=@IdUsuario
	LEFT  JOIN Purchasing.Presupuestos Pr ON Pr.IdPresupuesto=G.IdPresupuesto
	LEFT  JOIN Purchasing.Periodos Pe ON Pe.IdPeriodo=Pr.IdPeriodo
	LEFT  JOIN Purchasing.CategoriasPresupuestales CP ON CP.IdCategoriaPresupuestal=G.IdCategoriaPresupuestal
	INNER JOIN Purchasing.GastosConceptos GC ON GC.IdGastoConcepto=G.IdGastoConcepto
	INNER JOIN Purchasing.GastosConceptosTipos CC ON CC.IdGastoConceptoTipo=GC.IdGastoConceptoTipo
	LEFT  JOIN Purchasing.Proveedores P ON P.IdProveedor=G.IdBeneficiario AND G.TipoBeneficiario='P'
	LEFT  JOIN RH.Empleados E ON E.IdEmpleado=G.IdBeneficiario AND G.TipoBeneficiario='E' 
	LEFT  JOIN Personas Per ON Per.IdPersona=E.IdPersona
	INNER JOIN Documents.Status S ON S.IdStatus=G.IdStatus
	--Divisa
	--Proveedor de la factura
	WHERE g.Fecha BETWEEN @FechaIni AND @FechaFin
)


