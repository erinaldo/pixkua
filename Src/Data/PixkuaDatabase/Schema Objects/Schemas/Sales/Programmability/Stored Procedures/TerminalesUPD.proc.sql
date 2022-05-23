-- =============================================
-- Author: alez Lopez
-- Create date: 31-ago-2011
-- Description:	Agrega o modifica la información de Terminales
-- =============================================
CREATE PROCEDURE [Sales].[TerminalesUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Nombre AS varchar(64),
	@PC AS varchar(64),
	@IdCaja AS int,
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
		EXEC dbo.NewKey 'Sales.Terminales', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Sales.Terminales(IdTerminal, Codigo, Nombre, PC, IdCaja, IdCuenta, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @PC, @IdCaja, @IdCuenta, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Sales.Terminales SET Codigo=@Codigo, Nombre=@Nombre, PC=@PC, IdCaja=@IdCaja, IdCuenta=@IdCuenta, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdTerminal=@ID


