-- =============================================
-- Author: RCO
-- ALTER  date: 14-jul-2011
-- Description:	Obtiene el ID de Calendarios en base a su código de usuario.
-- =============================================

CREATE FUNCTION [dbo].[fxCalendariosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdCalendario
	FROM dbo.Calendarios
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


