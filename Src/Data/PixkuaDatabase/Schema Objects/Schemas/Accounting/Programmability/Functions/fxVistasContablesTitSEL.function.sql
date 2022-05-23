-- =============================================
-- Author: alez lopez
-- Create date: 17-oct-2010
-- Description:	Obtiene la información del VistasContablesTit especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxVistasContablesTitSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Accounting.VistasContablesTit WHERE IdVistaContableTit=@ID)


