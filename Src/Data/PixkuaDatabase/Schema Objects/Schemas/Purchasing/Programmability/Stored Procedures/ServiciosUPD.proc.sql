-- =============================================
-- Author: RCO
-- Create date: 02-nov-2011
-- Description:	Agrega o modifica la información de Servicios
-- =============================================
CREATE PROCEDURE [Purchasing].[ServiciosUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
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
		EXEC dbo.NewKey 'Purchasing.Servicios', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Purchasing.Servicios(IdServicio, Codigo, Nombre, CostoUltimo,
			IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, 0,
			@IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Purchasing.Servicios SET Codigo=@Codigo, Nombre=@Nombre,
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdServicio=@ID


