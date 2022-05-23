-- =============================================
-- Author: alez Lopez
-- Create date: 11-feb-2011
-- Description:	Obtiene una lista de búsqueda de ComandaTit
-- =============================================
CREATE FUNCTION [Restaurant].[fxComandaTitLST](@IdUsuario AS char(18), @IdSucursal AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.IdComandaTit, T.Fecha, S.[Status] AS Estatus
	FROM Restaurant.ComandaTit T JOIN Documents.[Status] S
		ON T.IdStatus=S.IdStatus
	WHERE T.IdSucursal=@IdSucursal
		)


