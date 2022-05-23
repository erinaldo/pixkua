-- =============================================
-- Author: alex Lopez
-- Create date: 24-nov-2011
-- Description:	Verifica la existencia de Retenciones
-- =============================================
CREATE FUNCTION [Accounting].[fxRetencionesExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdRetencion FROM Accounting.Retenciones WHERE IdRetencion=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


