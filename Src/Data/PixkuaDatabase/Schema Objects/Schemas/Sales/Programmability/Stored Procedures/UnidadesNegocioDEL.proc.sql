-- =============================================
-- Author: RCO
-- Create date: 03-sep-2010
-- Description:	Elimina el UnidadesNegocio especificado.
-- =============================================
CREATE PROCEDURE [Sales].[UnidadesNegocioDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Sales.UnidadesNegocio WHERE IdUnidadNegocio=@ID


