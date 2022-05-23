-- =============================================
-- Author: alex Lopez
-- ALTER  date: 15-nov-2011
-- Description:	Obtiene el ID de GastosConceptosTipos en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Purchasing].[fxGastosConceptosTiposID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdGastoConceptoTipo
	FROM Purchasing.GastosConceptosTipos
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


