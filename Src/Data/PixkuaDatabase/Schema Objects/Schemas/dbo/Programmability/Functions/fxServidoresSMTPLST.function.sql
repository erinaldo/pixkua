-- =============================================
-- Author: RCO
-- Create date: 27-oct-2010
-- Description:	Obtiene una lista de búsqueda de ServidoresSMTP
-- =============================================
CREATE FUNCTION [dbo].[fxServidoresSMTPLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdServidorSMTP, Nombre, Hostname AS Servidor, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM dbo.ServidoresSMTP
	)


