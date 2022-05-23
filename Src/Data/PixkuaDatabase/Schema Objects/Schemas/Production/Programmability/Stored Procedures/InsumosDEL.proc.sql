-- =============================================
-- Author: alez lopez
-- Create date: 04-mar-2011
-- Description:	Elimina el Insumos especificado.
-- =============================================
CREATE PROCEDURE [Production].[InsumosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Production.Insumos SET IdStatus=0 WHERE IdInsumo=@ID


