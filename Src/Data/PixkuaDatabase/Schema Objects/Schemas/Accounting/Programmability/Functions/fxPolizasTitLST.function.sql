-- =============================================
-- Author: alex Lopez
-- Create date: 08-nov-2010
-- Description:	Obtiene una lista de búsqueda de PolizasTit
-- =============================================
CREATE FUNCTION [Accounting].[fxPolizasTitLST](@IdUsuario AS char(18), @IdSucursal AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.IdPolizaTit, T.Fecha, S.[Status] AS Estatus
	FROM Accounting.PolizasTit T JOIN Documents.[Status] S
		ON T.IdStatus=S.IdStatus
	WHERE T.IdSucursal=@IdSucursal
		)


