-- =============================================
-- Author: alez lopez
-- ALTER  date: 19-oct-2011
-- Description:	Obtiene el ID de CategoriasPresupuestales en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Purchasing].[fxCategoriasPresupuestalesID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdCategoriaPresupuestal
	FROM Purchasing.CategoriasPresupuestales
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


