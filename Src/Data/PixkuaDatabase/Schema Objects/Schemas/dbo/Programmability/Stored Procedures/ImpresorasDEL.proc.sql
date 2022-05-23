-- =============================================
-- Author: RCO
-- Create date: 30-jun-2011
-- Description:	Elimina el Impresoras especificado.
-- =============================================
CREATE PROCEDURE [dbo].[ImpresorasDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.Impresoras WHERE IdImpresora=@ID


