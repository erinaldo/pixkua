-- =============================================
-- Author: alez Lopez
-- Create date: 30-jun-2011
-- Description:	Agrega o modifica la información de Cajas
-- =============================================
CREATE PROCEDURE [Sales].[CajasUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
	@IdCuenta AS int,
	@IdImpresora AS int,
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
		EXEC dbo.NewKey 'Sales.Cajas', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Sales.Cajas(IdCaja, Codigo, Nombre, IdCuenta, IdImpresora, 
			IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdCuenta, @IdImpresora, 
			@IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)		
	END
	ELSE
		UPDATE Sales.Cajas SET Codigo=@Codigo, Nombre=@Nombre, IdCuenta=@IdCuenta, 
			IdImpresora=@IdImpresora, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdCaja=@ID


