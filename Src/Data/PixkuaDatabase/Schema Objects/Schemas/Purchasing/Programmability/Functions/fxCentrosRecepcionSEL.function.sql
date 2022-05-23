-- =============================================
-- Author: alez lopez
-- Create date: 19-oct-2011
-- Description:	Obtiene la información del CentrosRecepcion especificado.
-- =============================================
CREATE FUNCTION [Purchasing].[fxCentrosRecepcionSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Purchasing.CentrosRecepcion WHERE IdCentroRecepcion=@ID)


