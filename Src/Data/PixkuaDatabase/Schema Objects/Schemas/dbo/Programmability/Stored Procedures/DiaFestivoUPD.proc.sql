CREATE PROCEDURE [dbo].[DiaFestivoUPD]
	@IdCalendario as int,
	@Fecha AS datetime,
	@Descr as varchar(32)
AS
	UPDATE dbo.Fechas SET Festivo=1, Habil=0, Descr=@Descr, LastUpdate=getdate()
	WHERE Fecha=@Fecha AND IdCalendario=@IdCalendario


