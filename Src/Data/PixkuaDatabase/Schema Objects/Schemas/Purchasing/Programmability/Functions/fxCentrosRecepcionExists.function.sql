-- =============================================
-- Author: alez lopez
-- Create date: 19-oct-2011
-- Description:	Verifica la existencia de CentrosRecepcion
-- =============================================
CREATE FUNCTION [Purchasing].[fxCentrosRecepcionExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdCentroRecepcion FROM Purchasing.CentrosRecepcion WHERE IdCentroRecepcion=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


