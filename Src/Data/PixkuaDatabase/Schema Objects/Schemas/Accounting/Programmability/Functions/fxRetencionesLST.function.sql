-- =============================================
-- Author: alex Lopez
-- Create date: 24-nov-2011
-- Description:	Obtiene una lista de búsqueda de Retenciones
-- =============================================
CREATE FUNCTION [Accounting].[fxRetencionesLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdRetencion,Nombre,Porcentaje,CASE WHEN TipoRetencion=1 THEN'IVA'ELSE'ISR'END AS [Tipo de Retencion],
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Accounting.Retenciones
	WHERE IdSucursal=@IdSucursal
	)


