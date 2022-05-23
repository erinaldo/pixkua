-- =============================================
-- Author: alex Lopez
-- Create date: 10-ene-2011
-- Description:	Verifica la existencia de SegmentosNegocio
-- =============================================
CREATE FUNCTION [Accounting].[fxSegmentosNegocioExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdSegmentoNegocio FROM Accounting.SegmentosNegocio WHERE IdSegmentoNegocio=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


