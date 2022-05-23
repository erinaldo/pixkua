-- =============================================
-- Author: alez lopez
-- Create date: 17-oct-2010
-- Description:	Agrega o modifica la información de VistasContablesTit
-- =============================================
CREATE PROCEDURE [Accounting].[VistasContablesTitUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Descripcion AS varchar(64),
	@Schema AS varchar(64),
	@Objeto AS varchar(64),
	@IdObjeto AS varchar(64),
	@Referencia AS varchar(64),
	@IdDocumentoTipo as int=0,
	@IdStatus AS int,
	@IdEmpresa AS int,
	@IdSucursal AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Accounting.VistasContablesTit', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Accounting.VistasContablesTit(IdVistaContableTit, Codigo, Descripcion, [Schema], Objeto, IdObjeto, Referencia,IdDocumentoTipo, IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Descripcion, @Schema, @Objeto, @IdObjeto, @Referencia,@IdDocumentoTipo, @IdStatus,@IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Accounting.VistasContablesTit SET Codigo=@Codigo, Descripcion=@Descripcion,[Schema]=@Schema, Objeto=@Objeto, IdObjeto=@IdObjeto, Referencia=@Referencia, IdDocumentoTipo=@IdDocumentoTipo, IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdVistaContableTit=@ID


