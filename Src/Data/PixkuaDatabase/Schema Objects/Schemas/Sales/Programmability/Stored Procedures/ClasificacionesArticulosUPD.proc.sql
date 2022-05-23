CREATE PROCEDURE [Sales].[ClasificacionesArticulosUPD]
	@IdArticulo as int,
	@IdClasificacionGrupo as int,
	@IdClasificacion as int
AS
	SET NOCOUNT ON

	--> Eliminar cualquier clasificación del mismo grupo que pueda existir
	DELETE Sales.ClasificacionesArticulos
	FROM Sales.ClasificacionesArticulos CA JOIN Sales.Clasificaciones C
		ON CA.IdClasificacion=C.IdClasificacion
	WHERE IdClasificacionGrupo=@IdClasificacionGrupo AND CA.IdArticulo=@IdArticulo

	INSERT INTO Sales.ClasificacionesArticulos(IdArticulo, IdClasificacion)
	VALUES (@IdArticulo, @IdClasificacion)


