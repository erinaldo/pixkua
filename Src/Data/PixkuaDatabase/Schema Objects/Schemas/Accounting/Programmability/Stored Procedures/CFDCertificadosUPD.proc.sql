-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Agrega o modifica la información de CFDCertificados
-- =============================================
CREATE PROCEDURE [Accounting].[CFDCertificadosUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(128),
	@LlavePrivada AS varbinary(2048)=null,
	@PasswordPK AS varchar(32),
	@Certificado AS varbinary(2048)=null,
	@NumCertificado AS char(20),
	@IdEmpresa as int,
	@IdSucursal AS int,
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Accounting.CFDCertificados', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Accounting.CFDCertificados(IdCFDCertificado, Codigo, Nombre, LlavePrivada, PasswordPK, 
			Certificado, NumCertificado, IdEmpresa,
			IdSucursal, IdStatus, LastUpdate, PCUpdate, UserUpdate, CreateDate, UserCreate)
		VALUES (@Id, @Codigo, @Nombre, @LlavePrivada, @PasswordPK, 
			@Certificado, @NumCertificado, @IdEmpresa,
			@IdSucursal, @IdStatus, @LastUpdate, @PCUpdate, @UserUpdate, @LastUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Accounting.CFDCertificados SET Codigo=@Codigo, Nombre=@Nombre, LlavePrivada=@LlavePrivada, 
			PasswordPK=@PasswordPK, Certificado=@Certificado, NumCertificado=@NumCertificado, 
			IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, 
			IdStatus=@IdStatus, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdCFDCertificado=@ID


