-- =============================================
-- Author: RCO
-- ALTER  date: 13-oct-2010
-- Description:	Obtiene el ID de Conceptos en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Inventory].[fxConceptosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdConcepto
	FROM Inventory.Conceptos
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


