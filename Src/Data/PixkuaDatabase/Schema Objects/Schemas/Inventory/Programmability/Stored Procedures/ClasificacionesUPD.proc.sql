CREATE PROCEDURE [Inventory].[ClasificacionesUPD]
	@IdClasificacion as int,
	@IdClasificacionGrupo as int,
	@Nombre as varchar(64),
	@Valor as int,
	@Referencia as varchar(32),
	@IdCuenta as int
AS
	SET NOCOUNT ON
	
	IF @IdClasificacion=0
	BEGIN
		EXEC dbo.NewKey 'Inventory.Clasificaciones', @IdClasificacion out
		
		INSERT INTO Inventory.Clasificaciones(IdClasificacion, IdClasificacionGrupo, Nombre, Valor, Referencia, IdCuenta)
		VALUES (@IdClasificacion, @IdClasificacionGrupo, @Nombre, @Valor, @Referencia, @IdCuenta)
	END
	ELSE
		UPDATE Inventory.Clasificaciones SET Nombre=@Nombre, Valor=@Valor, Referencia=@Referencia, IdCuenta=@IdCuenta
		WHERE IdClasificacion=@IdClasificacion


