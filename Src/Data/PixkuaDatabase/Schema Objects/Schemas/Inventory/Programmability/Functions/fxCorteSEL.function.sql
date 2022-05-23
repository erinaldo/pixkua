CREATE FUNCTION [Inventory].[fxCorteSEL](@IdCorte as uniqueidentifier)
RETURNS TABLE
AS
RETURN	(
	SELECT C.IdArea, C.IdTurno, C.FechaApertura, C.HoraApertura, C.FechaCierre, C.HoraCierre, 
		C.IdUsuarioApertura, C.IdUsuarioCierre, A.Nombre AS Area, T.Nombre AS Turno
	FROM Inventory.Cortes C JOIN Inventory.Areas A
		ON C.IdArea=A.IdArea
	JOIN Inventory.Turnos T
		ON T.IdTurno=C.IdTurno
	WHERE C.IdCorte=@IdCorte
		)


