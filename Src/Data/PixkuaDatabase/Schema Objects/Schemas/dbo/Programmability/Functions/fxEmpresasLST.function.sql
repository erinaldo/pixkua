-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 30-DIC-2005
-- Description:	Listado de empresas utilizado para realizar búsquedas.
-- =============================================

CREATE  FUNCTION [dbo].[fxEmpresasLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT IdEmpresa, Nombre, Codigo, NombreLargo AS [Nombre Largo] FROM dbo.Empresas)


