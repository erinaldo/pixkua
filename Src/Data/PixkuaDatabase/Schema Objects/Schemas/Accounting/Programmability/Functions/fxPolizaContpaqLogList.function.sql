CREATE FUNCTION [Accounting].[fxPolizaContpaqLogList](@Fecha as datetime,@IdServicio as integer)
RETURNS Table
AS
	RETURN(	SELECT T.IdPolizaTit,S.Nombre + ' - '+ TP.Nombre AS Nombre,D.Cargo,D.Abono,D.Registros,IsNull(EBD.BaseDatos,'') AS BaseDatos
			FROM Accounting.PolizasTit T
			INNER JOIN Accounting.PolizasPerfiles PP ON PP.IdPolizaPerfil=T.IdPolizaPerfil
			INNER JOIN Sucursales S ON S.IdSucursal=T.IdSucursal
			INNER JOIN (SELECT IdPolizaTit,Fecha,Count(IdPolizaTit) as Registros,SUM(Cargo)AS Cargo,SUM(Abono)as Abono
						FROM Accounting.PolizasDet D
						GROUP BY IdPolizaTit,Fecha)AS D ON D.IdPolizaTit=T.IdPolizaTit AND D.Fecha=T.Fecha
			INNER JOIN Accounting.PolizasTipos TP ON TP.IdPolizaTipo=PP.IdPolizaTipo
			INNER JOIN Accounting.EmpresasConfig EBD ON EBD.IdEmpresa=S.IdEmpresa
			WHERE T.IdStatus=1 AND T.Fecha BETWEEN dateadd(dd,-15,@Fecha) and @Fecha 
						AND Registros>0 AND EBD.IdServicio=@IdServicio --AND T.IdPolizaTit='000007201100600003'
	)


