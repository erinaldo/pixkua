-- =============================================
-- Author: RCO
-- Create date: 09-sep-2010
-- Description:	Obtiene la información del Impuestos especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxImpuestosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Accounting.Impuestos WHERE IdImpuesto=@ID)


