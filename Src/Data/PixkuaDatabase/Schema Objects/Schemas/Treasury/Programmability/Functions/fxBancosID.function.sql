-- =============================================
-- Author: alex Lopez
-- ALTER  date: 02-dic-2011
-- Description:	Obtiene el ID de Bancos en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Treasury].[fxBancosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdBanco
	FROM Treasury.Bancos
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


