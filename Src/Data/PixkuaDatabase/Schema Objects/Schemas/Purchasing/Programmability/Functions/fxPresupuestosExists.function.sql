-- =============================================
-- Author: alex Lopez
-- Create date: 02-nov-2011
-- Description:	Verifica la existencia de Presupuestos
-- =============================================
CREATE FUNCTION [Purchasing].[fxPresupuestosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdPresupuesto FROM Purchasing.Presupuestos WHERE IdPresupuesto=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


