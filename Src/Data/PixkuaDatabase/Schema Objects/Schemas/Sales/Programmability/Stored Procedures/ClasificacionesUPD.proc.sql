CREATE PROCEDURE [Sales].[ClasificacionesUPD]
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
		EXEC dbo.NewKey 'Sales.Clasificaciones', @IdClasificacion out
		
		INSERT INTO Sales.Clasificaciones(IdClasificacion, IdClasificacionGrupo, Nombre, Valor, Referencia, IdCuenta)
		VALUES (@IdClasificacion, @IdClasificacionGrupo, @Nombre, @Valor, @Referencia, @IdCuenta)
	END
	ELSE
		UPDATE Sales.Clasificaciones SET Nombre=@Nombre, Valor=@Valor, Referencia=@Referencia, IdCuenta=@IdCuenta
		WHERE IdClasificacion=@IdClasificacion


