CREATE PROCEDURE [dbo].[DiaFestivoDEL]
	@IdCalendario as int,
	@Fecha as datetime
AS
	UPDATE dbo.Fechas SET Festivo=0, Habil=1, Descr='', LastUpdate=getdate()
	WHERE Fecha=@Fecha AND IdCalendario=@IdCalendario


