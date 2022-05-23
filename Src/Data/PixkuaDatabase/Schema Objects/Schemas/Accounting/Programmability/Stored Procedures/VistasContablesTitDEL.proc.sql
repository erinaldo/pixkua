-- =============================================
-- Author: alez lopez
-- Create date: 17-oct-2010
-- Description:	Elimina el VistasContablesTit especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[VistasContablesTitDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE  Accounting.VistasContablesTit SET IdStatus=0 WHERE IdVistaContableTit=@ID


