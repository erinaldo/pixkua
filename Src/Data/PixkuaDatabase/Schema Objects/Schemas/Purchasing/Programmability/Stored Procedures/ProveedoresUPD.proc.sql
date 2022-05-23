-- =============================================
-- Author: RCO
-- Create date: 01-nov-2010
-- Description:	Agrega o modifica la información de Proveedores
-- =============================================
CREATE PROCEDURE [Purchasing].[ProveedoresUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Nombre AS varchar(128),
	@Calle AS varchar(64),
	@NumExt AS varchar(16),
	@NumInt AS varchar(16),
	@Colonia AS varchar(64),
	@CP AS char(5),
	@IdPoblacion AS int,
	@FacturaElectronica AS bit,
	@RFC AS varchar(16),
	@RazonSocial AS varchar(128),
	@CalleFIS AS varchar(128),
	@NumExtFIS AS varchar(16),
	@NumIntFIS AS varchar(16),
	@ColoniaFIS AS varchar(128),
	@CPFis AS char(5),
	@IdPoblacionFIS AS int,
	@Telefono AS varchar(16),
	@Fax AS varchar(16),
	@Correo AS varchar(128),
	@PagWeb AS varchar(256),
	@Saldo AS decimal(19,4),
	@LimiteCredito AS decimal(19,4),
	@DiasCredito AS int,
	@DiasEntrega AS int,
	@PagoAnticipado as bit,
	@PorcAnticipo as decimal(7,6),
	@IdCuenta AS int,
	@WebPassword AS varchar(16),
	@IdStatus AS int,
	@IdEmpresa as int,
	@IdSucursal AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Purchasing.Proveedores', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Purchasing.Proveedores(IdProveedor, Codigo, Nombre, Calle, NumExt, NumInt, Colonia, CP, IdPoblacion, 
			FacturaElectronica, RFC, RazonSocial, CalleFIS, NumExtFIS, NumIntFIS, ColoniaFIS, CPFis, IdPoblacionFIS, 
			Telefono, Fax, Correo, PagWeb, Saldo, LimiteCredito, DiasCredito, DiasEntrega, IdCuenta, WebPassword, 
			PagoAnticipado, PorcAnticipo,
			IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate, CreateDate, UserCreate)
		VALUES (@Id, @Codigo, @Nombre, @Calle, @NumExt, @NumInt, @Colonia, @CP, @IdPoblacion, 
			@FacturaElectronica, @RFC, @RazonSocial, @CalleFIS, @NumExtFIS, @NumIntFIS, @ColoniaFIS, @CPFis, @IdPoblacionFIS, 
			@Telefono, @Fax, @Correo, @PagWeb, @Saldo, @LimiteCredito, @DiasCredito, @DiasEntrega, @IdCuenta, @WebPassword, 
			@PagoAnticipado, @PorcAnticipo,
			@IdStatus, @IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate, @LastUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Purchasing.Proveedores SET Codigo=@Codigo, Nombre=@Nombre, Calle=@Calle, NumExt=@NumExt, NumInt=@NumInt, 
			Colonia=@Colonia, CP=@CP, IdPoblacion=@IdPoblacion, FacturaElectronica=@FacturaElectronica, RFC=@RFC, 
			RazonSocial=@RazonSocial, CalleFIS=@CalleFIS, NumExtFIS=@NumExtFIS, NumIntFIS=@NumIntFIS, ColoniaFIS=@ColoniaFIS, 
			CPFis=@CPFis, IdPoblacionFIS=@IdPoblacionFIS, Telefono=@Telefono, Fax=@Fax, Correo=@Correo, PagWeb=@PagWeb, 
			Saldo=@Saldo, LimiteCredito=@LimiteCredito, DiasCredito=@DiasCredito, DiasEntrega=@DiasEntrega, 
			PagoAnticipado=@PagoAnticipado, PorcAnticipo=@PorcAnticipo, IdCuenta=@IdCuenta, WebPassword=@WebPassword, 
			IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdProveedor=@ID


