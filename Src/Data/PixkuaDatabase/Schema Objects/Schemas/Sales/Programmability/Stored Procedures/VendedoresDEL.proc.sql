-- =============================================
-- Author: alez lopez
-- Create date: 29-ago-2011
-- Description:	Elimina el Vendedores especificado.
-- =============================================
CREATE PROCEDURE [Sales].[VendedoresDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE  Sales.Vendedores SET IdStatus=0 WHERE IdVendedor=@ID


