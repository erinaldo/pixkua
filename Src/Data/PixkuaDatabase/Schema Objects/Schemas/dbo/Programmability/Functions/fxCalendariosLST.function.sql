-- =============================================
-- Author: RCO
-- Create date: 14-jul-2011
-- Description:	Obtiene una lista de búsqueda de Calendarios
-- =============================================
CREATE FUNCTION [dbo].[fxCalendariosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdCalendario, Nombre, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM dbo.Calendarios
	WHERE IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	)


