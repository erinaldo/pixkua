CREATE FUNCTION [dbo].[fxFechaIsHoliday](@IdCalendario as bit, @Fecha AS datetime)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	SELECT @Result=Festivo
	FROM dbo.Fechas WHERE Fecha=@Fecha AND IdCalendario=@IdCalendario

	RETURN @Result
END


