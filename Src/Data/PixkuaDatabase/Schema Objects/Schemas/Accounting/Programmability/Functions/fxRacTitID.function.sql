-- =============================================
-- Author: alex Lopez
-- ALTER  date: 08-oct-2010
-- Description:	Obtiene el ID de RacTit en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Accounting].[fxRacTitID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdRacTit
	FROM Accounting.RacTit
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


