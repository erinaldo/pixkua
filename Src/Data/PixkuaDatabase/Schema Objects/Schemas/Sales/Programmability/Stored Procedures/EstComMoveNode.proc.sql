-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Mueve un nodo al nivel y posición especificados
-- =============================================

CREATE PROCEDURE [Sales].[EstComMoveNode]
	@Id AS int,
	@IdPadre AS int,
	@Orden AS int
AS
	SET NOCOUNT ON
	
	/*Obtener el orden y padre actual del nodo*/
	DECLARE @CurrentOrder AS int, @CurrentParent as int

	SELECT @CurrentOrder=Orden, @CurrentParent=IdPadre
	FROM Sales.EstCom
	WHERE IdEstCom=@Id

	-- Actualizar posición de nodo destino
	UPDATE Sales.EstCom SET Orden=@CurrentOrder
	WHERE IdPadre=@IdPadre AND Orden=@Orden

	-- Actualizar información de posición	
	UPDATE Sales.EstCom SET Orden=@Orden
	WHERE IdEstCom=@Id
	
	--Si el nodo se movió de rama, actualizar el padre del nodo
	IF @IdPadre=@CurrentParent
		EXEC Sales.EstComSortBranch @IdParent=@IdPadre, @InitPos=0
	ELSE
	BEGIN
		UPDATE Sales.EstCom SET IdPadre=@IdPadre
		WHERE IdEstCom=@Id

		-- Ordenar nodos de la rama afectada
		EXEC Sales.EstComSortBranch @IdParent=@IdPadre, @InitPos=0
		EXEC Sales.EstComRefresh @Id=@Id, @CompleteBranch=1		
	END


