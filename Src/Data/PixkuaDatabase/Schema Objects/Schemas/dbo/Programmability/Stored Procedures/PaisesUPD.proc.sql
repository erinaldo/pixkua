-- =============================================
-- Author: RCO
-- Create date: 20-sep-2010
-- Description:	Agrega o modifica la información de Paises
-- =============================================
CREATE PROCEDURE [dbo].[PaisesUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Pais AS varchar(64),
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
		EXEC dbo.NewKey 'Paises', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.Paises(IdPais, Codigo, Pais, IdSucursal, IdStatus, LastUpdate, UserUpdate, PCUpdate)
		VALUES (@Id, @Codigo, @Pais, @IdSucursal, @IdStatus, @LastUpdate, @UserUpdate, @PCUpdate)
	END
	ELSE
		UPDATE dbo.Paises SET Codigo=@Codigo, Pais=@Pais, IdSucursal=@IdSucursal, IdStatus=@IdStatus, LastUpdate=@LastUpdate, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate
		WHERE IdPais=@ID


