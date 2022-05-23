-- =============================================
-- Author: alez lopez
-- ALTER  date: 27-jun-2011
-- Description:	Obtiene el ID de CentrosConsumo en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Restaurant].[fxCentrosConsumoID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdCentroConsumo
	FROM Restaurant.CentrosConsumo
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


