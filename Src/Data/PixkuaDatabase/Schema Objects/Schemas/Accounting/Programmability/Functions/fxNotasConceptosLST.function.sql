-- =============================================
-- Author: RCO
-- Create date: 04-abr-2011
-- Description:	Obtiene una lista de búsqueda de NotasConceptos
-- =============================================
CREATE FUNCTION [Accounting].[fxNotasConceptosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT NC.IdNotaConcepto, NC.Nombre, C.Codigo AS [Cuenta Contable], C.Nombre AS [Descr Cuenta],
		CASE NC.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Accounting.NotasConceptos NC JOIN Accounting.Cuentas C
		ON NC.IdCuenta=C.IdCuenta
	WHERE NC.IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	)


