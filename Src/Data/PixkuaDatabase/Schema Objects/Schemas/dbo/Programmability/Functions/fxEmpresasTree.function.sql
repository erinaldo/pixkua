-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 01-Jun-2006
-- Description:	Obtiene la lista de empresas
-- =============================================
CREATE FUNCTION [dbo].[fxEmpresasTree]()
RETURNS TABLE
AS
RETURN (
	SELECT IdEmpresa, Codigo, Nombre
	FROM Empresas
	WHERE IdStatus=1
		)


