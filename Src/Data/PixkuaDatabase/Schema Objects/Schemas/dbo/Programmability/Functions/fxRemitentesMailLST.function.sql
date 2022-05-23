-- =============================================
-- Author: RCO
-- Create date: 24-oct-2010
-- Description:	Obtiene una lista de búsqueda de RemitentesMail
-- =============================================
CREATE FUNCTION [dbo].[fxRemitentesMailLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT RM.IdRemitenteMail, RM.Nombre, RM.MailAddress AS Correo, S.HostName AS Servidor, RM.Codigo,
		CASE RM.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM dbo.RemitentesMail RM JOIN dbo.ServidoresSMTP S
		ON RM.IdServidorSMTP=S.IdServidorSMTP
	WHERE RM.IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)		
	)


