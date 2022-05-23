-- =============================================
-- Author: RCO
-- Create date: 01-nov-2010
-- Description:	Elimina el Proveedores especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[ProveedoresDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Purchasing.Proveedores WHERE IdProveedor=@ID


