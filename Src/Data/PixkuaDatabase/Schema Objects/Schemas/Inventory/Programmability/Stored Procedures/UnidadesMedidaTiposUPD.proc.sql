-- =============================================
-- Author: RCO
-- Create date: 05-oct-2010
-- Description:	Agrega o modifica la información de UnidadesMedidaTipos
-- =============================================
CREATE PROCEDURE [Inventory].[UnidadesMedidaTiposUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Nombre AS varchar(32),
	@IdStatus AS int,
	@IdSucursal AS int,
	@IdEmpresa as int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Inventory.UnidadesMedidaTipos', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Inventory.UnidadesMedidaTipos(IdUnidadMedidaTipo, Codigo, Nombre, 
			IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, 
			@IdStatus, @IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Inventory.UnidadesMedidaTipos SET Codigo=@Codigo, Nombre=@Nombre, 
			IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdUnidadMedidaTipo=@ID


