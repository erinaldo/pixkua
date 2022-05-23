-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Actualiza la información auxiliar de referencia del nodo especificado y sus nodos secundarios
-- =============================================

CREATE PROCEDURE [RH].[PuestosRefresh]
	@Id AS int,
	@CompleteBranch AS bit
AS
	SET NOCOUNT ON
	-- Obtener la ruta del nodo para poder obtener el nodo o la rama completa
	DECLARE @IdNodo AS int
	DECLARE @NodePath AS varchar(64)

	SELECT @NodePath=[Path] FROM RH.Puestos
	WHERE IdPuesto=@Id

	IF @CompleteBranch=1
		SET @NodePath=@NodePath + '%'

	DECLARE cNodos CURSOR FAST_FORWARD READ_ONLY FOR
	SELECT IdPuesto FROM RH.Puestos
	WHERE [Path] LIKE @NodePath

	OPEN cNodos
	FETCH NEXT FROM cNodos INTO @IdNodo
	WHILE @@Fetch_Status=0
	BEGIN
		/*Obtener el path del nodo*/
		DECLARE @Path AS varchar(64)
		SELECT @Path=RH.fxPuestosPathCode(@IdNodo)
		/*Obtener path nombrado del nodo*/
		DECLARE @NamedPath as varchar(1024)
		SELECT @NamedPath=RH.fxPuestosPathName(@IdNodo)
		/*Obtener nivel donde se ubica*/
		DECLARE @Level AS int
		SELECT @Level=RH.fxPuestosLevel(@IdNodo)
		/*Verificar si es un nivel hoja*/
		DECLARE @IsLeaf AS bit
		SELECT @IsLeaf=RH.fxPuestosIsLeaf(@IdNodo)
		/*Actualizar el campos de información*/
		UPDATE RH.Puestos SET [Path]=@Path, NamedPath=@NamedPath, Nivel=@Level, IsLeaf=@IsLeaf
		WHERE IdPuesto=@IdNodo

		FETCH NEXT FROM cNodos INTO @IdNodo
	END
	CLOSE cNodos
	DEALLOCATE cNodos


