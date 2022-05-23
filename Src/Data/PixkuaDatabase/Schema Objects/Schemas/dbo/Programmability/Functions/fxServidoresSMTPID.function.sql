-- =============================================
-- Author: RCO
-- ALTER  date: 27-oct-2010
-- Description:	Obtiene el ID de ServidoresSMTP en base a su código de usuario.
-- =============================================

CREATE FUNCTION [dbo].[fxServidoresSMTPID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdServidorSMTP
	FROM dbo.ServidoresSMTP
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


