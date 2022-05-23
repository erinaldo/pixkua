-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Obtiene una lista de búsqueda de CFDCertificados
-- =============================================
CREATE FUNCTION [Accounting].[fxCFDCertificadosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT C.IdCFDCertificado, C.Nombre, C.NumCertificado, E.Nombre AS Empresa, C.Codigo
	FROM Accounting.CFDCertificados C JOIN dbo.Sucursales S
		ON C.IdSucursal=S.IdSucursal
	JOIN dbo.Empresas E
		ON C.IdEmpresa=E.IdEmpresa
	WHERE C.IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	)


