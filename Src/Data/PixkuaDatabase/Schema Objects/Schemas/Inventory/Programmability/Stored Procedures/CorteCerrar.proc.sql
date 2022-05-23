CREATE PROCEDURE [Inventory].[CorteCerrar]
	@IdCorte as uniqueidentifier,
	@IdUsuario as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON
	
	DECLARE @FechaCierre as datetime, @HoraCierre as datetime, @IdArea as int
	SELECT @FechaCierre=CONVERT(varchar(10), GETDATE(), 112), @HoraCierre=GETDATE()
	
	-->Obtener el área a la que pertenece el corte
	SELECT @IdArea=IdArea
	FROM Inventory.Cortes
	WHERE IdCorte=@IdCorte
	
	-->Actualizar fecha de cierre y usuario
	UPDATE Inventory.Cortes SET FechaCierre=@FechaCierre, HoraCierre=@HoraCierre, 
		IdUsuarioCierre=@IdUsuario
	WHERE IdCorte=@IdCorte
	
	-->Quitar campo de corte actual de áreas
	UPDATE Inventory.Areas SET IdCorteActual=dbo.fxEmptyID()
	WHERE IdArea=@IdArea
	
	-->Insertar inventario actual en el histórico
	INSERT INTO Inventory.InventarioHist(IdArticuloStock, IdAlmacen, IdCorte, Disponible, 
			Apartado, Transito, CostoUltimo, CostoPromedio, StockMax, StockMin, PuntoReorden,
			UserUpdate, LastUpdate, PCUpdate)
	SELECT I.IdArticuloStock, I.IdAlmacen, @IdCorte, I.Disponible, 
			I.Apartado, I.Transito, I.CostoUltimo, I.CostoPromedio, I.StockMax, I.StockMin, I.PuntoReorden,
			@IdUsuario, GetDate(), @PCUpdate
	FROM Inventory.Inventario I JOIN Inventory.Almacenes A
		ON I.IdAlmacen=A.IdAlmacen
	WHERE A.IdArea=@IdArea


