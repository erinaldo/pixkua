-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Agrega o modifica la información de DevolucionesCausas
-- =============================================
CREATE PROCEDURE [Sales].[DevolucionesCausasUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
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
		EXEC dbo.NewKey 'Sales.DevolucionesCausas', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Sales.DevolucionesCausas(IdDevolucionCausa, Codigo, Nombre, IdCuenta, 
			IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdCuenta, 
			@IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Sales.DevolucionesCausas SET Codigo=@Codigo, Nombre=@Nombre, IdCuenta=@IdCuenta, 
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdDevolucionCausa=@ID


