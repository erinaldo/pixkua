-- =============================================
-- Author: alex Lopez
-- Create date: 14-oct-2010
-- Description:	Agrega o modifica la información de Status
-- =============================================
CREATE PROCEDURE [Documents].[StatusUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Status AS varchar(64),
	@StatusApplied AS varchar(64),
	@IdStatus as int,
	@IdSucursal AS int,
	@IdEmpresa as int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	DECLARE @Activo as bit
	SET @Activo=@IdStatus
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Documents.Status', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		SET @IdStatus=@ID
		INSERT INTO Documents.Status(IdStatus_Homologar, Codigo, Status, StatusApplied, IdStatus, Activo, IdSucursal, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Status, @StatusApplied, @IdStatus, @Activo, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Documents.Status SET Codigo=@Codigo, Status=@Status, StatusApplied=@StatusApplied, Activo=@Activo, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdStatus_Homologar=@ID


