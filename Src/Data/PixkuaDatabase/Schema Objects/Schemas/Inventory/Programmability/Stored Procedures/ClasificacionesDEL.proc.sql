CREATE PROCEDURE [Inventory].[ClasificacionesDEL]
	@IdClasificacion as int
AS
	SET NOCOUNT ON
	
	DELETE Inventory.Clasificaciones WHERE IdClasificacion=@IdClasificacion


