CREATE FUNCTION [Treasury].[fxCajasCBO](@IdUsuario as int)
RETURNS TABLE
AS
	RETURN(	SELECT C.IdCaja,C.Nombre
			FROM Treasury.Cajas C
			INNER JOIN Treasury.CajasAccesos A ON A.IdCaja=C.IdCaja
			WHERE A.IdUsuario=@IdUsuario AND C.IdStatus=1
)


