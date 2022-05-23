CREATE FUNCTION [dbo].[fxDateToNumberDay](@Fecha AS DateTime)
RETURNS INT
BEGIN
	DECLARE @FechaCount as DateTime 
	DECLARE @Count as Int	
	SET @FechaCount = @Fecha
	SET @Count = 0
	
	SET @FechaCount = Cast('01-' + '01-' + str(year(@Fecha)) as dateTime)
	SET @Count = datediff(dd,@FechaCount,@Fecha)+1
		   	
	RETURN @Count	
END


