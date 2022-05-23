-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: <<FECHA>>
-- Description:	Agrega o modifica la información de Personas
-- =============================================
CREATE PROCEDURE [dbo].[PersonasUPD]
	@Id AS int out,
	@Codigo AS varchar(10),
	@IdSucursal AS int,
	@IdEmpresa as int,
	@Nombre AS varchar(128),
	@ApellidoP AS varchar(64),
	@ApellidoM AS varchar(64),
	@Calle AS varchar(64),
	@Colonia AS varchar(64),
	@CP AS varchar(5),
	@NumExt AS varchar(16),
	@NumInt AS varchar(16),
	@IdPoblacion AS int,
	@TelCasa AS varchar(64),
	@TelOficina AS varchar(50),
	@Celular AS varchar(50),
	@Correo AS varchar(50),
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@UserUpdate AS int,
	@PCUpdate AS varchar(32)
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Personas', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.Personas(IdPersona, Codigo, IdSucursal, Nombre, ApellidoP, ApellidoM, Calle, Colonia, CP, NumExt, NumInt, IdPoblacion, TelCasa, TelOficina, Celular, Correo, IdStatus, LastUpdate, UserUpdate, PCUpdate)
		VALUES (@Id, @Codigo, @IdSucursal, @Nombre, @ApellidoP, @ApellidoM, @Calle, @Colonia, @CP, @NumExt, @NumInt, @IdPoblacion, @TelCasa, @TelOficina, @Celular, @Correo, @IdStatus, @LastUpdate, @UserUpdate, @PCUpdate)

	END
	ELSE
		UPDATE dbo.Personas SET Codigo=@Codigo, IdSucursal=@IdSucursal, Nombre=@Nombre, 
			ApellidoP=@ApellidoP, ApellidoM=@ApellidoM, Calle=@Calle, Colonia=@Colonia, 
			CP=@CP, NumExt=@NumExt, NumInt=@NumInt, IdPoblacion=@IdPoblacion, TelCasa=@TelCasa, 
			TelOficina=@TelOficina, Celular=@Celular, Correo=@Correo, 
			IdStatus=@IdStatus, LastUpdate=@LastUpdate, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate
		WHERE IdPersona=@ID


