-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 30-Dic-2005
-- Description:	Elimina el módulo especificado.
-- =============================================
CREATE PROCEDURE [dbo].[ModulosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.Modulos WHERE IdModulo=@ID


