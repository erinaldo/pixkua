-- =============================================
-- Author: alex Lopez
-- Create date: 02-dic-2011
-- Description:	Agrega o modifica la información de Chequeras
-- =============================================
CREATE PROCEDURE [Treasury].[ChequerasUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
	@IdBanco AS int,
	@Cuenta AS varchar(32),
	@IdCaja AS int,
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
		EXEC dbo.NewKey 'Treasury.Chequeras', @ID out

		IF LTrim(@Codigo)='0' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Treasury.Chequeras(IdChequera, Codigo, Nombre, IdBanco, Cuenta, IdCaja, IdCuenta, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdBanco, @Cuenta, @IdCaja, @IdCuenta, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Treasury.Chequeras SET Codigo=@Codigo, Nombre=@Nombre, IdBanco=@IdBanco, Cuenta=@Cuenta, IdCaja=@IdCaja, IdCuenta=@IdCuenta, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdChequera=@ID


