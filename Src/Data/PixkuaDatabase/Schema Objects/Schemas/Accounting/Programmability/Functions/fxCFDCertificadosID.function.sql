-- =============================================
-- Author: RCO
-- ALTER  date: 04-sep-2010
-- Description:	Obtiene el ID de CFDCertificados en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Accounting].[fxCFDCertificadosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdCFDCertificado
	FROM Accounting.CFDCertificados
	WHERE Codigo=@Codigo AND IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	
	RETURN IsNull(@Id, 0)
END


