CREATE function [dbo].[fxGetRelativo](@Dividendo as decimal(19,4), @Divisor as decimal(19,4))
RETURNS dec(19,4)
AS
BEGIN

	declare @dRet as dec(19,4)
	set @dRet = 0

	If @Divisor > 0 
	begin
		set @dRet = (@Dividendo /@Divisor) - 1.0
	end

	return @dRet
	
END


