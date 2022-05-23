CREATE FUNCTION [Inventory].[fxTurnosByAreaSEL](@IdArea as int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.IdTurno, T.Codigo, T.Nombre, HoraInicial, HoraFinal
	FROM Inventory.Turnos T JOIN Inventory.TurnosAreas TA
		ON T.IdTurno=TA.IdTurno
	WHERE TA.IdArea=@IdArea AND T.IdStatus=1
		)


