-- =============================================
-- Author: RCO
-- Create date: 01-jul-2011
-- Description:	Agrega o modifica la información de Cajeros
-- =============================================
CREATE PROCEDURE [Sales].[CajerosUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@IdEmpleado AS int,
	@IdUsuario AS int,
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
		EXEC dbo.NewKey 'Sales.Cajeros', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Sales.Cajeros(IdCajero, Codigo, IdEmpleado, IdUsuario, IdCuenta, 
			IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @IdEmpleado, @IdUsuario, @IdCuenta, 
			@IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Sales.Cajeros SET Codigo=@Codigo, IdEmpleado=@IdEmpleado, IdUsuario=@IdUsuario, IdCuenta=@IdCuenta, 
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdCajero=@ID


