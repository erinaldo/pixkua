-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Agrega o modifica la información de FormasPago
-- =============================================
CREATE PROCEDURE [Sales].[FormasPagoUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
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
		EXEC dbo.NewKey 'Sales.FormasPago', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Sales.FormasPago(IdFormaPago, Codigo, Nombre, IdCuenta,
			IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate, CreateDate, UserCreate)
		VALUES (@Id, @Codigo, @Nombre, @IdCuenta,
			@IdStatus, @IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate, @LastUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Sales.FormasPago SET Codigo=@Codigo, Nombre=@Nombre, IdCuenta=@IdCuenta,
			IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdFormaPago=@ID


