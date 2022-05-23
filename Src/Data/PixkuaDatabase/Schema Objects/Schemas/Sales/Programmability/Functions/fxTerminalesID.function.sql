﻿-- =============================================
-- Author: alez Lopez
-- ALTER  date: 31-ago-2011
-- Description:	Obtiene el ID de Terminales en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Sales].[fxTerminalesID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdTerminal
	FROM Sales.Terminales
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


