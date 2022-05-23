CREATE PROCEDURE [dbo].[DiaLaborableDEL]
	@IdCalendario AS int,
	@Fecha as datetime
AS
	UPDATE dbo.Fechas SET Habil=0, DiaHabilAnio=0, DiaHabilMes=0, DiaHabilSemana=0, LastUpdate=getdate()
	WHERE IdCalendario=@IdCalendario AND Fecha=@Fecha


