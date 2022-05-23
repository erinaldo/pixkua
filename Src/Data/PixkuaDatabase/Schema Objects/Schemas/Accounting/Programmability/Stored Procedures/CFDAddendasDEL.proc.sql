-- =============================================
-- Author: RCO
-- Create date: 06-sep-2010
-- Description:	Elimina el CFDAddendas especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[CFDAddendasDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Accounting.CFDAddendas WHERE IdCFDAddenda=@ID


