-- =============================================
-- Author: RCO
-- ALTER  date: 02-nov-2010
-- Description:	Obtiene el ID de Operadores en base a su código de usuario.
-- =============================================

CREATE FUNCTION [dbo].[fxOperadoresID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdOperador
	FROM dbo.Operadores
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


