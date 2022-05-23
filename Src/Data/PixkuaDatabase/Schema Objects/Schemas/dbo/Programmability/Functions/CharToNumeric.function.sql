CREATE FUNCTION [dbo].[CharToNumeric](@Cadena as varchar(256))
RETURNS int/*Decimal(19,0)*/
BEGIN

	DECLARE @CadenaTmp as varchar(256)
	DECLARE @Cont as int

	SELECT @Cont=0,@CadenaTmp=''
	WHILE @Cont<= len(@Cadena)	
	BEGIN

		IF IsNumeric(SUBSTRING(@Cadena,@Cont,1))<>0
			SELECT @CadenaTmp = @CadenaTmp + SUBSTRING(@Cadena,@Cont,1)
	
		SET @Cont=@Cont+1
	END

	RETURN abs(@CadenaTmp)
END


