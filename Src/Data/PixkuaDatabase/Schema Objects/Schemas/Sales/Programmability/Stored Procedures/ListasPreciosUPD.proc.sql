-- =============================================
-- Author: alez Lopez
-- Create date: 16-ago-2011
-- Description:	Agrega o modifica la información de ListasPrecios
-- =============================================
CREATE PROCEDURE [Sales].[ListasPreciosUPD]
	@Id AS int out,
	@Codigo AS varchar(10),
	@Nombre AS varchar(128),
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
		EXEC dbo.NewKey 'Sales.ListasPrecios', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Sales.ListasPrecios(IdListaPrecio, Codigo, Nombre, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Sales.ListasPrecios SET Codigo=@Codigo, Nombre=@Nombre, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdListaPrecio=@ID


