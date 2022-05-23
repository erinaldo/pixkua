-- =============================================
-- Author: alez Lopez
-- Create date: 13-sep-2011
-- Description:	Elimina el EjerciciosFiscalesDet especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[EjerciciosFiscalesDetDEL]
	@Id AS char(18)
AS
	SET NOCOUNT ON
	
	DELETE Accounting.EjerciciosFiscalesDet 
	WHERE IdEjercicioFiscalTit=@Id  and Fecha=Documents.fxDocumentDate(@Id)


