-- =============================================
-- Author: alez lopez
-- Create date: 27-jun-2011
-- Description:	Agrega o modifica la información de Meseros
-- =============================================
CREATE PROCEDURE [Restaurant].[MeserosUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@IdUsuario AS int,
	@IdCuenta AS int,
	@NombreCorto as varchar(32),
	@Fotografia AS image,
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
		EXEC dbo.NewKey 'Restaurant.Meseros', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Restaurant.Meseros(IdMesero, Codigo, IdUsuario, IdCuenta, NombreCorto,Fotografia, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @IdUsuario, @IdCuenta,@NombreCorto, @Fotografia, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Restaurant.Meseros SET Codigo=@Codigo, NombreCorto=@NombreCorto, IdUsuario=@IdUsuario, IdCuenta=@IdCuenta, Fotografia=@Fotografia, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdMesero=@ID


