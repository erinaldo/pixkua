-- =============================================
-- Author: alez Lopez
-- Create date: 22-ago-2011
-- Description:	Elimina el GruposDescuento especificado.
-- =============================================
CREATE PROCEDURE [Sales].[GruposDescuentoDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Sales.GruposDescuento SET IdStatus=0 WHERE IdGrupoDescuento=@ID


