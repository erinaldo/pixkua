-- =============================================
-- Author: alez lopez
-- Create date: 19-ene-2011
-- Description:	Agrega o modifica la información de CentrosProduccion
-- =============================================
CREATE PROCEDURE [Restaurant].[CentrosProduccionUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
	@IdImpresora AS int,
	@Imagen AS image=null,
	@IdLinea AS int,
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
		EXEC dbo.NewKey 'Restaurant.CentrosProduccion', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Restaurant.CentrosProduccion(IdCentroProduccion, Codigo, Nombre, IdImpresora, IdLinea, IdCuenta, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdImpresora, @IdLinea, @IdCuenta, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Restaurant.CentrosProduccion SET Codigo=@Codigo, Nombre=@Nombre, IdImpresora=@IdImpresora, IdLinea=@IdLinea, IdCuenta=@IdCuenta, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdCentroProduccion=@ID
		
		
	IF @Imagen IS NOT NULL 	
	   UPDATE Restaurant.CentrosProduccion SET Imagen=@Imagen WHERE IdCentroProduccion=@ID


