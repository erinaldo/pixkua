-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 26-Mar-2006
-- Description:	Obtiene la información del <<>> especificado.
-- =============================================
CREATE FUNCTION [dbo].[fxProcesosFormasSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT PF.*, PF.IdProcesoForma AS Codigo, 0 AS IdSucursal, 0 AS IdEmpresa
	FROM dbo.ProcesosFormas PF 
	WHERE PF.IdProcesoForma=@ID)


