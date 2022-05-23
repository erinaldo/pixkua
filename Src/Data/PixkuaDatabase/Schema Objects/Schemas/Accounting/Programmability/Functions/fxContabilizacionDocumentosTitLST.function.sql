-- =============================================
-- Author: alexLopez
-- Create date: 15-oct-2010
-- Description:	Obtiene una lista de búsqueda de ContabilizacionDocumentosTit
-- =============================================
CREATE FUNCTION [Accounting].[fxContabilizacionDocumentosTitLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdContabilizacionDocumentoTit,VT.Descripcion AS [Vista Contable],
		CASE T.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Accounting.ContabilizacionDocumentosTit T
	INNER JOIN Accounting.VistasContablesTit VT ON VT.IdVistaContableTit=T.IdVistaContableTit
	WHERE T.IdEmpresa IN (SELECT IdEmpresa FROM Sucursales WHERE IdSucursal=@IdSucursal)
	)


