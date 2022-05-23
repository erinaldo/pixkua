CREATE PROCEDURE [dbo].[UnidadesMedidaSEL]
AS

	SELECT IdUnidadMedida, Codigo, 
			Nombre, Base, Factor
	FROM UnidadesMedida


