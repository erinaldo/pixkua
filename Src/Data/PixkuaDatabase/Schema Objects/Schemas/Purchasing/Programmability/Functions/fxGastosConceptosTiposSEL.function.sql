-- =============================================
-- Author: alex Lopez
-- Create date: 15-nov-2011
-- Description:	Obtiene la información del GastosConceptosTipos especificado.
-- =============================================
CREATE FUNCTION [Purchasing].[fxGastosConceptosTiposSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Purchasing.GastosConceptosTipos WHERE IdGastoConceptoTipo=@ID)


