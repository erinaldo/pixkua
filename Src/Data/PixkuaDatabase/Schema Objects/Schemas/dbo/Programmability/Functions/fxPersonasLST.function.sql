-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: <<FECHA>>
-- Description:	Obtiene una lista de búsqueda de <<>>
-- =============================================
CREATE FUNCTION [dbo].[fxPersonasLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT P.IdPersona, P.Nombre, P.ApellidoP + ' ' + P.ApellidoM AS Apellidos, P.Calle, P.Colonia, POB.Poblacion, 
		M.Nombre AS Municipio, E.Estado, P.TelCasa AS [Telefono Casa], P.TelOficina AS [Telefono Oficina], P.Celular
	FROM dbo.Personas P LEFT JOIN dbo.Poblaciones POB
		ON P.IdPoblacion=POB.IdPoblacion
	LEFT JOIN dbo.Municipios M 
		ON POB.IdMunicipio=M.IdMunicipio
	LEFT JOIN dbo.Estados E
		ON M.IdEstado=E.IdEstado
	)


