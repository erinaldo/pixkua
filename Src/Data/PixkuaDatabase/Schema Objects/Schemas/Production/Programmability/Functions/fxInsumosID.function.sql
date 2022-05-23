-- =============================================
-- Author: alez lopez
-- ALTER  date: 04-mar-2011
-- Description:	Obtiene el ID de Insumos en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Production].[fxInsumosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdInsumo
	FROM Production.Insumos
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


