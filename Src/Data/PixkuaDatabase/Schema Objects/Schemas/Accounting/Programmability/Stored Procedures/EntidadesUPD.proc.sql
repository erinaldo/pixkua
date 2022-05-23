-- =============================================
-- Author: alex Lopez
-- Create date: 13-oct-2010
-- Description:	Agrega o modifica la información de Entidades
-- =============================================
CREATE PROCEDURE [Accounting].[EntidadesUPD]
	@Id AS int out,
	@Codigo AS varchar(1),
	@Entidad AS varchar(64),
	@Schema AS varchar(64),
	@Objeto AS varchar(64),
	@Alias AS varchar(5),
	@CampoPK AS varchar(32),
	@CampoName AS varchar(32),
	@IdStatus AS int,
	@IdSucursal AS int,
	@IdEmpresa as int,	
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Accounting.Entidades', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Accounting.Entidades(IdEntidad, Codigo, Entidad, [Schema],Objeto,Alias, CampoPK, CampoName,
			IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Entidad,@Schema,@Objeto,@Alias, @CampoPK, @CampoName,
			@IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Accounting.Entidades SET Codigo=@Codigo, Entidad=@Entidad, [Schema]=@Schema,Objeto=@Objeto,Alias=@Alias, CampoPK=@CampoPK, CampoName=@CampoName,
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdEntidad=@ID


