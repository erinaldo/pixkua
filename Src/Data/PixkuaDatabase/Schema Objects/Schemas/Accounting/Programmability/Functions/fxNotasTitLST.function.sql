-- =============================================
-- Author: RCO
-- Create date: 04-abr-2011
-- Description:	Obtiene una lista de búsqueda de NotasTit
-- =============================================
CREATE FUNCTION [Accounting].[fxNotasTitLST](@IdUsuario AS char(18), @IdSucursal AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.IdNotaTit, T.Fecha, IsNull(Se.Serie, '') AS Serie, T.FolioNota AS Folio, T.RFC, T.RazonSocial AS [Razón Social],
		T.Total AS Monto, D.Nombre AS Divisa, S.[Status] AS Estatus
	FROM Accounting.NotasTit T JOIN Documents.[Status] S
		ON T.IdStatus=S.IdStatus
	JOIN Accounting.Divisas D
		ON T.IdDivisa=D.IdDivisa		
	LEFT JOIN Accounting.CFDSeries Se
		ON T.IdCFDSerie=Se.IdCFDSerie
	WHERE T.IdSucursal=@IdSucursal
		)


