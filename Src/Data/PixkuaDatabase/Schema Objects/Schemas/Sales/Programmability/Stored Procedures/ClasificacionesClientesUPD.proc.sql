CREATE PROCEDURE [Sales].[ClasificacionesClientesUPD]
	@IdCliente as int,
	@IdClasificacionGrupo as int,
	@IdClasificacion as int
AS
	SET NOCOUNT ON

	--> Eliminar cualquier clasificación del mismo grupo que pueda existir
	DELETE Sales.ClasificacionesClientes
	FROM Sales.ClasificacionesClientes CA JOIN Sales.Clasificaciones C
		ON CA.IdClasificacion=C.IdClasificacion
	WHERE IdClasificacionGrupo=@IdClasificacionGrupo AND CA.IdCliente=@IdCliente

	INSERT INTO Sales.ClasificacionesClientes(IdCliente, IdClasificacion)
	VALUES (@IdCliente, @IdClasificacion)


