﻿-- =============================================
-- Author: RCO
-- ALTER  date: 11-ago-2011
-- Description:	Obtiene el ID de Puestos en base a su código de usuario.
-- =============================================

CREATE FUNCTION [RH].[fxPuestosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdPuesto
	FROM RH.Puestos
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


