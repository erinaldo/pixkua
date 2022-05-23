-- =============================================
-- Author: alex opez
-- Create date: 13-oct-2010
-- Description:	Agrega o modifica la información de Tipos
-- =============================================
CREATE PROCEDURE [Documents].[TiposUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
	@IdSucursal AS int,
	@IdEmpresa as int,	
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Documents.Tipos', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Documents.Tipos(IdDocumentoTipo, Codigo, Nombre, IdSucursal, IdStatus, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdSucursal, @IdStatus, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Documents.Tipos SET Codigo=@Codigo, Nombre=@Nombre, IdSucursal=@IdSucursal, IdStatus=@IdStatus, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdDocumentoTipo=@ID


