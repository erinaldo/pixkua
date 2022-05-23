-- =============================================
-- Author: alex Lopez
-- Create date: 08-nov-2010
-- Description:	Verifica la existencia de PolizasTit
-- =============================================
CREATE FUNCTION [Accounting].[fxPolizasTitExists](@ID AS char(18))
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdPolizaTit FROM Accounting.PolizasTit WHERE IdPolizaTit=@ID and Fecha=Documents.fxDocumentDate(@Id))
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


