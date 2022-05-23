CREATE PROCEDURE [Purchasing].[CategoriasPresupuestalesArticulosSave]
@IdCategoriaPresupuestal as int,
@IdArticuloStock as int,
@PCUpdate as varchar(64),
@UserUpdate as int
AS
	IF NOT exists(SELECT IdCategoriaPresupuestalArticulo FROM Purchasing.CategoriasPresupuestalesArticulos WHERe IdCategoriaPresupuestal=@IdCategoriaPresupuestal AND IdArticuloStock=@IdArticuloStock)
	BEGIN
		INSERT INTO Purchasing.CategoriasPresupuestalesArticulos (IdCategoriaPresupuestal,IdArticuloStock,LastUpdate,PCUpdate,UserUpdate)
		VALUES(@IdCategoriaPresupuestal,@IdArticuloStock,GETDATE(),@PCUpdate,@UserUpdate)
	END


