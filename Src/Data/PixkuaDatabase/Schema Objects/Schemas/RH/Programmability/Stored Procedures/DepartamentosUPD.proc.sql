-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Agrega o modifica la información de Departamentos
-- =============================================
CREATE PROCEDURE [RH].[DepartamentosUPD]
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
	EXEC RH.DepartamentosSortBranch @IdParent=@IdPadre, @InitPos=@Orden

	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'RH.Departamentos', @ID out

		SET @ParentAnt=0

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO RH.Departamentos(IdDepartamento, Codigo, Nombre, IdCuenta, IdPadre, 
			Orden, Nivel, [Path], NamedPath, IsLeaf, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdCuenta, @IdPadre, 
			@Orden, @Nivel, @Path, @NamedPath, @IsLeaf, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)		
	END
	ELSE
	BEGIN
		-- Obtener el nodo padre actual
		SELECT @ParentAnt=IdPadre FROM RH.Departamentos WHERE IdDepartamento=@ID

		UPDATE RH.Departamentos SET Codigo=@Codigo, Nombre=@Nombre, IdCuenta=@IdCuenta,
			IdPadre=@IdPadre, Orden=@Orden, Nivel=@Nivel, Path=@Path, NamedPath=@NamedPath, IsLeaf=@IsLeaf, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdDepartamento=@ID
	END
	
	EXEC RH.DepartamentosRefresh @Id=@Id, @CompleteBranch=1


