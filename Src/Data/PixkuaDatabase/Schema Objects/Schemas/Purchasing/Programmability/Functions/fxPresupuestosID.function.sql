-- =============================================
-- Author: alex Lopez
-- ALTER  date: 02-nov-2011
-- Description:	Obtiene el ID de Presupuestos en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Purchasing].[fxPresupuestosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdPresupuesto
	FROM Purchasing.Presupuestos
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


