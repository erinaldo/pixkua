-- =============================================
-- Author: alexLopez
-- Create date: 08-oct-2010
-- Description:	Verifica la existencia de RacDet
-- =============================================
CREATE FUNCTION [Accounting].[fxRacDetExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdRacDet FROM Accounting.RacDet WHERE IdRacDet=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


