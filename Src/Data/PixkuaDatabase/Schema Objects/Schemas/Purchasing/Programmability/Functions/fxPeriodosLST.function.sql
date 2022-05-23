-- =============================================
-- Author: alez Lopez
-- Create date: 01-nov-2011
-- Description:	Obtiene una lista de búsqueda de Periodos
-- =============================================
CREATE FUNCTION [Purchasing].[fxPeriodosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT P.IdPeriodo,P.Nombre,
		CASE P.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Purchasing.Periodos P
	INNER JOIN Accounting.EjerciciosFiscalesTit E ON E.IdEjercicioFiscalTit=P.IdEjercicioFiscalTit
	WHERE P.IdSucursal=@IdSucursal
	)


