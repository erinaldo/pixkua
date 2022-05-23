﻿CREATE FUNCTION [Sales].[fxClasificacionesSEL](@IdGrupo as int)
RETURNS TABLE
AS
RETURN	(
	SELECT CL.IdClasificacion, CL.Nombre, CL.Valor, CL.Referencia, CL.IdCuenta, 
		IsNull(C.Codigo, '') AS Cuenta, C.Nombre AS NombreCuenta
	FROM Sales.Clasificaciones CL LEFT JOIN Accounting.Cuentas C
		ON CL.IdCuenta=C.IdCuenta
	WHERE CL.IdClasificacionGrupo=@IdGrupo
		)


