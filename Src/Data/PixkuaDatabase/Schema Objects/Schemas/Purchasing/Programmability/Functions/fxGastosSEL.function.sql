-- =============================================
-- Author: alex Lopez
-- Create date: 23-nov-2011
-- Description:	Obtiene la información del Gastos especificado.
-- =============================================
CREATE FUNCTION [Purchasing].[fxGastosSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.*, S.[Status] as [Status],CP.Nombre AS CategoriaPresupuestal
	FROM Purchasing.Gastos  AS T 
	INNER JOIN Documents.[Status] AS S ON S.IdStatus=T.IdStatus
	LEFT JOIN Purchasing.CategoriasPresupuestales CP ON CP.IdCategoriaPresupuestal=T.IdCategoriaPresupuestal
	WHERE IdGasto=@ID and Fecha = Documents.fxDocumentDate(@Id)
		)


