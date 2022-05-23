-- =============================================
-- Author: alex Lopez
-- Create date: 02-dic-2011
-- Description:	Obtiene la información del Beneficiarios especificado.
-- =============================================
CREATE FUNCTION [Treasury].[fxBeneficiariosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Treasury.Beneficiarios WHERE IdBeneficiario=@ID)


