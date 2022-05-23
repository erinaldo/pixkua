-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 05-Ene-2006
-- Description:	Elimina la política de seguridad especificada.
-- =============================================
CREATE PROCEDURE [dbo].[PoliticasDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.Politicas WHERE IdPolitica=@ID


