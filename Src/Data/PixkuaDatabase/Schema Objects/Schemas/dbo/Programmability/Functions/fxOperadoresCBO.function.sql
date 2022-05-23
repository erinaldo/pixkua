CREATE FUNCTION [dbo].[fxOperadoresCBO](@IdEmpresa as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdOperador, Codigo, Nombre
	FROM dbo.Operadores
	WHERE IdStatus=1 AND IdEmpresa=@IdEmpresa
		)


