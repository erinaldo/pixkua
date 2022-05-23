-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Agrega o modifica la información de ZonasVenta
-- =============================================
CREATE PROCEDURE [Sales].[ZonasVentaUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
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
		EXEC dbo.NewKey 'Sales.ZonasVenta', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Sales.ZonasVenta(IdZonaVenta, Codigo, Nombre, 
			IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate, CreateDate, UserCreate)
		VALUES (@Id, @Codigo, @Nombre, 
			@IdStatus, @IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate, @LastUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Sales.ZonasVenta SET Codigo=@Codigo, Nombre=@Nombre, IdStatus=@IdStatus, IdSucursal=@IdSucursal, 
			IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdZonaVenta=@ID


