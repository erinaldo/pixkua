-- =============================================
-- Author: RCO
-- ALTER  date: 04-abr-2011
-- Description:	Obtiene el ID de NotasConceptos en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Accounting].[fxNotasConceptosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdNotaConcepto
	FROM Accounting.NotasConceptos
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


