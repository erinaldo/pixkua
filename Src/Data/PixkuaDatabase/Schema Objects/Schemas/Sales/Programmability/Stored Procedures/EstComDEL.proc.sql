-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Elimina el nodo especificado junto con todos sus nodos secundarios.
-- =============================================
CREATE PROCEDURE [Sales].[EstComDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	-- Obtener la ruta del nodo para poder eliminar la rama completa
	DECLARE @Path AS varchar(64)

	SELECT @Path=[Path] + '%' FROM Sales.EstCom
	WHERE IdEstCom=@ID

	DELETE Sales.EstCom WHERE [Path] LIKE @Path


