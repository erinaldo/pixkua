CREATE FUNCTION [dbo].[fxEstadosCBO](@IdPais as int)
RETURNS TABLE
AS
	RETURN
	(
		SELECT IdEstado, Estado
		FROM dbo.Estados
		WHERE IdStatus=1 AND IdPais=@IdPais
	)


