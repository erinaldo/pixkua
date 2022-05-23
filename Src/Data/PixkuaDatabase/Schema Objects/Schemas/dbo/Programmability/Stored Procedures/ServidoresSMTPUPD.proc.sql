-- =============================================
-- Author: RCO
-- Create date: 27-oct-2010
-- Description:	Agrega o modifica la información de ServidoresSMTP
-- =============================================
CREATE PROCEDURE [dbo].[ServidoresSMTPUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
	@HostName AS varchar(128),
	@Port AS int,
	@UserName AS varchar(128),
	@Password AS varchar(32),
	@AuthMethod AS varchar(32),
	@LoginDomain AS varchar(64),
	@SSL AS bit,
	@CloseConnection AS bit,
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
		EXEC dbo.NewKey 'ServidoresSMTP', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.ServidoresSMTP(IdServidorSMTP, Codigo, Nombre, HostName, Port, UserName, [Password], AuthMethod, LoginDomain, [SSL], CloseConnection, 
			IdSucursal, IdStatus, LastUpdate, UserUpdate, PCUpdate)
		VALUES (@Id, @Codigo, @Nombre, @HostName, @Port, @UserName, @Password, @AuthMethod, @LoginDomain, @SSL, @CloseConnection, 
			@IdSucursal, @IdStatus, @LastUpdate, @UserUpdate, @PCUpdate)	
	END
	ELSE
		UPDATE dbo.ServidoresSMTP SET Codigo=@Codigo, Nombre=@Nombre, HostName=@HostName, Port=@Port, UserName=@UserName, 
			[Password]=@Password, AuthMethod=@AuthMethod, LoginDomain=@LoginDomain, [SSL]=@SSL, CloseConnection=@CloseConnection, 
			IdSucursal=@IdSucursal, IdStatus=@IdStatus, LastUpdate=@LastUpdate, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate
		WHERE IdServidorSMTP=@ID


