-- =============================================
-- Author: alez lopez
-- Create date: 04-mar-2011
-- Description:	Verifica la existencia de Insumos
-- =============================================
CREATE FUNCTION [Production].[fxInsumosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdInsumo FROM Production.Insumos WHERE IdInsumo=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


