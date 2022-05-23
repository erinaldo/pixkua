-- =============================================
-- Author: Alejandro Lopez Cadena
-- Create date: 20-sep-2007
-- Description:	Mueve un nodo al nivel y posición especificados
-- =============================================

CREATE PROCEDURE [Accounting].[CuentasMoveNode]
	@Id AS int,
	@IdPadre AS int,
	@Orden AS int
AS
	SET NOCOUNT ON

	/*Obtener el orden y padre actual del nodo*/
	DECLARE @CurrentOrder AS int, @CurrentParent as int

	SELECT @CurrentOrder=Orden, @CurrentParent=IdPadre
	FROM Accounting.Cuentas
	WHERE IdCuenta=@Id

	-- Actualizar posición de nodo destino
	UPDATE Accounting.Cuentas SET Orden=@CurrentOrder
	WHERE IdPadre=@IdPadre AND Orden=@Orden

	-- Actualizar información de posición	
	UPDATE Accounting.Cuentas SET Orden=@Orden, IdPadre=@IdPadre 
	WHERE IdCuenta=@Id

	--Si el nodo se movió de rama, actualizar el padre del nodo
	IF @IdPadre=@CurrentParent
		EXEC Accounting.CuentasSortBranch @IdParent=@IdPadre, @InitPos=0		
	ELSE
	BEGIN
		UPDATE Accounting.Cuentas SET IdPadre=@IdPadre
		WHERE IdCuenta=@Id

		-- Ordenar nodos de la rama afectada
		EXEC Accounting.CuentasSortBranch @IdParent=@IdPadre, @InitPos=0
		EXEC Accounting.CuentasRefresh @Id=@Id, @CompleteBranch=1			
	END


