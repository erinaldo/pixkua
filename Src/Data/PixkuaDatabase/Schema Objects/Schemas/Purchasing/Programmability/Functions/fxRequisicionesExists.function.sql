-- =============================================
-- Author: alex lopez
-- Create date: 07-nov-2011
-- Description:	Verifica la existencia de Requisiciones
-- =============================================
CREATE FUNCTION [Purchasing].[fxRequisicionesExists](@ID AS char(18))
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdRequisicion FROM Purchasing.Requisiciones WHERE IdRequisicion=@ID and Fecha=Documents.fxDocumentDate(@Id))
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


