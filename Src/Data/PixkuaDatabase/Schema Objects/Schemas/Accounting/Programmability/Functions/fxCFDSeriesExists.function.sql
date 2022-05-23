-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Verifica la existencia de CFDSeries
-- =============================================
CREATE FUNCTION [Accounting].[fxCFDSeriesExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdCFDSerie FROM Accounting.CFDSeries WHERE IdCFDSerie=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


