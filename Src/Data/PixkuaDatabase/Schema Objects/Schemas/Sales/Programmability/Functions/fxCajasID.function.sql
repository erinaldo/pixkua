﻿-- =============================================
-- Author: alez Lopez
-- ALTER  date: 30-jun-2011
-- Description:	Obtiene el ID de Cajas en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Sales].[fxCajasID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdCaja
	FROM Sales.Cajas
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


