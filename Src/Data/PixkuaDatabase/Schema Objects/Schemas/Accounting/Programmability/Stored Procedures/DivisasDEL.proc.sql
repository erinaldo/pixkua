-- =============================================
-- Author: RCO
-- Create date: 10-sep-2010
-- Description:	Elimina el Divisas especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[DivisasDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Accounting.Divisas WHERE IdDivisa=@ID


