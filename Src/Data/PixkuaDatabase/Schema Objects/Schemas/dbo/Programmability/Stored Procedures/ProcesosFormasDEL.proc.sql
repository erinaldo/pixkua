-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 26-Mar-2006
-- Description:	Elimina la forma especificada1.
-- =============================================
CREATE PROCEDURE [dbo].[ProcesosFormasDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.ProcesosFormas WHERE IdProcesoForma=@ID


