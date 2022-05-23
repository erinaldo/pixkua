-- =============================================
-- Author: alez lopez
-- Create date: 27-jun-2011
-- Description:	Agrega o modifica la información de Mesas
-- =============================================
CREATE PROCEDURE [Restaurant].[MesasUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Descripcion AS varchar(32),
	@IdCentroConsumo AS int,
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
		EXEC dbo.NewKey 'Restaurant.Mesas', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Restaurant.Mesas(IdMesa, Codigo, Descripcion, IdCentroConsumo, IdCuenta, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Descripcion, @IdCentroConsumo, @IdCuenta, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Restaurant.Mesas SET Codigo=@Codigo, Descripcion=@Descripcion, IdCentroConsumo=@IdCentroConsumo, IdCuenta=@IdCuenta, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdMesa=@ID


