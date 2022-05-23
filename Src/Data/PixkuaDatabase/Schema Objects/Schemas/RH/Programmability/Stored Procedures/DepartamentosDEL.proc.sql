-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Elimina el nodo especificado junto con todos sus nodos secundarios.
-- =============================================
CREATE PROCEDURE [RH].[DepartamentosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	-- Obtener la ruta del nodo para poder eliminar la rama completa
	DECLARE @Path AS varchar(64)

	SELECT @Path=[Path] + '%' FROM RH.Departamentos
	WHERE IdDepartamento=@ID

	DELETE RH.Departamentos WHERE [Path] LIKE @Path


