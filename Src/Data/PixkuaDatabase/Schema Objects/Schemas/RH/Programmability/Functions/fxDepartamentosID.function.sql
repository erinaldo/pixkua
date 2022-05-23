-- =============================================
-- Author: RCO
-- ALTER  date: 11-ago-2011
-- Description:	Obtiene el ID de Departamentos en base a su código de usuario.
-- =============================================

CREATE FUNCTION [RH].[fxDepartamentosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdDepartamento
	FROM RH.Departamentos
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


