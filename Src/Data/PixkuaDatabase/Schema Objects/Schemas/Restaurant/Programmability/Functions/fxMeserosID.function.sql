-- =============================================
-- Author: alez lopez
-- ALTER  date: 27-jun-2011
-- Description:	Obtiene el ID de Meseros en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Restaurant].[fxMeserosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdMesero
	FROM Restaurant.Meseros
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


