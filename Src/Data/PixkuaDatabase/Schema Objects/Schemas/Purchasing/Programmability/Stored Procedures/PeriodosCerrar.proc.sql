CREATE PROCEDURE [Purchasing].[PeriodosCerrar]
	@IdPeriodo AS int out
AS
		UPDATE Purchasing.Periodos SET Estatus='C',FechaCierre=GETDATE()
		WHERE IdPeriodo=@IdPeriodo


