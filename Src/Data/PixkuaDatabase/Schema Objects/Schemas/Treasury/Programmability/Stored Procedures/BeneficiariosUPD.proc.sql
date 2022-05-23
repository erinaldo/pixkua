-- =============================================
-- Author: alex Lopez
-- Create date: 02-dic-2011
-- Description:	Agrega o modifica la información de Beneficiarios
-- =============================================
CREATE PROCEDURE [Treasury].[BeneficiariosUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@RazonSocial AS varchar(128),
	@TipoBeneficiario AS char(1),
	@IdReferencia AS int,
	@IdBanco AS int,
	@CLABE AS char(18),
	@LeyendaCheque AS bit,
	@DiasCredito AS int,
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
		EXEC dbo.NewKey 'Treasury.Beneficiarios', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
			
		IF @IdReferencia=0 
			SET @IdReferencia=@Id
		
		INSERT INTO Treasury.Beneficiarios(IdBeneficiario, Codigo, RazonSocial, TipoBeneficiario, IdReferencia, IdBanco, CLABE, LeyendaCheque, DiasCredito, IdCuenta, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @RazonSocial, @TipoBeneficiario, @IdReferencia, @IdBanco, @CLABE, @LeyendaCheque, @DiasCredito, @IdCuenta, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Treasury.Beneficiarios SET Codigo=@Codigo, RazonSocial=@RazonSocial, TipoBeneficiario=@TipoBeneficiario, IdReferencia=@IdReferencia, IdBanco=@IdBanco, CLABE=@CLABE, LeyendaCheque=@LeyendaCheque, DiasCredito=@DiasCredito, IdCuenta=@IdCuenta, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdBeneficiario=@ID


