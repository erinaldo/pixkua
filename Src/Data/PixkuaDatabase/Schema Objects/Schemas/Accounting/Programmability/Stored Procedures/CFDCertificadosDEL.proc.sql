-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Elimina el CFDCertificados especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[CFDCertificadosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Accounting.CFDCertificados WHERE IdCFDCertificado=@ID


