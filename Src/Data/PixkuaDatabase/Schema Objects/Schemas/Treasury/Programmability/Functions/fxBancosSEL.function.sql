-- =============================================
-- Author: alex Lopez
-- Create date: 02-dic-2011
-- Description:	Obtiene la información del Bancos especificado.
-- =============================================
CREATE FUNCTION [Treasury].[fxBancosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Treasury.Bancos WHERE IdBanco=@ID)


