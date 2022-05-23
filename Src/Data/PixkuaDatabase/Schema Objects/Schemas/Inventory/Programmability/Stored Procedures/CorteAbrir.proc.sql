CREATE PROCEDURE [Inventory].[CorteAbrir]	
	@IdArea as int,
	@IdTurno AS int,	
	@IdUsuario AS int	
AS
	SET NOCOUNT ON
	
	DECLARE @FechaApertura as datetime, @HoraApertura as datetime,
		@IdCorte as uniqueidentifier
	
	SELECT @FechaApertura=CONVERT(varchar(10), GETDATE(), 112), @HoraApertura=GETDATE(),
		@IdCorte=NEWID()
	
	INSERT INTO Inventory.Cortes (IdCorte, IdArea, IdTurno, FechaApertura, HoraApertura, IdUsuarioApertura)
	VALUES (@IdCorte, @IdArea, @IdTurno, @FechaApertura, @HoraApertura, @IdUsuario)
	
	UPDATE Inventory.Areas SET IdCorteActual=@IdCorte
	WHERE IdArea=@IdArea


