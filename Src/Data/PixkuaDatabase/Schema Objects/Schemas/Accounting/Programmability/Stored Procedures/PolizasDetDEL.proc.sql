-- =============================================
-- Author: alex Lopez
-- Create date: 08-nov-2010
-- Description:	Elimina el PolizasDet especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[PolizasDetDEL]
	@IdPolizaTit AS char(18)
AS
	SET NOCOUNT ON
	
	DELETE Accounting.PolizasDet 
	WHERE IdPolizaTit=@IdPolizaTit  and Fecha=Documents.fxDocumentDate(@IdPolizaTit)


