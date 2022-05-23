CREATE FUNCTION [Sales].[fxGrupoDescuentosServiciosSEL](@IdGrupoDescuento as int)
RETURNS TABLE
AS
	RETURN(	SELECT	S.IdServicio,IsNull(GDS.PorcDescuento1,0)AS PorcDescuento1, IsNull(GDS.PorcDescuento2,0)AS PorcDescuento2, IsNull(GDS.PorcDescuento3,0)AS PorcDescuento3, IsNull(GDS.PorcDescuento4,0)AS PorcDescuento4, IsNull(GDS.PorcDescuento5,0)AS PorcDescuento5,
					S.Codigo,S.Nombre As Servicio
			FROM Sales.Servicios S
			LEFT JOIN Sales.GruposDescuentoServicios GDS ON GDS.IdServicio=S.IdServicio AND GDS.IdGrupoDescuento=@IdGrupoDescuento
						
)


