-- =============================================
-- Author: RCO
-- ALTER  date: 30-jun-2011
-- Description:	Obtiene el ID de ClasificacionesGrupos en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Sales].[fxClasificacionesGruposID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdClasificacionGrupo
	FROM Sales.ClasificacionesGrupos
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


