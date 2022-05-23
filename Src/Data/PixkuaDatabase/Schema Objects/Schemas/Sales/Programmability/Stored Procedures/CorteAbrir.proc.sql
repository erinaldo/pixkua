CREATE PROCEDURE [Sales].[CorteAbrir]
	@IdCaja as int,
	@IdCajero as int,
	@IdTurno as int
AS
	SET NOCOUNT ON
	SET xact_abort ON

	DECLARE @ErrorMessage nvarchar(4000),
			@FechaApertura as datetime, @HoraApertura as datetime,
		    @IdCorte as uniqueidentifier

		SELECT  @FechaApertura=CONVERT(varchar(10), GETDATE(), 112), @HoraApertura=GETDATE(),
		 	    @IdCorte=NEWID()
	
		INSERT INTO Sales.Cortes(IdCorte, IdCaja, IdTurno, FechaApertura, HoraApertura, IdCajero, IdStatus)
		VALUES(@IdCorte, @IdCaja, @IdTurno, @FechaApertura, @HoraApertura, @IdCajero, 0)
		
		UPDATE Sales.Cajas SET IdCorteActual=@IdCorte WHERE IdCaja=@IdCaja


