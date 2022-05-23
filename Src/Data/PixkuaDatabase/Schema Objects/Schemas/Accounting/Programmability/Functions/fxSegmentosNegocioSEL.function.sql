-- =============================================
-- Author: alex Lopez
-- Create date: 10-ene-2011
-- Description:	Obtiene la información del SegmentosNegocio especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxSegmentosNegocioSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Accounting.SegmentosNegocio WHERE IdSegmentoNegocio=@ID)


