CREATE FUNCTION [dbo].[fxEmpresasCBO]()
RETURNS TABLE
AS
RETURN
(
	SELECT IdEmpresa, Nombre 
	FROM Empresas
	WHERE IdStatus=1
)


