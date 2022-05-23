CREATE FUNCTION [Purchasing].[fxProveedorExistsByRFC](@IdEmpresa as int, @RFC as char(13))
RETURNS bit
AS
BEGIN
	DECLARE @Result as bit
	
	IF EXISTS(SELECT IdProveedor FROM Purchasing.Proveedores WHERE RFC=@RFC AND IdEmpresa=@IdEmpresa)
		SET @Result=1
	ELSE
		SET @Result=0
		
	RETURN @Result
END


