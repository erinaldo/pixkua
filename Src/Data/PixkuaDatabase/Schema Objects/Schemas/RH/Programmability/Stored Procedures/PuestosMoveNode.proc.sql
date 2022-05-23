-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Mueve un nodo al nivel y posición especificados
-- =============================================

CREATE PROCEDURE [RH].[PuestosMoveNode]
	@Id AS int,
	@IdPadre AS int,
	@Orden AS int
AS
	SET NOCOUNT ON

	/*Obtener el orden y padre actual del nodo*/
	DECLARE @CurrentOrder AS int, @CurrentParent as int

	SELECT @CurrentOrder=Orden, @CurrentParent=IdPadre
	FROM RH.Puestos
	WHERE IdPuesto=@Id

	-- Actualizar posición de nodo destino
	UPDATE RH.Puestos SET Orden=@CurrentOrder
	WHERE IdPadre=@IdPadre AND Orden=@Orden

	-- Actualizar información de posición	
	UPDATE RH.Puestos SET Orden=@Orden
	WHERE IdPuesto=@Id

	--Si el nodo se movió de rama, actualizar el padre del nodo
	IF @IdPadre = @CurrentParent
		EXEC RH.PuestosSortBranch @IdParent=@IdPadre, @InitPos=0
	ELSE
	BEGIN
		UPDATE RH.Puestos SET IdPadre=@IdPadre
		WHERE IdPuesto=@Id

		-- Ordenar nodos de la rama afectada
		EXEC RH.PuestosSortBranch @IdParent=@IdPadre, @InitPos=0
		EXEC RH.PuestosRefresh @Id=@Id, @CompleteBranch=1
	END


