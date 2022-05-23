CREATE FUNCTION [Purchasing].[fxProveedoresSELByRFC](@IdEmpresa as int, @RFC as char(13))
RETURNS TABLE
AS
RETURN	(
	SELECT *
	FROM Purchasing.Proveedores
	WHERE RFC=@RFC AND IdEmpresa=@IdEmpresa
		)


