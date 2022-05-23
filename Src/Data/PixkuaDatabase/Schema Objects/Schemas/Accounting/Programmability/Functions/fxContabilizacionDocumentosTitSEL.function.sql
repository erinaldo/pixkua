-- =============================================
-- Author: alexLopez
-- Create date: 15-oct-2010
-- Description:	Obtiene la información del ContabilizacionDocumentosTit especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxContabilizacionDocumentosTitSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Accounting.ContabilizacionDocumentosTit WHERE IdContabilizacionDocumentoTit=@ID)


