CREATE FUNCTION [dbo].[fxCountCharacterIN](@Caracter AS CHAR(1), @Cadena as varchar(1024))
RETURNS int
BEGIN
	DECLARE @Pos as int,@Count as int
	SELECT @Pos=1,@Count=0

	WHILE @Pos<=LEN(@Cadena)
	BEGIN
		IF SUBSTRING (@Cadena,@Pos,1)=@Caracter
		   SET @Count=@Count+1

		SET  @Pos=@Pos+1  				
	END
	
	RETURN @Count
END


