CREATE FUNCTION [dbo].[fxBusinessDateAdd](@IdCalendario as int, @Fecha as datetime, @Dias as int)
RETURNS Datetime
AS
BEGIN
	DECLARE @Result AS datetime, @Habil as bit, @Cont as int
	-->Inicializar variables
	SELECT @Cont=@Dias, @Habil=0, @Result=dateadd(dd, @Dias, @Fecha)
	-->Verificar si la fecha resultante es un día hábil
	SELECT @Habil=Habil FROM dbo.Fechas WITH (READUNCOMMITTED) WHERE Fecha=@Result AND IdCalendario=@IdCalendario
	-->Incrementar contador de días hasta que se obtenga una fecha con día hábil
	WHILE @Habil=0
	BEGIN
		IF @Dias >= 0
			SET @Cont=@Cont + 1
		ELSE
			SET @Cont=@Cont - 1

		SET @Result=dateadd(dd, @Cont, @Fecha)
		SELECT @Habil=Habil FROM dbo.Fechas WITH (READUNCOMMITTED) WHERE Fecha=@Result AND IdCalendario=@IdCalendario
	END
	RETURN @Result
END


