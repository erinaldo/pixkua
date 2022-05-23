-- =============================================
-- Author: RCO
-- Create date: 06-sep-2010
-- Description:	Obtiene la información del CFDAddendas especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxCFDAddendasSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Accounting.CFDAddendas WHERE IdCFDAddenda=@ID)


