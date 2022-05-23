-- =============================================
-- Author: RCO
-- Create date: 06-sep-2010
-- Description:	Agrega o modifica la información de Clientes
-- =============================================
CREATE PROCEDURE [Sales].[ClientesUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(128),
	@Calle AS varchar(128),
	@Cruce1 AS varchar(128),
	@Cruce2 AS varchar(128),
	@NumExt AS varchar(16),
	@NumInt AS varchar(16),
	@Colonia AS varchar(128),
	@CP AS char(5),
	@IdPoblacion AS int,
	@Latitud as real,
	@Longitud as real,
	@Telefonos AS varchar(64),
	@Fax AS varchar(16),
	@Correo AS varchar(128),
	@PagWeb AS varchar(256),
	@IdListaPrecio AS int,
	@IdGrupoDescuentos AS int,
	@IdGama AS int,
	@CondicionesPago as char(1),
	@LimiteCredito AS decimal(19,4),
	@DiasCredito AS int,
	@IdCuentaContable AS int,
	@Facturable AS bit,
	@FacturacionAnticipada as bit,
	@RFC AS varchar(16),
	@RazonSocial AS varchar(256),
	@CalleFIS AS varchar(128),
	@NumExtFIS AS varchar(16),
	@NumIntFIS AS varchar(16),
	@ColoniaFIS AS varchar(128),
	@CPFis AS char(5),
	@IdPoblacionFIS AS int,
	@WebPassword AS varchar(16),
	@IdComprobanteAddenda AS int,
	@IdComprobanteDestino as int,
	@GLN AS varchar(32),
	@GLNTienda AS varchar(32),
	@NumProveedor AS int,
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
		EXEC dbo.NewKey 'Sales.Clientes', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Sales.Clientes(IdCliente, Codigo, Nombre, Calle, Cruce1, Cruce2, NumExt, NumInt, 
			Colonia, CP, IdPoblacion, Latitud, Longitud, Telefonos, Fax, Correo, PagWeb, IdListaPrecio, 
			IdGrupoDescuentos, IdGama, CondicionesPago, LimiteCredito, DiasCredito, IdCuenta, 
			Facturable, FacturacionAnticipada, RFC, RazonSocial, CalleFIS, NumExtFIS, NumIntFIS, 
			ColoniaFIS, CPFis, IdPoblacionFIS, WebPassword, IdComprobanteAddenda, IdComprobanteDestino, GLN, 
			GLNTienda, NumProveedor, 
			IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate, CreateDate, UserCreate)
		VALUES (@Id, @Codigo, @Nombre, @Calle, @Cruce1, @Cruce2, @NumExt, @NumInt, 
			@Colonia, @CP, @IdPoblacion, @Latitud, @Longitud, @Telefonos, @Fax, @Correo, @PagWeb, @IdListaPrecio, 
			@IdGrupoDescuentos, @IdGama, @CondicionesPago, @LimiteCredito, @DiasCredito, @IdCuentaContable, 
			@Facturable, @FacturacionAnticipada, @RFC, @RazonSocial, @CalleFIS, @NumExtFIS, @NumIntFIS, 
			@ColoniaFIS, @CPFis, @IdPoblacionFIS, @WebPassword, @IdComprobanteAddenda, @IdComprobanteDestino, @GLN, 
			@GLNTienda, @NumProveedor, 
			@IdStatus, @IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate, @LastUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Sales.Clientes SET Codigo=@Codigo, Nombre=@Nombre, Calle=@Calle, Cruce1=@Cruce1, 
			Cruce2=@Cruce2, NumExt=@NumExt, NumInt=@NumInt, Colonia=@Colonia, CP=@CP, 
			IdPoblacion=@IdPoblacion, Latitud=@Latitud, Longitud=@Longitud, Telefonos=@Telefonos, 
			Fax=@Fax, Correo=@Correo, PagWeb=@PagWeb, IdListaPrecio=@IdListaPrecio, 
			IdGrupoDescuentos=@IdGrupoDescuentos, IdGama=@IdGama, CondicionesPago=@CondicionesPago,
			LimiteCredito=@LimiteCredito, DiasCredito=@DiasCredito, IdCuenta=@IdCuentaContable, 
			Facturable=@Facturable, FacturacionAnticipada=@FacturacionAnticipada, RFC=@RFC, 
			RazonSocial=@RazonSocial, CalleFIS=@CalleFIS, NumExtFIS=@NumExtFIS, NumIntFIS=@NumIntFIS, 
			ColoniaFIS=@ColoniaFIS, CPFis=@CPFis, IdPoblacionFIS=@IdPoblacionFIS, 
			WebPassword=@WebPassword, IdComprobanteAddenda=@IdComprobanteAddenda, IdComprobanteDestino=@IdComprobanteDestino,
			GLN=@GLN, GLNTienda=@GLNTienda, NumProveedor=@NumProveedor, 
			IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdCliente=@ID


