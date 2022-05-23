-- =============================================
-- Author: alexLopez
-- Create date: 15-oct-2010
-- Description:	Agrega o modifica la información de ContabilizacionDocumentosTit
-- =============================================
CREATE PROCEDURE [Accounting].[ContabilizacionDocumentosTitUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@IdDocumentoTipo AS int,
	@IdVistaContableTit AS int,
	@IdStatus AS int,
	@IdEmpresa as int,
	@IdSucursal AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Accounting.ContabilizacionDocumentosTit', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Accounting.ContabilizacionDocumentosTit(IdContabilizacionDocumentoTit, Codigo, IdDocumentoTipo, IdVistaContableTit, IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @IdDocumentoTipo, @IdVistaContableTit, @IdStatus,@IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Accounting.ContabilizacionDocumentosTit SET Codigo=@Codigo, IdDocumentoTipo=@IdDocumentoTipo, IdVistaContableTit=@IdVistaContableTit, IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdContabilizacionDocumentoTit=@ID


