CREATE PROCEDURE [Accounting].[CFDFoliosRegistrar]
	@IdCFDSerie as int,	
	@NumAprobacion as int,
	@AnioAprobacion as int,
	@FolioInicial as int,
	@FolioFinal as int,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON

	DECLARE @Fecha as datetime, @Hora as datetime
	SELECT @Fecha=Convert(varchar(10), getdate(), 112), @Hora=getdate()

	INSERT INTO Accounting.CFDFolios (IdCFDSerie, Fecha, Hora, NumAprobacion, AnioAprobacion,
		FolioInicial, FolioFinal, UserUpdate, PCUpdate)
	VALUES (@IdCFDSerie, @Fecha, @Hora, @NumAprobacion, @AnioAprobacion,
		@FolioInicial, @FolioFinal, @UserUpdate, @PCUpdate)

	UPDATE Accounting.CFDSeries SET FolioLimite=@FolioFinal WHERE IdCFDSerie=@IdCFDSerie


