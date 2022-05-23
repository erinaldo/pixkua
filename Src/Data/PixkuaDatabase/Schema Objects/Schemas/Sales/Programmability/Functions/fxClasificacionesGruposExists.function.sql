﻿-- =============================================
-- Author: RCO
-- Create date: 30-jun-2011
-- Description:	Verifica la existencia de ClasificacionesGrupos
-- =============================================
CREATE FUNCTION [Sales].[fxClasificacionesGruposExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdClasificacionGrupo FROM Sales.ClasificacionesGrupos WHERE IdClasificacionGrupo=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


