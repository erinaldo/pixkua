-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Elimina el nodo especificado junto con todos sus nodos secundarios.
-- =============================================
CREATE PROCEDURE [RH].[PuestosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	-- Obtener la ruta del nodo para poder eliminar la rama completa
	DECLARE @Path AS varchar(64)

	SELECT @Path=[Path] + '%' FROM RH.Puestos
	WHERE IdPuesto=@ID

	DELETE RH.Puestos WHERE [Path] LIKE @Path


