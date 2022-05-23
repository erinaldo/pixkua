-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: <<FECHA>>
-- Description:	Agrega o modifica la información de GruposUsr
-- =============================================
CREATE PROCEDURE [dbo].[GruposUsrUPD]
	@Id AS int out,
	@Codigo AS varchar(10),
	@Grupo AS varchar(64),
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
		EXEC dbo.NewKey 'GruposUsr', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.GruposUsr(IdGrupo, Codigo, Grupo, IdSucursal, IdEmpresa,
			IdStatus, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Grupo, @IdSucursal, @IdEmpresa,
			@IdStatus, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE dbo.GruposUsr SET Codigo=@Codigo, Grupo=@Grupo, IdSucursal=@IdSucursal, IdStatus=@IdStatus, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdGrupo=@ID


