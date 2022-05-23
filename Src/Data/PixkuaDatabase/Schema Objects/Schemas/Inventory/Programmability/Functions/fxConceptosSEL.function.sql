-- =============================================
-- Author: RCO
-- Create date: 13-oct-2010
-- Description:	Obtiene la información del Conceptos especificado.
-- =============================================
CREATE FUNCTION [Inventory].[fxConceptosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Inventory.Conceptos WHERE IdConcepto=@ID)


