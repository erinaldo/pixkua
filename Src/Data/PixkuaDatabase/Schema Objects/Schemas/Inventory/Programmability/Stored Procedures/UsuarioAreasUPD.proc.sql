CREATE PROCEDURE [Inventory].[UsuarioAreasUPD]
	@IdArea as int,
	@IdUsuario as int,
	@Selected AS bit
AS
	SET NOCOUNT ON
	
	IF NOT EXISTS(SELECT IdArea FROM Inventory.AreasUsuarios WHERE IdArea=@IdArea AND IdUsuario=@IdUsuario) AND @Selected=1
		INSERT INTO Inventory.AreasUsuarios(IdArea, IdUsuario)
		VALUES (@IdArea, @IdUsuario)

	IF @Selected=0
		DELETE Inventory.AreasUsuarios
		WHERE IdArea=@IdArea AND IdUsuario=@IdUsuario


