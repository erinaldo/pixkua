-- =============================================
-- Author: RCO
-- Create date: 04-abr-2011
-- Description:	Obtiene la información del NotasConceptos especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxNotasConceptosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Accounting.NotasConceptos WHERE IdNotaConcepto=@ID)


