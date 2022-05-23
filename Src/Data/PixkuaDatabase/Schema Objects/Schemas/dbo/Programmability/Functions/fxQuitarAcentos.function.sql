CREATE function [dbo].[fxQuitarAcentos](@Cadena as varchar(256))
returns varchar(256)
begin
	declare @Ret as varchar(256)
	set @Ret = @Cadena
	set @Ret = replace (@Ret COLLATE Modern_Spanish_CS_AS,'á','a')
	set @Ret = replace (@Ret COLLATE Modern_Spanish_CS_AS,'é','e')
	set @Ret = replace (@Ret COLLATE Modern_Spanish_CS_AS,'í','i')
	set @Ret = replace (@Ret COLLATE Modern_Spanish_CS_AS,'ó','o')
	set @Ret = replace (@Ret COLLATE Modern_Spanish_CS_AS,'ú','u')
	set @Ret = replace (@Ret COLLATE Modern_Spanish_CS_AS,'Á','A')
	set @Ret = replace (@Ret COLLATE Modern_Spanish_CS_AS,'É','E')
	set @Ret = replace (@Ret COLLATE Modern_Spanish_CS_AS,'Í','I')
	set @Ret = replace (@Ret COLLATE Modern_Spanish_CS_AS,'Ó','O')
	set @Ret = replace (@Ret COLLATE Modern_Spanish_CS_AS,'Ú','U')

--Provisionalmente qgregué esta linea para que elimine los "|" 
	set @Ret = replace (@Ret COLLATE Modern_Spanish_CS_AS,'|','')

	return @Ret
end


