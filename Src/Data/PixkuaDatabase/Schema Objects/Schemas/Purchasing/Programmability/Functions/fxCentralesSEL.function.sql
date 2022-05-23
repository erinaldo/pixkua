-- =============================================
-- Author: alez lopez
-- Create date: 19-oct-2011
-- Description:	Obtiene la información del Centrales especificado.
-- =============================================
CREATE FUNCTION [Purchasing].[fxCentralesSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Purchasing.Centrales WHERE IdCentral=@ID)


