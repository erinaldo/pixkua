CREATE FUNCTION [dbo].[fxCompareNameSdx](@Nombre1 AS varchar(128), @Nombre2 AS varchar(128))
RETURNS Bit
AS
BEGIN
	DECLARE @Result AS bit

	-- Separar palabras del nombre1
	declare @spaceIndex as int 
	declare @firstWord1 as varchar(128)
	declare @secondWord1 as varchar(128)
	set @spaceIndex=charindex(' ', @Nombre1)

	if @spaceIndex > 0
	begin
		set @firstWord1=substring(@Nombre1, 1, @spaceIndex)
		set @secondWord1=substring(@Nombre1, @spaceIndex+1,len(@Nombre1)) 
	end
	else
	begin
		set @firstWord1=@Nombre1
		set @secondWord1=''
	end

	-- Separar palabras del nombre2
	declare @firstWord2 as varchar(128)
	declare @secondWord2 as varchar(128)
	set @spaceIndex=charindex(' ', @Nombre2)

	if @spaceIndex > 0
	begin
		set @firstWord2=substring(@Nombre2, 1, @spaceIndex)
		set @secondWord2=substring(@Nombre2, @spaceIndex+1, len(@Nombre2)) 
	end
	else
	begin
		set @firstWord2=@Nombre2
		set @secondWord2=''
	end

	if soundex(LTrim(@firstWord1))=soundex(LTrim(@firstWord2))
			AND  soundex(LTrim(@secondWord1))=soundex(LTrim(@secondWord2))
		Set @Result=1
	else
		Set @Result=0
	
	Return @Result
END


