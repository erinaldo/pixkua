-- =============================================
-- Author: alex Lopez
-- Create date: 08-oct-2010
-- Description:	Obtiene una lista de búsqueda de RacTit
-- =============================================
CREATE FUNCTION [Accounting].[fxRacTitLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT R.IdRacTit,R.Nombre,P.Descripcion AS Perfil,O.Origen,T.Nombre AS Tipo,
		CASE R.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Accounting.RacTit R
	INNER JOIN Accounting.PolizasPerfiles P ON P.IdPolizaPerfil=R.IdPolizaPerfil
	INNER JOIN Accounting.PolizasOrigen O ON O.IdPolizaOrigen=P.IdPolizaOrigen
	INNER JOIN Accounting.PolizasTipos T ON T.IdPolizaTipo =P.IdPolizaTipo
	WHERE R.IdSucursal=@IdSucursal
	)


