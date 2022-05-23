-- =============================================
-- Author: alez lopez
-- Create date: 19-oct-2011
-- Description:	Agrega o modifica la información de CentrosRecepcion
-- =============================================
CREATE PROCEDURE [Purchasing].[CentrosRecepcionUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Nombre AS varchar(128),
	@IdCuenta AS int,
	@IdAlmacen AS int,
	@Calle AS varchar(64),
	@Colonia AS varchar(64),
	@CP AS varchar(5),
	@NumExt AS varchar(16),
	@NumInt AS varchar(16),
	@IdPoblacion AS int,
	@IdMunicipio AS int,
	@Tel1 AS varchar(32),
	@Tel2 AS varchar(32),
	@Fax AS varchar(32),
	@IdStatus AS int,
	@IdEmpresa AS int,
	@IdSucursal AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Purchasing.CentrosRecepcion', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
					
		INSERT INTO Purchasing.CentrosRecepcion(IdCentroRecepcion, Codigo, Nombre, IdCuenta, IdAlmacen, Calle, Colonia, CP, NumExt, NumInt, IdPoblacion, IdMunicipio, Tel1, Tel2, Fax, IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdCuenta, @IdAlmacen, @Calle, @Colonia, @CP, @NumExt, @NumInt, @IdPoblacion, @IdMunicipio, @Tel1, @Tel2, @Fax, @IdStatus, @IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Purchasing.CentrosRecepcion SET Codigo=@Codigo, Nombre=@Nombre, IdCuenta=@IdCuenta, IdAlmacen=@IdAlmacen, Calle=@Calle, Colonia=@Colonia, CP=@CP, NumExt=@NumExt, NumInt=@NumInt, IdPoblacion=@IdPoblacion, IdMunicipio=@IdMunicipio, Tel1=@Tel1, Tel2=@Tel2, Fax=@Fax, IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdCentroRecepcion=@ID


