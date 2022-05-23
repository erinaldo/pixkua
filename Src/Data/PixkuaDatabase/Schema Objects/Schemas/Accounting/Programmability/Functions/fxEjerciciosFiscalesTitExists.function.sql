-- =============================================
-- Author: alez Lopez
-- Create date: 13-sep-2011
-- Description:	Verifica la existencia de EjerciciosFiscalesTit
-- =============================================
CREATE FUNCTION [Accounting].[fxEjerciciosFiscalesTitExists](@ID AS char(18))
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdEjercicioFiscalTit FROM Accounting.EjerciciosFiscalesTit WHERE IdEjercicioFiscalTit=@ID and Fecha=Documents.fxDocumentDate(@Id))
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


