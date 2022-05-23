-- =============================================
-- Author: RCO
-- Create date: 24-oct-2010
-- Description:	Agrega o modifica la información de RemitentesMail
-- =============================================
CREATE PROCEDURE [dbo].[RemitentesMailUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
	@MailAddress AS varchar(128),
	@IdServidorSMTP as int,
	@OverrideSMTPAuth as bit,
	@UserName AS varchar(128),
	@Password AS varchar(32),
	@IdSucursal AS int,
	@IdEmpresa as int,
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@UserUpdate AS int,
	@PCUpdate AS varchar(32)
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'RemitentesMail', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.RemitentesMail(IdRemitenteMail, Codigo, Nombre, MailAddress, IdServidorSMTP, OverrideSMTPAuth, UserName, [Password], 
			IdSucursal, IdEmpresa, IdStatus, LastUpdate, UserUpdate, PCUpdate)
		VALUES (@Id, @Codigo, @Nombre, @MailAddress, @IdServidorSMTP, @OverrideSMTPAuth, @UserName, @Password, 
			@IdSucursal, @IdEmpresa, @IdStatus, @LastUpdate, @UserUpdate, @PCUpdate)
	END
	ELSE
		UPDATE dbo.RemitentesMail SET Codigo=@Codigo, Nombre=@Nombre, MailAddress=@MailAddress, IdServidorSMTP=@IdServidorSMTP, 
			OverrideSMTPAuth=@OverrideSMTPAuth, UserName=@UserName, Password=@Password, 
			IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, IdStatus=@IdStatus, LastUpdate=@LastUpdate, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate
		WHERE IdRemitenteMail=@ID


