-- =============================================
-- Author: alex Lopez
-- Create date: 02-nov-2011
-- Description:	Elimina el Presupuestos especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[PresupuestosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Purchasing.Presupuestos SET IdStatus=0  WHERE IdPresupuesto=@ID


