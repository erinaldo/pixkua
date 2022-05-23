-- =============================================
-- Author: alex Lopez
-- Create date: 09-oct-2010
-- Description:	Obtiene una lista de búsqueda de PolizasPerfiles
-- =============================================
CREATE FUNCTION [Accounting].[fxPolizasPerfilesLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdPolizaPerfil,P.Codigo,P.Descripcion,O.Origen,T.Nombre AS Tipo,
		CASE T.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
    FROM Accounting.PolizasPerfiles P
    INNER JOIN Accounting.PolizasOrigen O ON O.IdPolizaOrigen=P.IdPolizaOrigen
    INNER JOIN Accounting.PolizasTipos T ON T.IdPolizaTipo=P.IdPolizaTipo
   
    WHERE T.IdEmpresa in (SELECT IdEmpresa FROM Sucursales WHERE IdSucursal=@IdSucursal )
	)


