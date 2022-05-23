-- =============================================
-- Author: alez lopez
-- Create date: 27-jun-2011
-- Description:	Agrega o modifica la información de CentrosConsumo
-- =============================================
CREATE PROCEDURE [Restaurant].[CentrosConsumoUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(128),
	@IdCaja as int,
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
		EXEC dbo.NewKey 'Restaurant.CentrosConsumo', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Restaurant.CentrosConsumo(IdCentroConsumo, Codigo, Nombre, IdCuenta,IdCaja, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdCuenta, @IdCaja, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Restaurant.CentrosConsumo SET Codigo=@Codigo, Nombre=@Nombre, IdCuenta=@IdCuenta, IdCaja=@IdCaja, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdCentroConsumo=@ID


