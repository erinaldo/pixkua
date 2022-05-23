CREATE FUNCTION [Accounting].[fxCuentasOrigenExterno](@IdEmpresa INT)
RETURNS @CuentasTable TABLE (Codigo varchar(32),Nombre varchar(128),Tipo char(1))
BEGIN
	INSERT INTO @CuentasTable
		SELECT DISTINCT C.Codigo,C.Nombre,C.Tipo
		FROM Accounting.CuentasImportacion C
		
	RETURN	
END


