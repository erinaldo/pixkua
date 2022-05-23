-- =============================================
-- Author: alez lopez
-- ALTER  date: 17-oct-2010
-- Description:	Obtiene el ID de VistasContablesTit en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Accounting].[fxVistasContablesTitID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdVistaContableTit
	FROM Accounting.VistasContablesTit
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


