-- =============================================
-- Author: RCO
-- Create date: 04-abr-2011
-- Description:	Agrega o modifica la información de NotasConceptos
-- =============================================
CREATE PROCEDURE [Accounting].[NotasConceptosUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(128),
	@IdCuenta AS int,
	@ConceptoLibre AS bit,
	@IdStatus AS int,
	@IdSucursal AS int,
	@IdEmpresa AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Accounting.NotasConceptos', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Accounting.NotasConceptos(IdNotaConcepto, Codigo, Nombre, IdCuenta, ConceptoLibre, 
			IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate, CreateDate, UserCreate)
		VALUES (@Id, @Codigo, @Nombre, @IdCuenta, @ConceptoLibre, 
			@IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate, @LastUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Accounting.NotasConceptos SET Codigo=@Codigo, Nombre=@Nombre, IdCuenta=@IdCuenta, ConceptoLibre=@ConceptoLibre, 
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdNotaConcepto=@ID


