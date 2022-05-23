-- =============================================
-- Author: alez Lopez
-- Create date: 28-oct-2011
-- Description:	Obtiene la información del Departamentos especificado.
-- =============================================
CREATE FUNCTION [Purchasing].[fxDepartamentosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT rh.IdDepartamento,rh.Codigo,Isnull(D.IdCuenta,0)AS IdCuenta,IsNull(D.IdCentral,0)AS IdCentral,ISNULL(D.AdmonPresupuesto,'N')AS AdmonPresupuesto,D.IdCaja,
			IsNull(D.IdStatus,1)AS IdStatus,ISNULL(D.IdSucursal,rh.IdSucursal)AS IdSucursal,IsNull(D.IdEmpresa,rh.IdEmpresa)AS IdEmpresa,
			ISNULL(D.CreateDate,rh.CreateDate)AS CreateDate,ISNULL(D.LastUpdate,rh.LastUpdate)AS LastUpdate,IsNull(D.PCUpdate,rh.PCUpdate)AS PCUpdate,
			ISNULL(D.UserCreate,rh.UserCreate)AS UserCreate,ISNULL(D.UserUpdate,rh.UserUpdate)AS UserUpdate
	 FROM RH.Departamentos rh
	 LEFT JOIN Purchasing.Departamentos D ON d.IdDepartamento=rh.IdDepartamento
	 WHERE Rh.IdDepartamento=@ID)


