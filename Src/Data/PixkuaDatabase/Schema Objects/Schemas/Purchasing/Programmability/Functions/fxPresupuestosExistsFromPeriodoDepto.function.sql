-- =============================================
-- Author: alex Lopez
-- Create date: 02-nov-2011
-- Description:	Verifica la existencia de Presupuestos
-- =============================================
CREATE FUNCTION [Purchasing].[fxPresupuestosExistsFromPeriodoDepto](@IdPeriodo AS int,@IdDepartamento as int)
RETURNS INT
AS
BEGIN
	DECLARE @Result AS int

	SELECT @Result=IdPresupuesto FROM Purchasing.Presupuestos WHERE IdPeriodo=@IdPeriodo AND IdDepartamento=@IdDepartamento

	SET @Result=ISNULL(@Result,0)

	RETURN @Result	
END


