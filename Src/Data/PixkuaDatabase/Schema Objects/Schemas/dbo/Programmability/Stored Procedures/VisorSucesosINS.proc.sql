CREATE PROCEDURE [dbo].[VisorSucesosINS]
	@Error as varchar(1024), 
	@WorkStation as varchar(32)
AS
	SET NOCOUNT ON

	DECLARE @Fecha as datetime
	DECLARE @Hora as datetime

	SELECT @Hora= getdate()
	SET @Fecha=CONVERT(varchar(8),@Hora,112)
	
	INSERT INTO VisorSucesos(Fecha,Hora,Error,WorkStation)
	VALUES(@Fecha,@Hora,@Error,@WorkStation)


