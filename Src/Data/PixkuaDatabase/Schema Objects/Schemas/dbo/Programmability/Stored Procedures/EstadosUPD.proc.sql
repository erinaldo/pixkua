-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: <<FECHA>>
-- Description:	Agrega o modifica la información de Estados
-- =============================================
CREATE PROCEDURE [dbo].[EstadosUPD]
	@Id AS int out,
	@Codigo AS varchar(50),
	@IdSucursal AS int,
	@IdEmpresa as int,
	@IdPais as int,
	@Estado AS varchar(32),
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@UserUpdate AS int,
	@PCUpdate AS varchar(32)
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Estados', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.Estados(IdEstado, Codigo, IdSucursal, Estado, IdPais,
			IdStatus, LastUpdate, UserUpdate, PCUpdate)
		VALUES (@Id, @Codigo, @IdSucursal, @Estado, @IdPais,
			@IdStatus, @LastUpdate, @UserUpdate, @PCUpdate)
	END
	ELSE
		UPDATE dbo.Estados SET Codigo=@Codigo, IdSucursal=@IdSucursal, Estado=@Estado, IdPais=@IdPais,
			IdStatus=@IdStatus, LastUpdate=@LastUpdate, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate
		WHERE IdEstado=@ID


