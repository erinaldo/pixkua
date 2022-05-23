CREATE FUNCTION [dbo].[fxConvertIDsDoctosToTable](@Indices AS VARCHAR(128))
RETURNS @rTable TABLE (IdReturn char(18))
BEGIN
	DECLARE @Count as int
	DECLARE @Number as VarChar(128)
	DECLARE @Length as int
	DECLARE @Start as int
	SET @Length=0
	SET @Start=1		
	SET @Count = 1
	SET @Number = ''
	
	WHILE @Count <=Len(@Indices)  
	BEGIN		
		IF SUBSTRING(@Indices,@Count,1) = ',' AND @Number <> ''
			BEGIN                
				INSERT INTO @rTable VALUES(CAST(@Number AS CHAR(18)))
				SET @Length=0
				SET @Start = @Count+1
				SET @Number=''
			END
		ELSE
			BEGIN                
				SET @Length=@Length+1
				SET @Number = SUBSTRING(@Indices,@Start,@Length)					
			END
		SET @Count = @Count + 1
    END 

	IF @Number <> ''
    BEGIN
		INSERT INTO @rTable VALUES(CAST(@Number AS CHAR(18)))
	END   
		
	RETURN  
END


