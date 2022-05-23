-- =============================================
-- Author: alex Lopez
-- Create date: 30-nov-2011
-- Description:	Elimina el Cajas especificado.
-- =============================================
CREATE PROCEDURE [Treasury].[CajasDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Treasury.Cajas SET IdStatus=0 WHERE IdCaja=@ID


