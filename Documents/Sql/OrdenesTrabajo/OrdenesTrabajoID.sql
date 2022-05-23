-- =============================================
-- Author: Victor Moreno
-- ALTER  date: 01-dic-2016
-- Description:	Obtiene el ID de OrdenesTrabajo en base a su código de usuario.
-- =============================================

CREATE FUNCTION Production.fxOrdenesTrabajoID 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdOrdenTrabajo
	FROM Production.OrdenesTrabajo
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END