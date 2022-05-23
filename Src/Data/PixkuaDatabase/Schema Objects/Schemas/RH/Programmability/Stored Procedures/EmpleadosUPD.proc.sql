-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Agrega o modifica la información de Empleados
-- =============================================
CREATE PROCEDURE [RH].[EmpleadosUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@IdPersona AS int,
	@CodigoChecador AS int,
	@NombreCorto AS varchar(32),
	@IdTurno AS int,
	@FechaInicio AS datetime,
	@Genero AS char(1),
	@Titulo AS varchar(64),
	@FechaIngreso AS datetime,
	--@FechaBaja AS datetime,
	@Sueldo AS decimal(19,4),
	@IdDepartamento AS int,
	@IdPuesto AS int,
	@FechaNacimiento AS datetime,
	@NSS AS varchar(32),
	@RFC AS char(15),
	@CURP AS char(32),
	@Foto AS image,
	@IdCuenta as int,
	@IdSucursal AS int,
	@IdEmpresa AS int,
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'RH.Empleados', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO RH.Empleados(IdEmpleado, Codigo, IdPersona, CodigoChecador, NombreCorto, IdTurno, 
			FechaInicio, Genero, Titulo, FechaIngreso, Sueldo, IdDepartamento, IdPuesto, 
			FechaNacimiento, NSS, RFC, CURP, Foto, IdCuenta,
			IdSucursal, IdEmpresa, IdStatus, LastUpdate, PCUpdate, UserUpdate, CreateDate, UserCreate)
		VALUES (@Id, @Codigo, @IdPersona, @CodigoChecador, @NombreCorto, @IdTurno, 
			@FechaInicio, @Genero, @Titulo, @FechaIngreso,  @Sueldo, @IdDepartamento, @IdPuesto, 
			@FechaNacimiento, @NSS, @RFC, @CURP, @Foto, @IdCuenta,
			@IdSucursal, @IdEmpresa, @IdStatus, @LastUpdate, @PCUpdate, @UserUpdate, @LastUpdate, @UserUpdate)
		
	END
	ELSE
		UPDATE RH.Empleados SET Codigo=@Codigo, IdPersona=@IdPersona, CodigoChecador=@CodigoChecador, 
			NombreCorto=@NombreCorto, IdTurno=@IdTurno, FechaInicio=@FechaInicio, Genero=@Genero, 
			Titulo=@Titulo, FechaIngreso=@FechaIngreso, Sueldo=@Sueldo, 
			IdDepartamento=@IdDepartamento, IdPuesto=@IdPuesto, FechaNacimiento=@FechaNacimiento, 
			NSS=@NSS, RFC=@RFC, CURP=@CURP, Foto=@Foto, IdCuenta=@IdCuenta,
			IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, IdStatus=@IdStatus, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdEmpleado=@ID


