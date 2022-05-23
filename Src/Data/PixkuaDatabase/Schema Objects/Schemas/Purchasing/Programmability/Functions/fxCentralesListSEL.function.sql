CREATE FUNCTION [Purchasing].[fxCentralesListSEL](@IdEmpresa as int)
RETURNS TABLE
AS
	RETURN(	SELECT C.IdCentral,C.Nombre,C.IdRemitente,C.IdOperador,C.EnviarOC,C.NotificarOC,C.IdCuenta,IsNull(Ct.Codigo,'') As Cuenta,IsNull(Ct.Nombre,'') As Concepto,R.Nombre AS Remitente,O.Nombre AS Operador,Caj.Nombre AS Caja,Z.Nombre AS ZonaCompra
			FROM Purchasing.Centrales C
			INNER JOIN Purchasing.ZonasCompra Z ON Z.IdZonaCompra=C.IdZonaCompra
			LEFT JOIN Treasury.Cajas Caj ON Caj.IdCaja=C.IdCaja
			LEFT JOIN Accounting.Cuentas Ct ON Ct.IdCuenta=C.IdCuenta
			LEFT JOIN RemitentesMail R ON R.IdRemitenteMail=C.IdRemitente
			LEFT JOIN Operadores O ON O.IdOperador=C.IdOperador
			WHERE C.IdEmpresa=@IdEmpresa AND C.IdStatus=1
)


