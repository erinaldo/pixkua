CREATE FUNCTION [Accounting].[fxSegmentosNegocioCBO](@IdEmpresa as int)
RETURNS TABLE	
AS
	RETURN (SELECT IdSegmentoNegocio AS Id,Descripcion
			FROM Accounting.SegmentosNegocio
			WHERE IdEmpresa=@IdEmpresa
			)


