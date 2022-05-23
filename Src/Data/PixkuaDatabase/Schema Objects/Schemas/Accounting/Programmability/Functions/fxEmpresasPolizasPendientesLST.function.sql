CREATE FUNCTION [Accounting].[fxEmpresasPolizasPendientesLST](@FechaIni as Datetime,@FechaFin as Datetime)
RETURNS Table
AS
	RETURN (
				SELECT	E.IdEmpresa,E.Nombre,IsNull(EBD.BaseDatos,'')AS BaseDatos,IsNull(EBD.IdServicio,0)AS IdServicio,
						IsNull(P.Pendientes,0)AS Pendientes
				FROM Empresas E
				LEFT JOIN Accounting.EmpresasConfig EBD ON EBD.Idempresa=E.IdEmpresa
				LEFT JOIN(	SELECT S.IdEmpresa,Count(IdPolizaTit)AS Pendientes
							FROM Accounting.PolizasTit PT 
							INNER JOIN Sucursales S ON S.IdSucursal=PT.IdSucursal
							WHERE PT.Fecha BETWEEN @FechaIni AND @FechaFin AND PT.IdStatus=1
							GROUP BY S.IdEmpresa
				)P ON P.IdEmpresa=E.IdEmpresa
	)


