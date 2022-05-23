CREATE FUNCTION [Purchasing].[fxCentrosRecepcionListSEL](@IdEmpresa as int)
RETURNS TABLE
AS
	RETURN(	SELECT IdCentroRecepcion,CR.Nombre,CR.IdAlmacen,CR.IdCuenta,Calle,Colonia,CP,NumExt,NumInt,IdPoblacion,IdMunicipio,Tel1,Tel2,Fax,IsNull(C.Codigo,'') AS Cuenta,IsNull(C.Nombre,'') AS Concepto,A.Nombre AS Almacen
			FROM Purchasing.CentrosRecepcion CR
			INNER JOIN Inventory.Almacenes A ON A.IdAlmacen=CR.IdAlmacen
			LEFT JOIN Accounting.Cuentas C ON C.IdCuenta=CR.IdCuenta
			WHERE CR.IdEmpresa=@IdEmpresa AND CR.IdStatus=1
)


