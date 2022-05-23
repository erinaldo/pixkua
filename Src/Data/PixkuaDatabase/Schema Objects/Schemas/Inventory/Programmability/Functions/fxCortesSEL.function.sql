CREATE FUNCTION [Inventory].[fxCortesSEL](@IdSucursal as int, @IdUsuario as int)
RETURNS TABLE
AS
RETURN	(
	SELECT A.IdArea, A.Nombre AS Area, C.FechaApertura, C.HoraApertura, 
		A.IdCorteActual, C.IdTurno, T.Nombre AS Turno,
		CASE A.IdCorteActual
			WHEN dbo.fxEmptyId() THEN 0
			ELSE 1
		END AS IdStatus,
		CASE A.IdCorteActual
			WHEN dbo.fxEmptyId() THEN 'Cerrado'
			ELSE 'Abierto'
		END AS Estatus
	FROM Inventory.Areas A LEFT JOIN Inventory.Cortes C
		ON A.IdCorteActual=C.IdCorte
	LEFT JOIN Inventory.Turnos T
		ON C.IdTurno=T.IdTurno
	JOIN Inventory.AreasUsuarios AU	
		ON AU.IdArea=A.IdArea
	WHERE AU.IdUsuario=@IdUsuario AND A.IdSucursal=@IdSucursal
		)


