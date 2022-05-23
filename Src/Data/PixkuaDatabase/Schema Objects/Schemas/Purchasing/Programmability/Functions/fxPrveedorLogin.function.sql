CREATE FUNCTION [Purchasing].[fxPrveedorLogin](@IdEmpresa as int, @Codigo as varchar(32), @Clave as varchar(16))
RETURNS bit
AS
BEGIN
	DECLARE @Result as bit

	SELECT @Result=Cast(IdProveedor as bit)
	FROM Purchasing.Proveedores
	WHERE IdEmpresa=@IdEmpresa AND Codigo=@Codigo AND WebPassword=@Clave

	Return IsNull(@Result, 0)
END


