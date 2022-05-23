-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Mueve un nodo al nivel y posición especificados
-- =============================================

CREATE PROCEDURE [RH].[DepartamentosMoveNode]
	@Id AS int,
	@IdPadre AS int,
	@Orden AS int
AS
	SET NOCOUNT ON

	/*Obtener el orden y padre actual del nodo*/
	DECLARE @CurrentOrder AS int, @CurrentParent as int

	SELECT @CurrentOrder=Orden, @CurrentParent=IdPadre
	FROM RH.Departamentos
	WHERE IdDepartamento=@Id

	-- Actualizar posición de nodo destino
	UPDATE RH.Departamentos SET Orden=@CurrentOrder
	WHERE IdPadre=@IdPadre AND Orden=@Orden

	-- Actualizar información de posición	
	UPDATE RH.Departamentos SET Orden=@Orden
	WHERE IdDepartamento=@Id

	--Si el nodo se movió de rama, actualizar el padre del nodo
	IF @IdPadre = @CurrentParent
		EXEC RH.DepartamentosSortBranch @IdParent=@IdPadre, @InitPos=0
	ELSE
	BEGIN
		UPDATE RH.Departamentos SET IdPadre=@IdPadre
		WHERE IdDepartamento=@Id

		-- Ordenar nodos de la rama afectada
		EXEC RH.DepartamentosSortBranch @IdParent=@IdPadre, @InitPos=0
		EXEC RH.DepartamentosRefresh @Id=@Id, @CompleteBranch=1
	END


