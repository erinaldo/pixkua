-- =============================================
-- Author: RCO
-- Create date: 06-sep-2010
-- Description:	Obtiene la información del VentasTit especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxVentasTitSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.*, D.Nombre AS Divisa, S.StatusApplied as [Status]
	FROM Sales.VentasTit  AS T INNER JOIN Documents.[Status] AS S
		ON S.IdStatus=T.IdStatus
	JOIN Accounting.Divisas D
		ON T.IdDivisa=D.IdDivisa
	WHERE IdVentaTit=@ID and Fecha = Documents.fxDocumentDate(@Id)
		)


