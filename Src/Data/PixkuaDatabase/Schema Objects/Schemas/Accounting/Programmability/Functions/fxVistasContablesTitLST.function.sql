-- =============================================
-- Author: alez lopez
-- Create date: 17-oct-2010
-- Description:	Obtiene una lista de búsqueda de VistasContablesTit
-- =============================================
CREATE FUNCTION [Accounting].[fxVistasContablesTitLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdVistaContableTit,V.Codigo,Descripcion,[Schema],Objeto,IdObjeto,Referencia,T.Nombre AS Documento,
		CASE V.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Accounting.VistasContablesTit V
	INNER JOIN Documents.Tipos T ON T.IdDocumentoTipo=V.IdDocumentoTipo
--	WHERE IdSucursal=@IdSucursal
	)


