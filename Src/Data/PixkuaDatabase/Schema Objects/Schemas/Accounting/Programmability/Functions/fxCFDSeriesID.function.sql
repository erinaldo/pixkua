-- =============================================
-- Author: RCO
-- ALTER  date: 04-sep-2010
-- Description:	Obtiene el ID de CFDSeries en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Accounting].[fxCFDSeriesID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdCFDSerie
	FROM Accounting.CFDSeries
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


