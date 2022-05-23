-- =============================================
-- Author: Alejandro Lopez Cadena
-- Create date: 20-sep-2007
-- Description:	Actualiza la información auxiliar de referencia del nodo especificado y sus nodos secundarios
-- =============================================

CREATE PROCEDURE [Accounting].[CuentasRefresh]
	@Id AS int,
	@CompleteBranch AS bit
AS
	SET NOCOUNT ON
	-- Obtener la ruta del nodo para poder obtener el nodo o la rama completa
	DECLARE @IdNodo AS int
	DECLARE @NodePath AS varchar(64)

	SELECT @NodePath=[Path] FROM Accounting.Cuentas
	WHERE IdCuenta=@Id

	IF @CompleteBranch=1
		SET @NodePath=@NodePath + '%'

	DECLARE cNodos CURSOR FAST_FORWARD READ_ONLY FOR
	SELECT IdCuenta FROM Accounting.Cuentas
	WHERE [Path] LIKE @NodePath

	OPEN cNodos
	FETCH NEXT FROM cNodos INTO @IdNodo
	WHILE @@Fetch_Status=0
	BEGIN
		/*Obtener el path del nodo*/
		DECLARE @Path AS varchar(64)
		SELECT @Path=Accounting.fxCuentasPathCode(@IdNodo)
		/*Obtener path nombrado del nodo*/
		DECLARE @NamedPath as varchar(1024)
		SELECT @NamedPath=Accounting.fxCuentasPathName(@IdNodo)
		/*Obtener nivel donde se ubica*/
		DECLARE @Level AS int
		SELECT @Level=Accounting.fxCuentasLevel(@IdNodo)
		/*Verificar si es un nivel hoja*/
		DECLARE @IsLeaf AS bit
		SELECT @IsLeaf=Accounting.fxCuentasIsLeaf(@IdNodo)
		/*Actualizar el campos de información*/
		UPDATE Accounting.Cuentas SET [Path]=@Path, NamedPath=@NamedPath, Nivel=@Level, IsLeaf=@IsLeaf
		WHERE IdCuenta=@IdNodo

		FETCH NEXT FROM cNodos INTO @IdNodo
	END
	CLOSE cNodos
	DEALLOCATE cNodos


