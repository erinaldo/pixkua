CREATE FUNCTION [dbo].[fxParallelBusinessDate](@IdCalendario as int, @Fecha as datetime)
RETURNS @RetTable TABLE (Fecha datetime)
AS
BEGIN
	/*OBTIENE LA FECHA DE NEGOCIOS CORRESPONDIENTE AL AÑO ANTERIOR*/
	DECLARE @Result as datetime, @AnioAnt as int, @DiaHabil as int

	--Obtener año anterior
	SET @AnioAnt=datepart(year, @Fecha) - 1
	--Obtener Dia habil del mes
	SELECT @DiaHabil=DiaHabilMes FROM Fechas WHERE Fecha=@Fecha AND IdCalendario=@IdCalendario
	--Obtener la fecha correspondiente al año anterior
	SELECT @Result=Fecha FROM Fechas 
	WHERE Anio=@AnioAnt AND Mes=datepart(month, @Fecha) AND DiaHabilMes=@DiaHabil
		AND IdCalendario=@IdCalendario

	--Si no se encontró fecha, intentar con un día antes
	IF @Result IS NULL
		SELECT @Result=Fecha FROM Fechas 
		WHERE Anio=@AnioAnt AND Mes=datepart(month, @Fecha) AND DiaHabilMes=@DiaHabil - 1
			AND IdCalendario=@IdCalendario

	INSERT INTO @RetTable (Fecha)
	SELECT Fecha FROM dbo.fxBusinessDateComponents(@IdCalendario, @Result)
		
	RETURN
END


