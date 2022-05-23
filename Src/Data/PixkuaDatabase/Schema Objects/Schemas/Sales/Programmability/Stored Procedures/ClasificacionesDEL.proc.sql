CREATE PROCEDURE [Sales].[ClasificacionesDEL]
	@IdClasificacion as int
AS
	SET NOCOUNT ON
	
	DELETE Sales.Clasificaciones WHERE IdClasificacion=@IdClasificacion


