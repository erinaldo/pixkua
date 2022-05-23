-- =============================================
-- Author: Alejandro Lopez Cadena
-- Create date: 20-sep-2007
-- Description:	Agrega o modifica la información de Cuentas
-- =============================================
CREATE PROCEDURE [Accounting].[CuentasUPD]
	@Id AS int out,
	@IdPadre AS int,
	@Codigo AS varchar(64),
	@Nombre AS varchar(128),
	@IdCuentaTipo AS int,
	@IdCuentaOrden AS int,
	@Orden AS int,
	@Nivel AS int,
	@Path AS varchar(128),
	@NamedPath AS varchar(1024),
	@IsLeaf AS bit,
	@IdStatus AS int,
	@IdEmpresa as int,
	@IdSucursal AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON

	
	DECLARE @ParentAnt AS int
	-- Preparar el orden de los nodos de la rama afectada
	EXEC Accounting.CuentasSortBranch @IdParent=@IdPadre, @InitPos=@Orden

	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Accounting.Cuentas', @ID out

		SET @ParentAnt=0

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Accounting.Cuentas(IdCuenta, IdPadre, Codigo, Nombre, IdCuentaTipo,IdCuentaOrden, Nivel, Orden,Path, NamedPath, IsLeaf, FechaUltMovto,
			IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @IdPadre, @Codigo, @Nombre, @IdCuentaTipo, @IdCuentaOrden, @Nivel,@Orden, @Path,@NamedPath, @IsLeaf, @LastUpdate,
			@IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
	BEGIN
		-- Obtener el nodo padre actual
		SELECT @ParentAnt=IdPadre FROM Accounting.Cuentas WHERE IdCuenta=@ID

		UPDATE Accounting.Cuentas SET IdPadre=@IdPadre, Codigo=@Codigo, Nombre=@Nombre, IdCuentaTipo=@IdCuentaTipo, IdCuentaOrden=@IdCuentaOrden,
			Nivel=@Nivel,Orden=@Orden, Path=@Path, NamedPath=@NamedPath, IsLeaf=@IsLeaf, 
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdCuenta=@ID
	END
	
	EXEC Accounting.CuentasRefresh @Id=@ID, @CompleteBranch=1


