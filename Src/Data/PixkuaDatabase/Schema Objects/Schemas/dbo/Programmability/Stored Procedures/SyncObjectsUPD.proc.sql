CREATE PROCEDURE [dbo].[SyncObjectsUPD]
	@Object as varchar(64),
	@LastUpdate as datetime
AS
	IF EXISTS(SELECT [Object] FROM dbo.SyncObjects WHERE [Object]=@Object)
		UPDATE dbo.SyncObjects SET LastUpdate=@LastUpdate
		WHERE [Object]=@Object
	ELSE
		INSERT INTO dbo.SyncObjects([Object], LastUpdate)
		VALUES (@Object, @LastUpdate)


