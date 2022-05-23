-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: <<FECHA>>
-- Description:	Agrega o modifica la información de Poblaciones
-- =============================================
CREATE PROCEDURE [dbo].[PoblacionesUPD]
	@Id AS int out,
	@Codigo AS varchar(50),
	@IdSucursal AS int,
	@IdEmpresa as int,
	@IdMunicipio AS int,
	@Poblacion AS varchar(32),
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@UserUpdate AS int,
	@PCUpdate AS varchar(32)
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Poblaciones', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.Poblaciones(IdPoblacion, Codigo, IdSucursal, IdMunicipio, Poblacion, IdStatus, LastUpdate, UserUpdate, PCUpdate)
		VALUES (@Id, @Codigo, @IdSucursal, @IdMunicipio, @Poblacion, @IdStatus, @LastUpdate, @UserUpdate, @PCUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE dbo.Poblaciones SET Codigo=@Codigo, IdSucursal=@IdSucursal, IdMunicipio=@IdMunicipio, Poblacion=@Poblacion, 
			IdStatus=@IdStatus, LastUpdate=@LastUpdate, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate
		WHERE IdPoblacion=@ID


