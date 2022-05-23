CREATE PROCEDURE [Inventory].[UsuarioAlmacenesUPD]
	@IdAlmacen as int,
	@IdUsuario as int,
	@Entrada as bit,
	@Salida as bit,
	@Selected AS bit
AS
	SET NOCOUNT ON
	
	IF @Selected=1
	BEGIN
		IF EXISTS(SELECT IdAlmacen FROM Inventory.AlmacenesUsuarios WHERE IdAlmacen=@IdAlmacen AND IdUsuario=@IdUsuario)
			UPDATE Inventory.AlmacenesUsuarios SET Entrada=@Entrada, Salida=@Salida
			WHERE IdAlmacen=@IdAlmacen AND IdUsuario=@IdUsuario
		ELSE
			INSERT INTO Inventory.AlmacenesUsuarios(IdAlmacen, Entrada, Salida, IdUsuario)
			VALUES (@IdAlmacen, @Entrada, @Salida, @IdUsuario)
	END

	IF @Selected=0
		DELETE Inventory.AlmacenesUsuarios
		WHERE IdAlmacen=@IdAlmacen AND IdUsuario=@IdUsuario


