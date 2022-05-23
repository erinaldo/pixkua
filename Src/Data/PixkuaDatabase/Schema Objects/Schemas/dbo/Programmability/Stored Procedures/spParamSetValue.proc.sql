CREATE PROCEDURE [dbo].[spParamSetValue]
@Path as VarChar(256),
@Key as VarChar(64),
@Value as VarChar(256)
AS
	UPDATE Configuracion SET [Value] = @Value WHERE [Path]=@Path AND [Key]=@Key


