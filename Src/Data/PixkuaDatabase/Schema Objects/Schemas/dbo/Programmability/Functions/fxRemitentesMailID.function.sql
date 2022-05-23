-- =============================================
-- Author: RCO
-- ALTER  date: 24-oct-2010
-- Description:	Obtiene el ID de RemitentesMail en base a su código de usuario.
-- =============================================

CREATE FUNCTION [dbo].[fxRemitentesMailID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdRemitenteMail
	FROM dbo.RemitentesMail
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


