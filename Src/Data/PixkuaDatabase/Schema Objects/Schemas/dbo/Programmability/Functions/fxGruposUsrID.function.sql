CREATE FUNCTION [dbo].[fxGruposUsrID](@Codigo AS varchar(10),@IdSucursal as int)
RETURNS int
AS
BEGIN 
	DECLARE @Id AS int
	
	SELECT @Id=IdGrupo
	FROM GruposUsr
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)

END


