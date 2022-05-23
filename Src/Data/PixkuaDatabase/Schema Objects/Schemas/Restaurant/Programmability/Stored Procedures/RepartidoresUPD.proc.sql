-- =============================================
-- Author: alez Lopez
-- Create date: 08-ago-2011
-- Description:	Agrega o modifica la información de Repartidores
-- =============================================
CREATE PROCEDURE [Restaurant].[RepartidoresUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@IdUsuario AS int,
	@IdCuenta AS int,
	@NombreCorto AS varchar(32),
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
		EXEC dbo.NewKey 'Restaurant.Repartidores', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Restaurant.Repartidores(IdRepartidor, Codigo, IdUsuario, IdCuenta, NombreCorto, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @IdUsuario, @IdCuenta, @NombreCorto, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Restaurant.Repartidores SET Codigo=@Codigo, IdUsuario=@IdUsuario, IdCuenta=@IdCuenta, NombreCorto=@NombreCorto, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdRepartidor=@ID


