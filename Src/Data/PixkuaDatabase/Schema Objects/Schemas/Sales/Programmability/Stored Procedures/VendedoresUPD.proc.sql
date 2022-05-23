-- =============================================
-- Author: alez lopez
-- Create date: 29-ago-2011
-- Description:	Agrega o modifica la información de Vendedores
-- =============================================
CREATE PROCEDURE [Sales].[VendedoresUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@IdEmpleado AS int,
	@IdCuenta AS int,
	@IdStatus AS int,
	@IdSucursal AS int,
	@IdEmpresa AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Sales.Vendedores', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Sales.Vendedores(IdVendedor, Codigo, IdEmpleado, IdCuenta, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @IdEmpleado, @IdCuenta, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Sales.Vendedores SET Codigo=@Codigo, IdEmpleado=@IdEmpleado,IdCuenta=@IdCuenta, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdVendedor=@ID


