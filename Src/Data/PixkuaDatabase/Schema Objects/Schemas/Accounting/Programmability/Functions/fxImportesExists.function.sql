-- =============================================
-- Author: alez Lopez
-- Create date: 18-oct-2010
-- Description:	Verifica la existencia de Importes
-- =============================================
CREATE FUNCTION [Accounting].[fxImportesExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdImporte FROM Accounting.Importes WHERE IdImporte=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


