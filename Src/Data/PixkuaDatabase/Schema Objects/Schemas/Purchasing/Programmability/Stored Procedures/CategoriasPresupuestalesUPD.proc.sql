-- =============================================
-- Author: alez lopez
-- Create date: 19-oct-2011
-- Description:	Agrega o modifica la información de CategoriasPresupuestales
-- =============================================
CREATE PROCEDURE [Purchasing].[CategoriasPresupuestalesUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Nombre AS varchar(128),
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
		EXEC dbo.NewKey 'Purchasing.CategoriasPresupuestales', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Purchasing.CategoriasPresupuestales(IdCategoriaPresupuestal, Codigo, Nombre, IdCuenta, 
			IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdCuenta, 
			@IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Purchasing.CategoriasPresupuestales SET Codigo=@Codigo, Nombre=@Nombre, IdCuenta=@IdCuenta, 
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdCategoriaPresupuestal=@ID


