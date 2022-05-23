-- =============================================
-- Author: RCO
-- Create date: 06-sep-2010
-- Description:	Obtiene una lista de búsqueda de CFDAddendas
-- =============================================
CREATE FUNCTION [Accounting].[fxCFDAddendasLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT IdCFDAddenda, Nombre, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activa'
			WHEN 0 THEN 'Inactiva'
		END AS EStatus
	FROM Accounting.CFDAddendas
	WHERE IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)	
	)


