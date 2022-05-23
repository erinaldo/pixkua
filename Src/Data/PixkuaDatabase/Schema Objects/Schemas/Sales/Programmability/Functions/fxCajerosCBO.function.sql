CREATE FUNCTION [Sales].[fxCajerosCBO](@IdSucursal AS INT)
RETURNS TABLE
AS
	RETURN(	
			SELECT IdCajero,P.Nombre+' '+P.ApellidoP+' '+P.ApellidoM As Nombre
			FROM Sales.Cajeros Cjr
			INNER JOIN RH.Empleados E ON E.IdEmpleado=Cjr.IdEmpleado
			INNER JOIN Personas P ON P.IdPersona=E.IdPersona
			WHERE Cjr.IdSucursal=@IdSucursal AND Cjr.IdStatus=1
	)


