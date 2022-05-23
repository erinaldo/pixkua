-- =============================================
-- Author: alex Lopez
-- Create date: 10-ene-2011
-- Description:	Elimina el SegmentosNegocio especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[SegmentosNegocioDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Accounting.SegmentosNegocio SET IdStatus=0 WHERE IdSegmentoNegocio=@ID


