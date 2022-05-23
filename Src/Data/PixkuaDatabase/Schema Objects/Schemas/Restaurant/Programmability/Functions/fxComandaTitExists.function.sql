-- =============================================
-- Author: alez Lopez
-- Create date: 11-feb-2011
-- Description:	Verifica la existencia de ComandaTit
-- =============================================
CREATE FUNCTION [Restaurant].[fxComandaTitExists](@ID AS char(18))
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdComandaTit FROM Restaurant.ComandaTit WHERE IdComandaTit=@ID and Fecha=Documents.fxDocumentDate(@Id))
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


