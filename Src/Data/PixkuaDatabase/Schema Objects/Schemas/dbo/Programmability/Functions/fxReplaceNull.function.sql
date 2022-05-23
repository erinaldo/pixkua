/*** Recibe un valor en @Valor, regresará siempre el @Default, y en caso de que @Valor sea Null regresa @SiNull*/
CREATE function [dbo].[fxReplaceNull] (@Valor as varchar, @Default as Varchar(50), @SiNull as Varchar(50))
returns VarChar (50)
begin
	declare @Ret as VarChar (50)
	set @Ret = @Default
	if @Valor is null set @Ret =  @SINull
	Return @Ret
end


