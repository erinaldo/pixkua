-- =============================================
-- Author: alez Lopez
-- Create date: 11-feb-2011
-- Description:	Elimina el ComandaDet especificado.
-- =============================================
CREATE PROCEDURE [Restaurant].[ComandaDetDEL]
	@Id AS char(18),
	@IdArticulo as int	
AS
	SET NOCOUNT ON
	
	DELETE Restaurant.ComandaDet 
	WHERE IdComandaTit=@Id and Fecha=Documents.fxDocumentDate(@Id) AND IdArticulo=@IdArticulo


