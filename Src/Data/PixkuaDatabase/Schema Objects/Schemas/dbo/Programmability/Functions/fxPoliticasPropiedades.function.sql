CREATE FUNCTION [dbo].[fxPoliticasPropiedades]
	(@IdPolitica AS int)
RETURNS TABLE
AS
RETURN
(
	SELECT PP.IdPoliticaPropiedad, PC.Propiedad, PP.Valor, PC.DataType
	FROM dbo.PoliticasPropiedades PP 
	JOIN dbo.PropiedadesControles PC
		ON PP.IdPropiedadControl=PC.IdPropiedadControl
	WHERE PP.IdPolitica=@IdPolitica
)


