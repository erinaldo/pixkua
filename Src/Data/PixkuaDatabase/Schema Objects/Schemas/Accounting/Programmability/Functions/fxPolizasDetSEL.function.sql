-- =============================================
-- Author: alex Lopez
-- Create date: 08-nov-2010
-- Description:	Obtiene la información del PolizasDet especificado.
-- Este Stored debe recuperar exactamente los mismos parametros que contiene el Stored Procedure PolizasDetUPD
-- =============================================
CREATE FUNCTION [Accounting].[fxPolizasDetSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN 
	(
	SELECT IdPolizaDet, D.IdReferencia, D.Referencia, D.IdVistaContableTit, D.IdCuenta,IsNull(C.Nombre,'') + '- '+  D.Observaciones AS Observaciones, D.Cargo, D.Abono, D.Orden, D.IdSegmento,IsNull(C.Codigo,'') AS Cuenta,IsNull(C.Nombre,'') AS CuentaName ,IsNull(S.Descripcion,'') AS Segmento
	FROM Accounting.PolizasDet D
	LEFT JOIN Accounting.Cuentas C ON C.IdCuenta=D.IdCuenta
	LEFT JOIN Accounting.SegmentosNegocio S ON S.IdSegmentoNegocio=D.IdSegmento
	WHERE IdPolizaTit=@ID and Fecha = Documents.fxDocumentDate(@Id)
	)


