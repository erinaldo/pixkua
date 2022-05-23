-- =============================================
-- Author: RCO
-- Create date: 23-mar-2009
-- Description:	Agrega o modifica la información de Municipios
-- =============================================
CREATE PROCEDURE [dbo].[MunicipiosUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@IdEstado AS int,
	@Nombre AS varchar(64),
	@IdSucursal AS int,
	@IdEmpresa as int,
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@UserUpdate AS int,
	@PCUpdate AS varchar(32)
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Municipios', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.Municipios(IdMunicipio, Codigo, IdEstado, Nombre, IdSucursal, IdStatus, LastUpdate, UserUpdate, PCUpdate)
		VALUES (@Id, @Codigo, @IdEstado, @Nombre, @IdSucursal, @IdStatus, @LastUpdate, @UserUpdate, @PCUpdate)
	END
	ELSE
		UPDATE dbo.Municipios SET Codigo=@Codigo, IdEstado=@IdEstado, Nombre=@Nombre, IdSucursal=@IdSucursal, IdStatus=@IdStatus, LastUpdate=@LastUpdate, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate
		WHERE IdMunicipio=@ID


