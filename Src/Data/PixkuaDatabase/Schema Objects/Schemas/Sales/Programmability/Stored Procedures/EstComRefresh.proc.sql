-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Actualiza la información auxiliar de referencia del nodo especificado y sus nodos secundarios
-- =============================================

CREATE PROCEDURE [Sales].[EstComRefresh]
	@Id AS int,
	@CompleteBranch AS bit
AS
	SET NOCOUNT ON
	-- Obtener la ruta del nodo para poder obtener el nodo o la rama completa
	DECLARE @IdNodo AS int
	DECLARE @NodePath AS varchar(64)

	SELECT @NodePath=[Path] FROM Sales.EstCom
	WHERE IdEstCom=@Id

	IF @CompleteBranch=1
		SET @NodePath=@NodePath + '%'

	DECLARE cNodos CURSOR FAST_FORWARD READ_ONLY FOR
	SELECT IdEstCom FROM Sales.EstCom
	WHERE [Path] LIKE @NodePath

	OPEN cNodos
	FETCH NEXT FROM cNodos INTO @IdNodo
	WHILE @@Fetch_Status=0
	BEGIN
		/*Obtener el path del nodo*/
		DECLARE @Path AS varchar(64)
		SELECT @Path=Sales.fxEstComPathCode(@IdNodo)
		/*Obtener path nombrado del nodo*/
		DECLARE @NamedPath as varchar(1024)
		SELECT @NamedPath=Sales.fxEstComPathName(@IdNodo)
		/*Obtener nivel donde se ubica*/
		DECLARE @Level AS int
		SELECT @Level=Sales.fxEstComLevel(@IdNodo)
		/*Verificar si es un nivel hoja*/
		DECLARE @IsLeaf AS bit
		SELECT @IsLeaf=Sales.fxEstComIsLeaf(@IdNodo)
		/*Actualizar el campos de información*/
		UPDATE Sales.EstCom SET [Path]=@Path, NamedPath=@NamedPath, Nivel=@Level, IsLeaf=@IsLeaf
		WHERE IdEstCom=@IdNodo

		FETCH NEXT FROM cNodos INTO @IdNodo
	END
	CLOSE cNodos
	DEALLOCATE cNodos


