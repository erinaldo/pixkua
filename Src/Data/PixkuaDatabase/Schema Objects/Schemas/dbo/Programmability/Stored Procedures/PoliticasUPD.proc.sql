-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 05-Ene-2006
-- Description:	Agrega o modifica la información de Politicas
-- =============================================
CREATE PROCEDURE [dbo].[PoliticasUPD]
	@Id AS int out,
	@Codigo AS varchar(10),
	@IdSucursal AS int,
	@IdEmpresa as int,
	@IdProcesoForma AS int,
	@Politica AS varchar(64),
	@Control AS varchar(64),
	@Descripcion AS varchar(256),	
	@IdPoliticaTipo AS int,
	@Comportamiento as char(1),
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Politicas', @ID out
		
		IF @Codigo='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.Politicas(IdPolitica, IdSucursal, IdProcesoForma, Politica, 
			[Control], Descripcion, IdPoliticaTipo, Comportamiento,
			IdStatus, CreateDate, LastUpdate, PCUpdate, UserCreate, UserUpdate)
		VALUES (@Id, @IdSucursal, @IdProcesoForma, @Politica, 
			@Control, @Descripcion, @IdPoliticaTipo, @Comportamiento,
			@IdStatus, @LastUpdate, @LastUpdate, @PCUpdate, @UserUpdate, @UserUpdate)		
	END
	ELSE
		UPDATE dbo.Politicas SET IdSucursal=@IdSucursal, IdProcesoForma=@IdProcesoForma, Politica=@Politica, 
			[Control]=@Control, Descripcion=@Descripcion, IdPoliticaTipo=@IdPoliticaTipo, 
			Comportamiento=@Comportamiento,
			IdStatus=@IdStatus, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdPolitica=@ID


