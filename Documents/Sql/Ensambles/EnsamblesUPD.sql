-- =============================================
-- Author: Victor Moreno
-- Create date: 16-nov-2016
-- Description:	Agrega o modifica la información de Ensambles
-- =============================================
CREATE PROCEDURE Production.EnsamblesUPD
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
	@IdRecepcionUM AS int,
	@IdEntregaUM AS int,
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
		EXEC dbo.NewKey 'Production.Ensambles', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Production.Ensambles(IdEnsamble, Codigo, Nombre, IdRecepcionUM, IdEntregaUM, IdCuenta, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdRecepcionUM, @IdEntregaUM, @IdCuenta, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Production.Ensambles SET Codigo=@Codigo, Nombre=@Nombre, IdRecepcionUM=@IdRecepcionUM, IdEntregaUM=@IdEntregaUM, IdCuenta=@IdCuenta, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdEnsamble=@ID