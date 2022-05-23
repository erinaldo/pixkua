CREATE FUNCTION [dbo].[fxParamGetSection](@Path as VarChar(256))
RETURNS Table
AS 
RETURN(	SELECT [Key],Value 
		FROM  Configuracion
		WHERE Path = @Path
)


