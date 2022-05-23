CREATE FUNCTION [Inventory].[fxClasificacionConceptosSEL](@IdClasificacion as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdConcepto, Codigo, Nombre, Automatico, DiasVigencia, IdStatus,
			CASE Tipo
				WHEN 'E' THEN 'Entrada'
				WHEN 'S' THEN 'Salida'
				WHEN 'T' THEN 'Traspaso'
			END AS Tipo,
			CASE IdStatus
				WHEN 1 THEN 'Activo'
				WHEN 0 THEN 'Inactivo'
			END AS Estatus
	FROM Inventory.Conceptos
	WHERE IdConceptoClasificacion=@IdClasificacion
		)


