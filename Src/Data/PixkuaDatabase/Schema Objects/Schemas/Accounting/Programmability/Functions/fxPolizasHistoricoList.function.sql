CREATE FUNCTION [Accounting].[fxPolizasHistoricoList](@FechaINI as datetime,@FechaFin as datetime,@IdPolizaOrigen as int)
RETURNS Table
AS
	RETURN(	SELECT T.IdPolizaTit,T.Fecha,S.Nombre as Sucursal,O.Origen,TP.Nombre + '-'+ str(T.Folio)as Tipo ,St.StatusApplied AS [Status],T.Folio,T.IdStatus,IsNull(L.Mensaje,'')AS Mensaje
			FROM Accounting.PolizasTit T
			INNER JOIN Accounting.PolizasPerfiles AS P ON P.IdPolizaPerfil=T.IdPolizaPerfil
			INNER JOIN Accounting.PolizasTipos TP ON TP.IdPolizaTipo=P.IdPolizaTipo
			INNER JOIN Sucursales S On S.IdSucursal=T.IdSucursal
			INNER JOIN Accounting.PolizasOrigen O ON O.IdPolizaOrigen=P.IdPolizaOrigen			
			INNER JOIN Documents.Status St ON St.IdStatus=T.IdStatus
			LEFT  JOIN Accounting.PolizasLog L ON L.IdPolizaTit=T.IdPolizaTit AND T.Fecha=L.Fecha
			WHERE T.Fecha BETWEEN @FechaINI AND @FechaFIN AND P.IdPolizaOrigen=@IdPolizaOrigen)


