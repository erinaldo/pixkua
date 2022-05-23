-- =============================================
-- Author: Victor Moreno
-- Create date: 07-nov-2016
-- Description:	Agrega o modifica la información de IncidenciasTipos
-- =============================================
CREATE PROCEDURE Production.IncidenciasTiposUPD
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
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
		EXEC dbo.NewKey 'Production.IncidenciasTipos', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Production.IncidenciasTipos(IdIncidenciaTipo, Codigo, Nombre, IdCuenta, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdCuenta, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Production.IncidenciasTipos SET Codigo=@Codigo, Nombre=@Nombre, IdCuenta=@IdCuenta, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdIncidenciaTipo=@ID