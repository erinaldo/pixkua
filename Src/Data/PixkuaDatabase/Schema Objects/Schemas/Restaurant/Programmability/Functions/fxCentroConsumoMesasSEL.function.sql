CREATE FUNCTION [Restaurant].[fxCentroConsumoMesasSEL](@IdCentroConsumo as int)
RETURNS TABLE
AS
	RETURN( SELECT M.IdMesa, M.Descripcion AS Mesa
			FROM Restaurant.Mesas M
			WHERE M.IdCentroConsumo=@IdCentroConsumo
	)


