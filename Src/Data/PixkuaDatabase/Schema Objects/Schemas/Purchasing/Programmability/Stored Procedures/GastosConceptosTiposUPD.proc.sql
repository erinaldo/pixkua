-- =============================================
-- Author: alex Lopez
-- Create date: 15-nov-2011
-- Description:	Agrega o modifica la información de GastosConceptosTipos
-- =============================================
CREATE PROCEDURE [Purchasing].[GastosConceptosTiposUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Nombre AS varchar(128),
	@IdCuenta AS int,
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
		EXEC dbo.NewKey 'Purchasing.GastosConceptosTipos', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Purchasing.GastosConceptosTipos(IdGastoConceptoTipo, Codigo, Nombre, IdCuenta, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdCuenta, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Purchasing.GastosConceptosTipos SET Codigo=@Codigo, Nombre=@Nombre, IdCuenta=@IdCuenta, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdGastoConceptoTipo=@ID


