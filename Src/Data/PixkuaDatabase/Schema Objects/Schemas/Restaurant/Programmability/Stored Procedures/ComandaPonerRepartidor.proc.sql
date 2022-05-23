CREATE PROCEDURE [Restaurant].[ComandaPonerRepartidor]
@IdComandaTit AS CHAR(18),
@IdRepartidor AS int
AS
	UPDATE Restaurant.ComandaTit SET IdRepartidor=@IdRepartidor WHERE IdComandaTit=@IdComandaTit AND Fecha=Documents.fxDocumentDate(@IdComandaTit)


