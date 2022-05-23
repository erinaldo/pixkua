CREATE FUNCTION [Accounting].[fxEjerciciosFiscalesUltimo](@IdEmpresa as int)
RETURNS INT
AS
BEGIN
	DECLARE @Ultimo as int
	
	SELECT @Ultimo =Year(MAX(Fecha))
 	FROM Accounting.EjerciciosFiscalesTit
	WHERE IdEmpresa=@IdEmpresa

	SET @Ultimo=IsNull(@Ultimo,YEAR(GETDATE() )-1)
	
	RETURN @Ultimo
END


