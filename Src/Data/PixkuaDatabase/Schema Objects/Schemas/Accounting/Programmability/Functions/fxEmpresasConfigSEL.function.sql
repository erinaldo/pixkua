CREATE FUNCTION [Accounting].[fxEmpresasConfigSEL](@IdEmpresa as INT)
RETURNS TABLE
AS
	RETURN
	(SELECT E.IdEmpresa,E.Nombre AS Empresa,E.FormatoContable,ISNULL( C.BaseDatos,'')AS BaseDatos,IsNull(IdServicio,0) as IdServicio,IsNull(Niveles,0) AS Niveles
	 FROM Empresas E
	 LEFT JOIN Accounting.EmpresasConfig C ON C.IdEmpresa=E.IdEmpresa
	 WHERE E.IdEmpresa=@IdEmpresa
)


