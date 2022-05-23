-- =============================================
-- Author: RCO
-- ALTER  date: 11-oct-2010
-- Description:	Obtiene el ID de Turnos en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Inventory].[fxTurnosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdTurno
	FROM Inventory.Turnos
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


