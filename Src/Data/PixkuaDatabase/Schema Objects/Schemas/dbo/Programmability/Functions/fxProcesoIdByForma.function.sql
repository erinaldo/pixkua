CREATE FUNCTION [dbo].[fxProcesoIdByForma](@Ensamblado as varchar(32), @Namespace as varchar(128), @Clase as varchar(128))
RETURNS int
AS
BEGIN
	DECLARE @Result as int
	
	SELECT @Result=IdProceso
	FROM dbo.ProcesosFormas
	WHERE Ensamblado=@Ensamblado AND [NameSpace]=@Namespace AND Clase=@Clase
	
	RETURN IsNull(@Result, 0)
END


