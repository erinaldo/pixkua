-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 30-DIC-2005
-- Description:	Verifica la existencia de la empresa especificada.
-- =============================================

CREATE  FUNCTION [dbo].[fxEmpresasExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdEmpresa FROM dbo.Empresas WHERE IdEmpresa=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


