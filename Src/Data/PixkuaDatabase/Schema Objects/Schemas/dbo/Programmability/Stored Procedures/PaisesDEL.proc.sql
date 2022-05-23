-- =============================================
-- Author: RCO
-- Create date: 20-sep-2010
-- Description:	Elimina el Paises especificado.
-- =============================================
CREATE PROCEDURE [dbo].[PaisesDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.Paises WHERE IdPais=@ID


