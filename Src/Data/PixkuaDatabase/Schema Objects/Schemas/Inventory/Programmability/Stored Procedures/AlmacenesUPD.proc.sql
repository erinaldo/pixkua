-- =============================================
-- Author: RCO
-- Create date: 27-sep-2010
-- Description:	Agrega o modifica la información de Almacenes
-- =============================================
CREATE PROCEDURE [Inventory].[AlmacenesUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Nombre AS varchar(64),
	@PermiteNegativos AS bit,
	@ReqCapturaFisico AS bit,
	@IdArea AS int,
	@IdCuenta AS int,
	@IdStatus AS int,
	@IdSucursal AS int,
	@IdEmpresa as int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Inventory.Almacenes', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Inventory.Almacenes(IdAlmacen, Codigo, Nombre, PermiteNegativos, ReqCapturaFisico, IdArea, IdCuenta, 
			IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate, CreateDate, UserCreate)
		VALUES (@Id, @Codigo, @Nombre, @PermiteNegativos, @ReqCapturaFisico, @IdArea, @IdCuenta, 
			@IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate, @LastUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Inventory.Almacenes SET Codigo=@Codigo, Nombre=@Nombre, PermiteNegativos=@PermiteNegativos, 
			ReqCapturaFisico=@ReqCapturaFisico, IdArea=@IdArea, IdCuenta=@IdCuenta, 
			IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdAlmacen=@ID


