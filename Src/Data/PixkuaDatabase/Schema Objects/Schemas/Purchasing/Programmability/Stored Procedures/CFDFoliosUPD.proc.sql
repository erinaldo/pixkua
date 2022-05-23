CREATE PROCEDURE [Purchasing].[CFDFoliosUPD]
	@RFC as char(13),
	@NumAprobacion as int,
	@AnioAprobacion as int,
	@Serie as char(10),
	@FolioInicial as int,
	@FolioFinal as int,
	@FechaTransaccion as datetime
AS
	SET NOCOUNT ON
	
	IF NOT EXISTS (SELECT RFC FROM Purchasing.CFDFolios WHERE RFC=@RFC AND NumAprobacion=@NumAprobacion and AnioAprobacion=@AnioAprobacion and Serie=@Serie and FolioInicial=@FolioInicial and FolioFinal=@FolioFinal)
		INSERT INTO Purchasing.CFDFolios (RFC, NumAprobacion, AnioAprobacion, Serie, FolioInicial, FolioFinal, FechaTransaccion)
		VALUES (@RFC, @NumAprobacion, @AnioAprobacion, @Serie, @FolioInicial, @FolioFinal, @FechaTransaccion)


