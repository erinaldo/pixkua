-- =============================================
-- Author: RCO
-- Create date: 02-nov-2010
-- Description:	Obtiene una lista de búsqueda de Operadores
-- =============================================
CREATE FUNCTION [dbo].[fxOperadoresLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdOperador, Nombre, Correo, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM dbo.Operadores
	WHERE IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	)


