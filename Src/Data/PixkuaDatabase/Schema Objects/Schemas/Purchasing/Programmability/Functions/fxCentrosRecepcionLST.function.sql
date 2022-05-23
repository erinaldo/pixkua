-- =============================================
-- Author: alez lopez
-- Create date: 19-oct-2011
-- Description:	Obtiene una lista de búsqueda de CentrosRecepcion
-- =============================================
CREATE FUNCTION [Purchasing].[fxCentrosRecepcionLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdCentroRecepcion,Nombre,Calle,Colonia,NumExt,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Purchasing.CentrosRecepcion
	--WHERE IdSucursal=@IdSucursal
	)


