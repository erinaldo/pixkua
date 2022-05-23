-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Agrega o modifica la información de Servicios
-- =============================================
CREATE PROCEDURE [Sales].[ServiciosUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
	@IdEstCom AS int,
	@IdCategoriaFlujo AS int,
	@ConceptoLibre AS bit,
	@IdCuenta as int,
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
		EXEC dbo.NewKey 'Sales.Servicios', @ID out

		IF LTrim(@Codigo)=''
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Sales.Servicios(IdServicio, Codigo, Nombre, IdEstCom, IdCategoriaFlujo, ConceptoLibre, IdCuenta,
			IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdEstCom, @IdCategoriaFlujo, @ConceptoLibre, @IdCuenta,
			@IdStatus, @IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate)		
	END
	ELSE
		UPDATE Sales.Servicios SET Codigo=@Codigo, Nombre=@Nombre, IdEstCom=@IdEstCom, 
			IdCategoriaFlujo=@IdCategoriaFlujo, ConceptoLibre=@ConceptoLibre, IdCuenta=@IdCuenta,
			IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdServicio=@ID


