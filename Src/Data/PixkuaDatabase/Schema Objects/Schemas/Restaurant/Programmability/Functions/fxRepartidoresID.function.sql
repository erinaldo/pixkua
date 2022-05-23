-- =============================================
-- Author: alez Lopez
-- ALTER  date: 08-ago-2011
-- Description:	Obtiene el ID de Repartidores en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Restaurant].[fxRepartidoresID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdRepartidor
	FROM Restaurant.Repartidores
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


