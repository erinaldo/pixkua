CREATE FUNCTION [Inventory].[fxTurnosCBO]()
RETURNS TABLE
AS
RETURN	(
	SELECT T.IdTurno, T.Codigo, T.Nombre
	FROM Inventory.Turnos T 
	WHERE T.IdStatus=1
		)


