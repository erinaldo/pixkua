CREATE FUNCTION [Treasury].[fxDiaPagoSiguiente](@Fecha as Datetime)
RETURNS DATETIME
AS
BEGIN
	DECLARE @DiaPago as Int,@DiaReturn AS DateTime

	SELECT @DiaPago=CAST( dbo.fxParamGetValue('Configuracion/Tesoreria','DiaPago') AS INT),@DiaReturn=@Fecha

	IF @DiaPago>0
	BEGIN
		WHILE @DiaPago <> DATEPART(DW,@DiaReturn)
		BEGIN
			SET @DiaReturn=DATEADD(DAY,1,@DiaReturn)
		END
	END

	RETURN @DiaReturn
END


