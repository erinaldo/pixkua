CREATE PROCEDURE [Purchasing].[PeriodosAbrir]
	@IdPeriodo AS int out
AS
		UPDATE Purchasing.Periodos SET Estatus='A'
		WHERE IdPeriodo=@IdPeriodo


