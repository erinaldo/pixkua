CREATE FUNCTION [dbo].[fxCountCharactersIN](@Caracter AS varchar(1), @Cadena as varchar(1024))
RETURNS int
BEGIN
	DECLARE @Pos as int,@Count as int
	SELECT @Pos =0,@Count=0
	SELECT @Pos=PATINDEX(@Caracter,@Cadena)

	WHILE @Pos<>0
	BEGIN
		SET @Count=@Count+1
		SET @Pos=PATINDEX(@Caracter,Substring( @Cadena,@Pos, LEN(@Cadena)-@Pos ))
	END
	
	RETURN @Count
END


