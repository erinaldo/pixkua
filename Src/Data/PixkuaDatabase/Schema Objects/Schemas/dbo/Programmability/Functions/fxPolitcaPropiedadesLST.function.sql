CREATE FUNCTION [dbo].[fxPolitcaPropiedadesLST](@IdPolitica AS int)
RETURNS TABLE
AS
RETURN (
	SELECT PP.IdPropiedadControl, PP.Valor, PC.UINombre, PC.DataType
	FROM PoliticasPropiedades PP JOIN PropiedadesControles PC
		ON PP.IdPropiedadControl=PC.IdPropiedadControl
	WHERE PP.IdPolitica=@IdPolitica
		)


