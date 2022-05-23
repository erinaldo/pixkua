-- =============================================
-- Author: alex Lopez
-- Create date: 02-dic-2011
-- Description:	Obtiene una lista de búsqueda de Beneficiarios
-- =============================================
CREATE FUNCTION [Treasury].[fxBeneficiariosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT B.IdBeneficiario,B.RazonSocial AS [Razon Social],Ban.Nombre as Banco,B.CLABE,C.Codigo AS Cuenta,C.Nombre AS Concepto,
		CASE B.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Treasury.Beneficiarios B
	INNER JOIN Treasury.Bancos Ban ON Ban.Idbanco=B.Idbanco
	LEFT JOIN Accounting.Cuentas C ON C.IdCuenta=B.Idcuenta
	WHERE B.IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	)


