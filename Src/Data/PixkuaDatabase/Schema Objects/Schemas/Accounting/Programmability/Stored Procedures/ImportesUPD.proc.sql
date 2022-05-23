-- =============================================
-- Author: alez Lopez
-- Create date: 18-oct-2010
-- Description:	Agrega o modifica la información de Importes
-- =============================================
CREATE PROCEDURE [Accounting].[ImportesUPD]
	@Id AS int out,
	@Codigo AS varchar(1),
	@Descripcion AS varchar(64),
	@Importe AS varchar(32),
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
		EXEC dbo.NewKey 'Accounting.Importes', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Accounting.Importes(IdImporte, Codigo, Descripcion, Importe, 
			IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Descripcion, @Importe, 
			@IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Accounting.Importes SET Codigo=@Codigo, Descripcion=@Descripcion, Importe=@Importe, 
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdImporte=@ID


