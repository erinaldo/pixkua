-- =============================================
-- Author: alex Lopez
-- Create date: 09-oct-2010
-- Description:	Agrega o modifica la información de PolizasPerfiles
-- =============================================
CREATE PROCEDURE [Accounting].[PolizasPerfilesUPD]
	@Id AS int out,
	@Codigo AS varchar(1),
	@Descripcion AS varchar(64),
	@IdPolizaOrigen AS int,
	@IdPolizaTipo AS int,
	@IdPolizaSumarizacion AS int,
	@Acumulable AS bit,
	@IdVistaContableTit as int,
	@AfectarSistemaExterno AS bit,
	@IdDocumentoTipo AS int,
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
		EXEC dbo.NewKey 'Accounting.PolizasPerfiles', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Accounting.PolizasPerfiles(IdPolizaPerfil, Codigo, Descripcion, IdPolizaOrigen, 
			IdPolizaTipo, IdPolizaSumarizacion, Acumulable, AfectarSistemaExterno, IdDocumentoTipo, IdVistaContableTit, 
			IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Descripcion, @IdPolizaOrigen, 
			@IdPolizaTipo, @IdPolizaSumarizacion, @Acumulable, @AfectarSistemaExterno, @IdDocumentoTipo, @IdVistaContableTit,
			@IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Accounting.PolizasPerfiles SET Codigo=@Codigo, Descripcion=@Descripcion, IdPolizaOrigen=@IdPolizaOrigen, 
			IdPolizaTipo=@IdPolizaTipo, IdPolizaSumarizacion=@IdPolizaSumarizacion, Acumulable=@Acumulable, 
			AfectarSistemaExterno=@AfectarSistemaExterno, IdDocumentoTipo=@IdDocumentoTipo, IdVistaContableTit = @IdVistaContableTit, 
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdPolizaPerfil=@ID


