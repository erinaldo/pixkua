-- =============================================
-- Author: alex Lopez
-- ALTER  date: 02-dic-2011
-- Description:	Obtiene el ID de Beneficiarios en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Treasury].[fxBeneficiariosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdBeneficiario
	FROM Treasury.Beneficiarios
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


