-- =============================================
-- Author: alez Lopez
-- Create date: 13-sep-2011
-- Description:	Obtiene la información del EjerciciosFiscalesDet especificado.
-- Este Stored debe recuperar exactamente los mismos parametros que contiene el Stored Procedure EjerciciosFiscalesDetUPD
-- =============================================
CREATE FUNCTION [Accounting].[fxEjerciciosFiscalesDetSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN 
	(
	SELECT Mes, Activo, 
		CASE
		WHEN Mes=1 THEN 'Enero'
		WHEN Mes=2 THEN 'Febrero'
		WHEN Mes=3 THEN 'Marzo'
		WHEN Mes=4 THEN 'Abril'
		WHEN Mes=5 THEN 'Mayo'
		WHEN Mes=6 THEN 'Junio'
		WHEN Mes=7 THEN 'Julio'
		WHEN Mes=8 THEN 'Agosto'
		WHEN Mes=9 THEN 'Septiembre'
		WHEN Mes=10 THEN 'Octubre'
		WHEN Mes=11 THEN 'Noviembre'
		WHEN Mes=12 THEN 'Diciembre'
		END	AS Periodo 
	FROM Accounting.EjerciciosFiscalesDet 
	WHERE IdEjercicioFiscalTit=@ID and Fecha = Documents.fxDocumentDate(@Id)
	)


