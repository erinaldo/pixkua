-- =============================================
-- Author: RCO
-- Create date: 05-oct-2010
-- Description:	Agrega o modifica la información de UnidadesMedida
-- =============================================
CREATE PROCEDURE [Inventory].[UnidadesMedidaUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Nombre AS varchar(32),
	@Abreviatura as varchar(16),
	@IdUnidadMedidaTipo AS int,
	@Base AS bit,
	@Factor AS decimal(19,6),
	@Fraccionable as bit,
	@IdStatus AS int,
	@IdSucursal AS int,
	@IdEmpresa as int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	-->Si esta marcada como unidad base, asegurarse que otra unidad no contenga la marca
	IF @Base=1
		UPDATE Inventory.UnidadesMedida SET Base=0
		WHERE IdUnidadMedidaTipo=@IdUnidadMedidaTipo
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Inventory.UnidadesMedida', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Inventory.UnidadesMedida(IdUnidadMedida, Codigo, Nombre, Abreviatura, IdUnidadMedidaTipo, Base, Factor, Fraccionable,
			IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate, CreateDate, UserCreate)
		VALUES (@Id, @Codigo, @Nombre, @Abreviatura, @IdUnidadMedidaTipo, @Base, @Factor, @Fraccionable,
			@IdStatus, @IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate, @LastUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Inventory.UnidadesMedida SET Codigo=@Codigo, Nombre=@Nombre, IdUnidadMedidaTipo=@IdUnidadMedidaTipo, 
			Base=@Base, Factor=@Factor, Abreviatura=@Abreviatura, Fraccionable=@Fraccionable,
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdUnidadMedida=@ID


