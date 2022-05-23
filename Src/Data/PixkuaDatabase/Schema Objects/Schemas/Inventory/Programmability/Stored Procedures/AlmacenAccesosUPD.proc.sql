CREATE PROCEDURE [Inventory].[AlmacenAccesosUPD]
	@IdAlmacen as int,
	@IdUsuario as int,
	@Entrada as bit,
	@Salida as bit
AS
	SET NOCOUNT ON
	
	IF EXISTS(SELECT IdAlmacen FROM Inventory.AlmacenesUsuarios WHERE IdAlmacen=@IdAlmacen AND IdUsuario=@IdUsuario)	
		UPDATE Inventory.AlmacenesUsuarios SET Entrada=@Entrada, Salida=@Salida
		WHERE IdAlmacen=@IdAlmacen AND IdUsuario=@IdUsuario	
	ELSE
		INSERT INTO Inventory.AlmacenesUsuarios (IdAlmacen, IdUsuario, Entrada, Salida)
		VALUES (@IdAlmacen, @IdUsuario, @Entrada, @Salida)


