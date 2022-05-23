create function [dbo].[fxValidaDspl](@ValorEsperado as int, @ValorRecibido as int, @ValorDesplegar as decimal(19,4))
returns decimal(19, 4)
begin
	declare @Ret as decimal(19, 4)
	if @ValorEsperado = @ValorRecibido
	begin
		set @Ret = @ValorDesplegar
	end
	else
	begin
		set @Ret = 0
	end

	RETURN @Ret
end


