-- =============================================
-- Author: alez Lopez
-- Create date: 13-sep-2011
-- Description:	Obtiene una lista de búsqueda de EjerciciosFiscalesTit
-- =============================================
CREATE FUNCTION [Accounting].[fxEjerciciosFiscalesTitLST](@IdUsuario AS char(18), @IdSucursal AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.IdEjercicioFiscalTit, T.Fecha,E.Nombre as Empresa,S.[Status] AS Estatus
	FROM Accounting.EjerciciosFiscalesTit T 
	JOIN Documents.[Status] S ON T.IdStatus=S.IdStatus
	INNER JOIN Empresas E ON E.IdEmpresa=T.IdEmpresa
	WHERE T.IdSucursal=@IdSucursal
		)


