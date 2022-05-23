CREATE PROCEDURE [Purchasing].[CategoriasPresupuestalesServiciosSave]
@IdCategoriaPresupuestal as int,
@IdServicio as int,
@PCUpdate as varchar(64),
@UserUpdate as int
AS
	IF NOT exists(SELECT IdCategoriaPresupuestalServicio FROM Purchasing.CategoriasPresupuestalesServicios WHERe IdCategoriaPresupuestal=@IdCategoriaPresupuestal AND IdServicio=@IdServicio)
	BEGIN
		INSERT INTO Purchasing.CategoriasPresupuestalesServicios (IdCategoriaPresupuestal,IdServicio,LastUpdate,PCUpdate,UserUpdate)
		VALUES(@IdCategoriaPresupuestal,@IdServicio,GETDATE(),@PCUpdate,@UserUpdate)
	END


