﻿-- =============================================
-- Author: RCO
-- ALTER  date: 22-sep-2011
-- Description:	Obtiene el ID de DevolucionesCausas en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Sales].[fxDevolucionesCausasID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdDevolucionCausa
	FROM Sales.DevolucionesCausas
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


