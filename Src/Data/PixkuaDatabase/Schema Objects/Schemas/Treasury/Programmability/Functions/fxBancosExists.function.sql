﻿-- =============================================
-- Author: alex Lopez
-- Create date: 02-dic-2011
-- Description:	Verifica la existencia de Bancos
-- =============================================
CREATE FUNCTION [Treasury].[fxBancosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdBanco FROM Treasury.Bancos WHERE IdBanco=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


