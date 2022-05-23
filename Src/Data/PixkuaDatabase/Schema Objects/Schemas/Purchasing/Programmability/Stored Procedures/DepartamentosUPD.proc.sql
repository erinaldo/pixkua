-- =============================================
-- Author: alez Lopez
-- Create date: 28-oct-2011
-- Description:	Agrega o modifica la información de Departamentos
-- =============================================
CREATE PROCEDURE [Purchasing].[DepartamentosUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@IdCuenta AS int,
	@IdCentral AS int,
	@IdCaja AS int,
	@AdmonPresupuesto char(1),
	@IdStatus AS int,
	@IdSucursal AS int,
	@IdEmpresa AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF NOT Exists(SELECT IdDepartamento FROM Purchasing.Departamentos WHERE IdDepartamento=@Id)
	BEGIN	
		INSERT INTO Purchasing.Departamentos(IdDepartamento, Codigo, IdCuenta, IdCentral, IdCaja, AdmonPresupuesto, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @IdCuenta, @IdCentral, @IdCaja, @AdmonPresupuesto, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Purchasing.Departamentos SET Codigo=@Codigo, IdCuenta=@IdCuenta, IdCentral=@IdCentral, IdCaja=@IdCaja, AdmonPresupuesto=@AdmonPresupuesto, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdDepartamento=@ID


