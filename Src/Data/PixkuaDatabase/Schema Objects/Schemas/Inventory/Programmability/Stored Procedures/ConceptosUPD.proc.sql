-- =============================================
-- Author: RCO
-- Create date: 13-oct-2010
-- Description:	Agrega o modifica la información de Conceptos
-- =============================================
CREATE PROCEDURE [Inventory].[ConceptosUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Nombre AS varchar(64),
	@Tipo AS char(1),
	@IdConceptoClasificacion as int,
	@IdDocumentoTipo AS int,
	@Automatico AS bit,
	@DiasVigencia AS int,
	@IdCuenta as int,
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
		EXEC dbo.NewKey 'Inventory.Conceptos', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Inventory.Conceptos(IdConcepto, Codigo, Nombre, Tipo, IdConceptoClasificacion, IdDocumentoTipo, Automatico, DiasVigencia, IdCuenta,
			IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate, CreateDate, UserCreate)
		VALUES (@Id, @Codigo, @Nombre, @Tipo, @IdConceptoClasificacion, @IdDocumentoTipo, @Automatico, @DiasVigencia, @IdCuenta,
			@IdStatus, @IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate, @LastUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Inventory.Conceptos SET Codigo=@Codigo, Nombre=@Nombre, Tipo=@Tipo, IdDocumentoTipo=@IdDocumentoTipo, 
			Automatico=@Automatico, DiasVigencia=@DiasVigencia, IdConceptoClasificacion=@IdConceptoClasificacion, IdCuenta=@IdCuenta,
			IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdConcepto=@ID


