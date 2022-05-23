CREATE PROCEDURE [Purchasing].[PresupuestoAutoriza]
@IdPresupuesto as int
AS
	UPDATE Purchasing.Presupuestos SET Estatus='A' WHERE IdPresupuesto=@IdPresupuesto


