-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Agrega o modifica la información de Puestos
-- =============================================
CREATE PROCEDURE [RH].[PuestosUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(128),
	@IdCuenta as int,
	@IdPadre AS int,
	@Orden AS int,
	@Nivel AS int,
	@Path AS varchar(64),
	@NamedPath AS varchar(1024),
	@IsLeaf AS bit,
	@IdStatus AS int,
	@IdSucursal AS int,
	@IdEmpresa AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	DECLARE @ParentAnt AS int
	-- Preparar el orden de los nodos de la rama afectada
	EXEC RH.PuestosSortBranch @IdParent=@IdPadre, @InitPos=@Orden

	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'RH.Puestos', @ID out

		SET @ParentAnt=0

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO RH.Puestos(IdPuesto, Codigo, Nombre, IdCuenta,
			IdPadre, Orden, Nivel, Path, NamedPath, IsLeaf, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdCuenta,
			@IdPadre, @Orden, @Nivel, @Path, @NamedPath, @IsLeaf, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
	BEGIN
		-- Obtener el nodo padre actual
		SELECT @ParentAnt=IdPadre FROM RH.Puestos WHERE IdPuesto=@ID

		UPDATE RH.Puestos SET Codigo=@Codigo, Nombre=@Nombre, IdCuenta=@IdCuenta,
			IdPadre=@IdPadre, Orden=@Orden, Nivel=@Nivel, Path=@Path, NamedPath=@NamedPath, IsLeaf=@IsLeaf, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdPuesto=@ID
	END
	
	EXEC RH.PuestosRefresh @Id=@Id, @CompleteBranch=1


