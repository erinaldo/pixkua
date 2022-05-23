-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 27-Dic-2005
-- Description:	Agrega o modifica la información de un usuario.
-- =============================================
CREATE PROCEDURE [dbo].[UsuariosUPD]
	@Id AS int out,
	@IdPersona AS int,
	@Usuario AS varchar(32),
	@Codigo AS varchar(32),
	@Password AS varchar(128),
	@DomainUser as varchar(64),
	@IdSucursal AS int,
	@IdEmpresa as int,
	@LightUser AS bit,
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @Id=0
	BEGIN
		EXEC dbo.NewKey 'Usuarios', @Id out
		
		IF @Codigo='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.Usuarios(IdUsuario, IdPersona, Usuario, Password, DomainUser, IdSucursal, IdEmpresa, LightUser, 
			IdStatus, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @IdPersona, @Usuario, @Password, @DomainUser, @IdSucursal, @IdEmpresa, @LightUser, 
			@IdStatus, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE dbo.Usuarios SET IdPersona=@IdPersona, Usuario=@Usuario, Password=@Password, 
			IdSucursal=@IdSucursal, LightUser=@LightUser, DomainUser=@DomainUser,
			IdStatus=@IdStatus, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdUsuario=@Id


