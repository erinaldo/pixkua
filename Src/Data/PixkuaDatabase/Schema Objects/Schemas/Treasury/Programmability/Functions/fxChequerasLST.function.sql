-- =============================================
-- Author: alex Lopez
-- Create date: 02-dic-2011
-- Description:	Obtiene una lista de búsqueda de Chequeras
-- =============================================
CREATE FUNCTION [Treasury].[fxChequerasLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdChequera,C.Cuenta,C.Nombre,B.Nombre as Banco,Cj.Nombre as Caja,
		CASE C.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Treasury.Chequeras C
	INNER JOIN Treasury.Bancos B oN B.IdBanco=C.IdBanco
	INNER JOIN Treasury.Cajas Cj on Cj.IdCaja=C.IdCaja
	WHERE C.IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	)


