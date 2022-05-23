-- =============================================
-- Author: RCO
-- Create date: 01-nov-2011
-- Description:	Agrega o modifica la información de ZonasCompra
-- =============================================
CREATE PROCEDURE [Purchasing].[ZonasCompraUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
	@IdStatus AS int,
	@IdEmpresa AS int,
	@IdSucursal AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Purchasing.ZonasCompra', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Purchasing.ZonasCompra(IdZonaCompra, Codigo, Nombre, 
			IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, 
			@IdStatus, @IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate)		
	END
	ELSE
		UPDATE Purchasing.ZonasCompra SET Codigo=@Codigo, Nombre=@Nombre, 
			IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdZonaCompra=@ID


