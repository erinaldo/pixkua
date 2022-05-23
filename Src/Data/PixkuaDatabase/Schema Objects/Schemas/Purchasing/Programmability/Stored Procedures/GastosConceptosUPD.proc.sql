-- =============================================
-- Author: alex Lopez
-- Create date: 15-nov-2011
-- Description:	Agrega o modifica la información de GastosConceptos
-- =============================================
CREATE PROCEDURE [Purchasing].[GastosConceptosUPD]
	@Id AS int out,
	@Nombre AS varchar(128),
	@IdGastoConceptoTipo as int,
	@IdCategoriaPresupuestal AS int,
	@IdCuenta AS int,
	@IdSucursal AS int,
	@IdEmpresa AS int,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	DECLARE @Codigo as varchar(64),@LastUpdate AS datetime
	SELECT @Codigo=LTrim(Str(@Id)),@LastUpdate =GETDATE()
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Purchasing.GastosConceptos', @ID out

		SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Purchasing.GastosConceptos(IdGastoConcepto, Codigo, Nombre, IdGastoConceptoTipo, IdCategoriaPresupuestal, IdCuenta, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdGastoConceptoTipo, @IdCategoriaPresupuestal, @IdCuenta, 1, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Purchasing.GastosConceptos SET Nombre=@Nombre, IdGastoConceptoTipo=@IdGastoConceptoTipo, IdCategoriaPresupuestal=@IdCategoriaPresupuestal, IdCuenta=@IdCuenta, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdGastoConcepto=@ID


