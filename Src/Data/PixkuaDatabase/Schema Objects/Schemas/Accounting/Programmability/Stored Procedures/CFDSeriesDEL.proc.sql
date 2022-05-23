-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Elimina el CFDSeries especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[CFDSeriesDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Accounting.CFDSeries WHERE IdCFDSerie=@ID


