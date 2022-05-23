-- =============================================
-- Author: alex Lopez
-- Create date: 02-dic-2011
-- Description:	Elimina el Beneficiarios especificado.
-- =============================================
CREATE PROCEDURE [Treasury].[BeneficiariosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Treasury.Beneficiarios SET IdStatus=0 WHERE IdBeneficiario=@ID


