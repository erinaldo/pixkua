-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Reacomoda el orden de los nodos de un nivel desde la posición especificada
-- =============================================

CREATE PROCEDURE [Sales].[EstComSortBranch]
	@IdParent AS int,
	@InitPos AS int
AS
	SET NOCOUNT ON
	
	DECLARE @IdNodo AS int
	DECLARE @Counter AS int
	SET @Counter=@InitPos + 1
	-- Obtener todos los nodos que se encuentran desde la posición inicial en adelante
	DECLARE cNodos CURSOR FAST_FORWARD READ_ONLY FOR
	SELECT IdEstCom FROM Sales.EstCom
	WHERE IdPadre=@IdParent AND Orden >= @InitPos
	ORDER BY Orden, Nombre

	OPEN cNodos
	FETCH NEXT FROM cNodos INTO @IdNodo
	WHILE @@Fetch_Status=0
	BEGIN
		UPDATE Sales.EstCom SET Orden=@Counter
		WHERE IdEstCom=@IdNodo
		
		SET @Counter=@Counter + 1

		FETCH NEXT FROM cNodos INTO @IdNodo
	END
	CLOSE cNodos
	DEALLOCATE cNodos


