-- =============================================
-- Author: Victor Moreno
-- Create date: 01-dic-2016
-- Description:	Agrega o modifica la información de OrdenesTrabajo
-- =============================================
create PROCEDURE Production.OrdenesTrabajoUPD
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
	@Fecha AS datetime,
	@IdArticuloStock AS int,
	@CantDeseada AS decimal(19,4),
	@CantRecibida AS decimal(19,4),
	@Version AS int,
	@IdOrdenTrabajoTipo AS int,
	@FechaPromEntrega AS datetime,
	@FechaRecepcion as datetime,
	--@HoraAplicado AS datetime,
	--@HoraCierre AS datetime,
	@EntregasParciales AS bit,
	@ExigirRecepcion AS bit,
	@Observaciones AS varchar(256),
	@IdCuenta AS int,
	@IdAlmacenInsumos as int,
	@IdAlmacenPT as int,
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
		EXEC dbo.NewKey 'Production.OrdenesTrabajo', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo = 'OT-' + LTrim(Str(@Id))
		
		INSERT INTO Production.OrdenesTrabajo(IdOrdenTrabajo, Codigo, Nombre, Fecha, IdArticuloStock, CantDeseada, CantRecibida, Version, IdOrdenTrabajoTipo, FechaPromEntrega, FechaRecepcion, EntregasParciales, ExigirRecepcion, Observaciones, IdCuenta, IdAlmacenInsumos, IdAlmacenPT, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @Fecha, @IdArticuloStock, @CantDeseada, @CantRecibida, @Version, @IdOrdenTrabajoTipo, @FechaPromEntrega, @FechaRecepcion, @EntregasParciales, @ExigirRecepcion, @Observaciones, @IdCuenta, @IdAlmacenInsumos, @IdAlmacenPT, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Production.OrdenesTrabajo SET  Nombre=@Nombre, IdArticuloStock=@IdArticuloStock, CantDeseada=@CantDeseada, CantRecibida=@CantRecibida, Version=@Version, IdOrdenTrabajoTipo=@IdOrdenTrabajoTipo, FechaPromEntrega=@FechaPromEntrega, FechaRecepcion=@FechaRecepcion, EntregasParciales=@EntregasParciales, ExigirRecepcion=@ExigirRecepcion, Observaciones=@Observaciones, IdCuenta=@IdCuenta, IdAlmacenInsumos=@IdAlmacenInsumos , IdAlmacenPT = @IdAlmacenPT , IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdOrdenTrabajo=@ID