CREATE PROCEDURE [Accounting].[CFDCancel]
	@IdCFDSerie as int,
	@Folio as int
AS
	SET NOCOUNT ON
	
	DECLARE @Activa as bit
	-->Verificar el estatus de la factura
	SELECT @Activa=Activa
	FROM Accounting.CFD
	WHERE IdCFDSerie=@IdCFDSerie and Folio=@Folio
	
	IF @Activa=1
		UPDATE Accounting.CFD SET Activa=0, FechaCancelacion=getdate()  
		WHERE IdCFDSerie=@IdCFDSerie AND Folio=@Folio


