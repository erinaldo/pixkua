-- =============================================
-- Author: alez lopez
-- Create date: 04-mar-2011
-- Description:	Agrega o modifica la información de Insumos
-- =============================================
CREATE PROCEDURE [Production].[InsumosUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(128),
	@IdCuenta AS int,
	@IdUnidadMedidaTipo AS int,
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
		EXEC dbo.NewKey 'Production.Insumos', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Production.Insumos(IdInsumo, Codigo, Nombre, IdCuenta, IdUnidadMedidaTipo, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdCuenta, @IdUnidadMedidaTipo, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Production.Insumos SET Codigo=@Codigo, Nombre=@Nombre, IdCuenta=@IdCuenta, IdUnidadMedidaTipo=@IdUnidadMedidaTipo, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdInsumo=@ID


