-- =============================================
-- Author: RCO
-- Create date: 02-nov-2010
-- Description:	Elimina el Operadores especificado.
-- =============================================
CREATE PROCEDURE [dbo].[OperadoresDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.Operadores WHERE IdOperador=@ID


