-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Agrega o modifica la información de Regiones
-- =============================================
CREATE PROCEDURE [Sales].[RegionesUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
	@IdSucursalCalendario AS int,
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
		EXEC dbo.NewKey 'Sales.Regiones', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Sales.Regiones(IdRegion, Codigo, Nombre, IdSucursalCalendario, 
			IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate, CreateDate, UserCreate)
		VALUES (@Id, @Codigo, @Nombre, @IdSucursalCalendario, 
			@IdStatus, @IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate, @LastUpdate, @UserUpdate)		
	END
	ELSE
		UPDATE Sales.Regiones SET Codigo=@Codigo, Nombre=@Nombre, IdSucursalCalendario=@IdSucursalCalendario, 
			IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdRegion=@ID


