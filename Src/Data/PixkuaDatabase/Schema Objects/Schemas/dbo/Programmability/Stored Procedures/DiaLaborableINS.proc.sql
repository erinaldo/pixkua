CREATE PROCEDURE [dbo].[DiaLaborableINS]
	@IdCalendario AS int,
	@Fecha as datetime
AS
	UPDATE dbo.Fechas SET Habil=1, LastUpdate=getdate() 
	WHERE IdCalendario=@IdCalendario AND Fecha=@Fecha


