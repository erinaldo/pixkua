-- =============================================
-- Author: RCO
-- Create date: 04-abr-2011
-- Description:	Verifica la existencia de NotasTit
-- =============================================
CREATE FUNCTION [Accounting].[fxNotasTitExists](@ID AS char(18))
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdNotaTit FROM Accounting.NotasTit WHERE IdNotaTit=@ID and Fecha=Documents.fxDocumentDate(@Id))
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


