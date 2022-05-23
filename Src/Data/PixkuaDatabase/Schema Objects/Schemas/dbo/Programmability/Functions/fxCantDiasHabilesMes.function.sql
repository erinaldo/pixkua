CREATE FUNCTION [dbo].[fxCantDiasHabilesMes](@IdCalendario as int, @Fecha as datetime)
RETURNS int
AS
BEGIN
	DECLARE @Result as int

	SELECT @Result=Count(*)
	FROM dbo.Fechas
	WHERE Mes=datepart(month, @Fecha) AND Anio=datepart(year, @Fecha)
		AND IdCalendario=@IdCalendario AND Fecha <= @Fecha
		AND Habil=1 AND DiaSemana > 1 AND Festivo=0
	
	RETURN @Result
END


