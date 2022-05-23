CREATE PROCEDURE [Purchasing].[PresupuestoCategoriasUPD]
@IdPresupuesto as int,
@IdCategoriaPresupuestal as int,
@MontoPresupuesto as decimal(19,4)
AS

IF NOT EXISTS (SELECT IdPresupuestoCategoria FROM Purchasing.PresupuestosCategorias WHERE IdPresupuesto=@IdPresupuesto AND IdCategoriaPresupuestal=@IdCategoriaPresupuestal)
	INSERT INTO Purchasing.PresupuestosCategorias(IdPresupuesto,IdCategoriaPresupuestal,MontoPresupuesto)
		VALUES(@IdPresupuesto,@IdCategoriaPresupuestal,@MontoPresupuesto)
ELSE
	UPDATE	Purchasing.PresupuestosCategorias SET  MontoPresupuesto=@MontoPresupuesto WHERE IdPresupuesto=@IdPresupuesto AND IdCategoriaPresupuestal=@IdCategoriaPresupuestal
	
--Si el renglon quedo en cero y no tiene ni apartado ni utilizado, ps lo borramos	
DELETE Purchasing.PresupuestosCategorias 
WHERE IdPresupuesto=@IdPresupuesto AND IdCategoriaPresupuestal=@IdCategoriaPresupuestal AND (MontoPresupuesto+MontoUtilizado+MontoApartado)=0


