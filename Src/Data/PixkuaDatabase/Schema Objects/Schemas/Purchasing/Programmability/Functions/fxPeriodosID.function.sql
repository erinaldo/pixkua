-- =============================================
-- Author: alez Lopez
-- ALTER  date: 01-nov-2011
-- Description:	Obtiene el ID de Periodos en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Purchasing].[fxPeriodosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdPeriodo
	FROM Purchasing.Periodos
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


