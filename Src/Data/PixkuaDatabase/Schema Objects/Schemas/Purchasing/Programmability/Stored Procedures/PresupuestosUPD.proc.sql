-- =============================================
-- Author: alex Lopez
-- Create date: 02-nov-2011
-- Description:	Agrega o modifica la información de Presupuestos
-- =============================================
CREATE PROCEDURE [Purchasing].[PresupuestosUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@IdPeriodo AS int,
	@IdDepartamento AS int,
	@MontoPresupuesto AS decimal(19,4),
	--@MontoUtilizado AS decimal(19,4),
	--@MontoApartado AS decimal(19,4),
	@Estatus AS char(1),
	@IdStatus AS int,
	@IdSucursal AS int,
	@IdEmpresa AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON

	IF @IdEmpresa=0 
		SELECT @IdEmpresa=S.IdEmpresa FROM dbo.Sucursales S WHERE IdSucursal=@IdSucursal
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Purchasing.Presupuestos', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Purchasing.Presupuestos(IdPresupuesto, Codigo, IdPeriodo, IdDepartamento, MontoPresupuesto,/* MontoUtilizado, MontoApartado,*/ Estatus, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @IdPeriodo, @IdDepartamento, @MontoPresupuesto, /*@MontoUtilizado, @MontoApartado,*/ @Estatus, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Purchasing.Presupuestos 
			SET Codigo=@Codigo, IdPeriodo=@IdPeriodo, IdDepartamento=@IdDepartamento, MontoPresupuesto=@MontoPresupuesto, --MontoUtilizado=@MontoUtilizado, MontoApartado=@MontoApartado, 
				Estatus=@Estatus, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdPresupuesto=@ID


