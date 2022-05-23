CREATE PROCEDURE [Inventory].[ClasificacionesArticulosUPD]
	@IdArticuloStock as int,
	@IdClasificacionGrupo as int,
	@IdClasificacion as int
AS
	SET NOCOUNT ON

	--> Eliminar cualquier clasificación del mismo grupo que pueda existir
	DELETE Inventory.ClasificacionesArticulos
	FROM Inventory.ClasificacionesArticulos CA JOIN Inventory.Clasificaciones C
		ON CA.IdClasificacion=C.IdClasificacion
	WHERE IdClasificacionGrupo=@IdClasificacionGrupo AND CA.IdArticuloStock=@IdArticuloStock

	INSERT INTO Inventory.ClasificacionesArticulos(IdArticuloStock, IdClasificacion)
	VALUES (@IdArticuloStock, @IdClasificacion)


