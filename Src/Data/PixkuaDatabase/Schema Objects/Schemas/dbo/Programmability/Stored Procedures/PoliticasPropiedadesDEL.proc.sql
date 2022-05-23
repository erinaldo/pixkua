CREATE PROCEDURE [dbo].[PoliticasPropiedadesDEL] 
	@IdPolitica AS int,
	@IdPropiedadControl AS int
AS
	SET NOCOUNT ON
	
	DELETE PoliticasPropiedades
	WHERE IdPolitica=@IdPolitica AND IdPropiedadControl=@IdPropiedadControl
	
	RETURN


