-- =============================================
-- Author: RCO
-- Create date: 15-oct-2010
-- Description:	Agrega o modifica la información de Marcas
-- =============================================
CREATE PROCEDURE [Sales].[MarcasUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Nombre AS varchar(64),
	@IdCuenta as int,
	@IdStatus AS int,
	@IdEmpresa as int,
	@IdSucursal AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Sales.Marcas', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Sales.Marcas(IdMarca, Codigo, Nombre, IdCuenta,
			IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdCuenta,
			@IdStatus, @IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Sales.Marcas SET Codigo=@Codigo, Nombre=@Nombre, IdCuenta=@IdCuenta,
			IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdMarca=@ID


