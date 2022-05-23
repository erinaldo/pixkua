CREATE FUNCTION [Documents].[fxDocumentCompany](@IdDocumento AS char(18))
RETURNS int
AS
BEGIN
	DECLARE @IdSucursal AS int,@IdEmpresa AS int
	-->Obtener código de la sucursal
	SELECT @IdSucursal= Cast(Substring(@IdDocumento, 4, 3) AS int)

	SELECT @IdEmpresa=IdEmpresa FROM Sucursales WHERE IdSucursal=@IdSucursal
	
	RETURN @IdEmpresa
END


