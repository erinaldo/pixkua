-- =============================================
-- Author: alez lopez
-- Create date: 04-mar-2011
-- Description:	Elimina el Productos especificado.
-- =============================================
CREATE PROCEDURE [Production].[ProductosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Production.Productos SET IdStatus=0 WHERE IdProducto=@ID


