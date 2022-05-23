-- =============================================
-- Author: Victor Moreno
-- Create date: 23-nov-2016
-- Description:	Verifica la existencia de MaestrosIng
-- =============================================
CREATE FUNCTION Production.fxMaestrosIngExists(@ID AS char(18))
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdMaestroIng FROM Production.MaestrosIng WHERE IdMaestroIng=@ID and Fecha=dbo.fxDocumentDate(@Id))
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END
