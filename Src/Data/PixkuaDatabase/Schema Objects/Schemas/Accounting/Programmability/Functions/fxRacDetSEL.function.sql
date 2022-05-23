-- =============================================
-- Author: alexLopez
-- Create date: 08-oct-2010
-- Description:	Obtiene la información del RacDet especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxRacDetSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(	SELECT D.IdRacDet AS Id,D.IdRacTit,D.IdCuenta,C.Codigo AS Cuenta,D.IdEntidad,'' AS Entidad, D.CampoFK,C.Nombre as Concepto, D.isEntidadConcepto,D.Afectador,D.Rojo,D.IdImporte,I.Importe,D.Orden  
		FROM Accounting.RacDet D
		INNER JOIN Accounting.Cuentas	C ON C.IdCuenta=D.IdCuenta
		INNER JOIN Accounting.Importes AS I ON I.IdImporte=D.IdImporte
		WHERE IdRacTit=@ID
		UNION ALL
		SELECT D.IdRacDet AS Id,D.IdRacTit,D.IdCuenta,'' AS Cuenta,D.IdEntidad,E.Entidad,D.CampoFK,'' AS Concepto,D.isEntidadConcepto,d.Afectador,D.Rojo,d.IdImporte,I.Importe,D.Orden
		FROM Accounting.RacDet D
		INNER JOIN Accounting.Entidades AS E ON E.IdEntidad=D.IdEntidad
		INNER JOIN Accounting.Importes AS I ON I.IdImporte=D.IdImporte
		WHERE IdRacTit=@ID
		)


