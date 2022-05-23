-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 30-DIC-2005
-- Description:	Obtiene la información de la empresa especificada.
-- =============================================

CREATE  FUNCTION [dbo].[fxEmpresasSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT E.*, 0 AS IdSucursal FROM dbo.Empresas E WHERE IdEmpresa=@ID)


