CREATE FUNCTION [dbo].[fxParamGetValue](@Path as VarChar(256),@Key as VarChar(64))
RETURNS Varchar(256)
BEGIN 
	DECLARE @Value as VarChar(256)
	
	SELECT @Value=[Value] 
	FROM  dbo.Configuracion
	WHERE [Path] = @Path and [Key] = @Key
	
	IF @Value Is Null 
		SET @Value = ''

	RETURN @Value

END


