CREATE PROCEDURE [dbo].[EventLogINS]
	@Date as datetime,
	@Time as datetime,
	@Message as text,
	@Type as int,
	@Source as varchar(64),
	@WorkStation as varchar(32)
AS
	SET NOCOUNT ON
	
	INSERT INTO dbo.EventLog([Date], [Time], [Message], [Type], [Source], WorkStation)
	VALUES (@Date, @Time, @Message, @Type, @Source, @WorkStation)


