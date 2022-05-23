-- =============================================
-- Author: RCO
-- Create date: 09-sep-2010
-- Description:	Elimina el Impuestos especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[ImpuestosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Accounting.Impuestos WHERE IdImpuesto=@ID


