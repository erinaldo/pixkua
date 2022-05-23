-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 31-Dic-2005
-- Description:	Elimina el Proceso especificado.
-- =============================================
CREATE PROCEDURE [dbo].[ProcesosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.Procesos WHERE IdProceso=@ID


