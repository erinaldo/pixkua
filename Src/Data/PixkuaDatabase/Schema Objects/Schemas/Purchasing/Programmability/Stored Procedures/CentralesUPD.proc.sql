-- =============================================
-- Author: alez lopez
-- Create date: 19-oct-2011
-- Description:	Agrega o modifica la información de Centrales
-- =============================================
CREATE PROCEDURE [Purchasing].[CentralesUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(128),
	@IdZonaCompra as int,
	@IdCaja as int,
	@IdRemitente AS int,
	@IdOperador AS int,
	@EnviarOC AS bit,
	@NotificarOC AS bit,
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
		EXEC dbo.NewKey 'Purchasing.Centrales', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Purchasing.Centrales(IdCentral, Codigo, Nombre, IdZonaCompra, IdCaja, IdRemitente, IdOperador, EnviarOC, NotificarOC,IdCuenta, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdZonaCompra, @IdCaja, @IdRemitente, @IdOperador, @EnviarOC, @NotificarOC, @IdCuenta, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Purchasing.Centrales SET Codigo=@Codigo, Nombre=@Nombre, IdZonaCompra=@IdZonaCompra, IdCaja=@IdCaja, IdRemitente=@IdRemitente, IdOperador=@IdOperador, EnviarOC=@EnviarOC, NotificarOC=@NotificarOC, IdCuenta=@IdCuenta, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdCentral=@ID


