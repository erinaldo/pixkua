-- =============================================
-- Author: alez lopez
-- ALTER  date: 19-oct-2011
-- Description:	Obtiene el ID de Centrales en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Purchasing].[fxCentralesID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdCentral
	FROM Purchasing.Centrales
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


