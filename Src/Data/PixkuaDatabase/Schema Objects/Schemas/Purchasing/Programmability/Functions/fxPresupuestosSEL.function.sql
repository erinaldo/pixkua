-- =============================================
-- Author: alex Lopez
-- Create date: 02-nov-2011
-- Description:	Obtiene la información del Presupuestos especificado.
-- =============================================
CREATE FUNCTION [Purchasing].[fxPresupuestosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT P.* ,D.AdmonPresupuesto,P.MontoPresupuesto-MontoApartado-MontoUtilizado AS Disponible
	 FROM Purchasing.Presupuestos P 
	 LEFT JOIN Purchasing.Departamentos D ON D.IdDepartamento=P.IdDepartamento
	 WHERE IdPresupuesto=@ID)


