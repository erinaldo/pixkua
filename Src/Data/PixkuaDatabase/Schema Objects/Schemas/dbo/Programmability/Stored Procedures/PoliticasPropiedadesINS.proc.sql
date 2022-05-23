CREATE PROCEDURE [dbo].[PoliticasPropiedadesINS]
	@IdPolitica AS int,
	@IdPropiedadControl AS int,
	@Valor AS varchar(64)
AS
	SET NOCOUNT ON
	
	INSERT INTO PoliticasPropiedades (IdPolitica, IdPropiedadControl, Valor)
	VALUES (@IdPolitica, @IdPropiedadControl, @Valor)
	
	RETURN


