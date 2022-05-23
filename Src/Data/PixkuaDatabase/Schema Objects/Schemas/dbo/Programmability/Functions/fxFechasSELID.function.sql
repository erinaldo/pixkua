CREATE FUNCTION [dbo].[fxFechasSELID](@IdFecha AS int)
RETURNS TABLE
AS
RETURN
	(SELECT * FROM Fechas WHERE IdFecha=@IdFecha)


