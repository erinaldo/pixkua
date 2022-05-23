-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 27-Dic-2005
-- Description:	Agrega o modifica la información de una empresa.
-- =============================================
CREATE  PROCEDURE [dbo].[EmpresasUPD]
	@Id AS int out,
	@Codigo AS varchar(10),
	@IdSucursal AS int, -- Parámetro de compatibilidad, no utilizado.
	@IdEmpresa as int, -- Parámetro de compatibilidad, no utilizado.
	@Nombre AS varchar(32),
	@NombreLargo AS varchar(64),
	@Logo AS image = NULL,
	@RFC AS varchar(16),
	@RazonSocial AS varchar(128),
	@Calle AS varchar(128),
	@NumExt AS varchar(16),
	@NumInt AS varchar(16),
	@Colonia AS varchar(128),
	@CP AS char(5),
	@IdPoblacion AS int,
	@FormatoContable as varchar(32),	
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @Id=0
	BEGIN
		EXEC dbo.NewKey 'Empresas', @Id out

		IF @Codigo='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.Empresas(IdEmpresa, Codigo, Nombre, NombreLargo, Logo,
			RFC, RazonSocial, Calle, NumExt, NumInt, Colonia, IdPoblacion, CP,
			IdStatus, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @NombreLargo, @Logo, 
			@RFC, @RazonSocial, @Calle, @NumExt, @NumInt, @Colonia, @IdPoblacion, @CP,
			@IdStatus, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE dbo.Empresas SET Codigo=@Codigo, Nombre=@Nombre, NombreLargo=@NombreLargo, Logo=@Logo,
			RFC=@RFC, RazonSocial=@RazonSocial, Calle=@Calle, NumExt=@NumExt, NumInt=@NumInt,
			Colonia=@Colonia, IdPoblacion=@IdPoblacion, CP=@CP,
			IdStatus=@IdStatus, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdEmpresa=@Id


