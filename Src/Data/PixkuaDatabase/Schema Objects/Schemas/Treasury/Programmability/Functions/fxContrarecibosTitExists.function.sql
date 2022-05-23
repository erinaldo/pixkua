-- =============================================
-- Author: alex Lopez
-- Create date: 29-nov-2011
-- Description:	Verifica la existencia de ContrarecibosTit
-- =============================================
CREATE FUNCTION [Treasury].[fxContrarecibosTitExists](@ID AS char(18))
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdContrareciboTit FROM Treasury.ContrarecibosTit WHERE IdContrareciboTit=@ID and Fecha=Documents.fxDocumentDate(@Id))
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


