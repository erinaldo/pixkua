-- =============================================
-- Author: RCO
-- Create date: 02-nov-2010
-- Description:	Agrega o modifica la información de Operadores
-- =============================================
CREATE PROCEDURE [dbo].[OperadoresUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
	@EnvioCorreo AS bit,
	@Correo AS varchar(512),
	@EnvioSMS AS bit,
	@NumeroCelular AS varchar(32),
	@IdOperadorCelular AS int,
	@EnvioNetSend AS bit,
	@DireccionIP AS varchar(32),
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
		EXEC dbo.NewKey 'Operadores', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.Operadores(IdOperador, Codigo, Nombre, EnvioCorreo, Correo, EnvioSMS, NumeroCelular, 
			IdOperadorCelular, EnvioNetSend, DireccionIP, 
			IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @EnvioCorreo, @Correo, @EnvioSMS, @NumeroCelular, 
			@IdOperadorCelular, @EnvioNetSend, @DireccionIP, 
			@IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)		
	END
	ELSE
		UPDATE dbo.Operadores SET Codigo=@Codigo, Nombre=@Nombre, EnvioCorreo=@EnvioCorreo, Correo=@Correo, 
			EnvioSMS=@EnvioSMS, NumeroCelular=@NumeroCelular, IdOperadorCelular=@IdOperadorCelular, 
			EnvioNetSend=@EnvioNetSend, DireccionIP=@DireccionIP, 
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdOperador=@ID


