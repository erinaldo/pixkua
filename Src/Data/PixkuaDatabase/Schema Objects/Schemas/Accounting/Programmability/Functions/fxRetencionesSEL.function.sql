-- =============================================
-- Author: alex Lopez
-- Create date: 24-nov-2011
-- Description:	Obtiene la información del Retenciones especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxRetencionesSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Accounting.Retenciones WHERE IdRetencion=@ID)


