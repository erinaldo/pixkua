-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Agrega o modifica la información de EstCom
-- =============================================
CREATE PROCEDURE [Sales].[EstComUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(128),
	@IdPadre AS int,
	@Orden AS int,
	@Nivel AS int,
	@Path AS varchar(64),
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
	EXEC Sales.EstComSortBranch @IdParent=@IdPadre, @InitPos=@Orden

	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Sales.EstCom', @ID out

		SET @ParentAnt=0

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Sales.EstCom(IdEstCom, Codigo, Nombre, IdPadre, Orden, Nivel, [Path], NamedPath, 
			IsLeaf, IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate, CreateDate, UserCreate)
		VALUES (@Id, @Codigo, @Nombre, @IdPadre, @Orden, @Nivel, @Path, @NamedPath, 
			@IsLeaf, @IdStatus, @IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate, @LastUpdate, @UserUpdate)		
	END
	ELSE
	BEGIN
		-- Obtener el nodo padre actual
		SELECT @ParentAnt=IdPadre FROM Sales.EstCom WHERE IdEstCom=@ID

		UPDATE Sales.EstCom SET Codigo=@Codigo, Nombre=@Nombre, IdPadre=@IdPadre, Orden=@Orden, 
			Nivel=@Nivel, Path=@Path, NamedPath=@NamedPath, IsLeaf=@IsLeaf, 
			IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdEstCom=@ID
	END
	
	EXEC Sales.EstComRefresh @Id=@Id, @CompleteBranch=1


