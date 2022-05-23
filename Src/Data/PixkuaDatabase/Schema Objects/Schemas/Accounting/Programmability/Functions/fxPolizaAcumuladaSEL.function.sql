CREATE FUNCTION [Accounting].[fxPolizaAcumuladaSEL](@IdPolizaPerfil int, @FechaTrabajo datetime, @IdSucursal int)
RETURNS varchar(18)
AS
BEGIN
	DECLARE @IdPolizaTit as varchar(18)
	SET @IdPolizaTit = ''
	
	SELECT @IdPolizaTit =IdPolizaTit
	FROM Accounting.PolizasAcumuladas
	WHERE IdPolizaPerfil=@IdPolizaPerfil AND Fecha=@FechaTrabajo AND IdSucursal=@IdSucursal
	
	SET @IdPolizaTit=ISNULL(@IdPolizaTit,'')

	RETURN @IdPolizaTit
END


