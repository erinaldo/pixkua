-- =============================================
-- Author: RCO
-- Create date: 30-jun-2011
-- Description:	Agrega o modifica la información de ClasificacionesGrupos
-- =============================================
CREATE PROCEDURE [Sales].[ClasificacionesGruposUPD]
	@Id AS int out,
	@Codigo AS varchar(10),
	@Nombre AS varchar(64),
	@Requerido AS bit,
	@IdClasificacionEntidad AS int,
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
		EXEC dbo.NewKey 'Sales.ClasificacionesGrupos', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Sales.ClasificacionesGrupos(IdClasificacionGrupo, Codigo, Nombre, Requerido, IdClasificacionEntidad, 
			IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @Requerido, @IdClasificacionEntidad, 
			@IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Sales.ClasificacionesGrupos SET Codigo=@Codigo, Nombre=@Nombre, Requerido=@Requerido, IdClasificacionEntidad=@IdClasificacionEntidad, 
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdClasificacionGrupo=@ID


