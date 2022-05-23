-- =============================================
-- Author: RCO
-- Create date: 11-oct-2010
-- Description:	Verifica la existencia de Turnos
-- =============================================
CREATE FUNCTION [Inventory].[fxTurnosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdTurno FROM Inventory.Turnos WHERE IdTurno=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


