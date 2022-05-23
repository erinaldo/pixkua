-- ====================================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 27-Dic-2005
-- Description:	Agrega o modifica la información de una sucursal
-- ====================================================
CREATE  PROCEDURE [dbo].[SucursalesUPD]
	@Id AS int out,
	@Codigo AS varchar(10),
	@IdSucursal AS int, -- Parámetro de compatibilidad, ignorado por la operación
	@IdEmpresa AS int, 
	@Nombre AS varchar(64),
	@NombreLargo AS varchar(128),
	@Tel1 AS varchar(32),
	@Tel2 AS varchar(32),
	@Fax AS varchar(32),
	@PagWeb AS varchar(128),
	@Correo AS varchar(128),
	@Calle AS varchar(64),
	@Colonia AS varchar(64),
	@CP AS varchar(5),
	@NumExt as varchar(16),
	@NumInt as varchar(16),
	@IdPoblacion AS int,
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @Id=0
	BEGIN
		EXEC dbo.NewKey 'Sucursales', @Id out
		
		IF @Codigo='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.Sucursales(Codigo, IdSucursal, IdEmpresa, Nombre, NombreLargo,
			Tel1, Tel2, Fax, PagWeb, Correo, Calle, Colonia, CP, NumExt, NumInt, IdPoblacion,
			IdStatus, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Codigo, @Id, @IdEmpresa, @Nombre, @NombreLargo,
			@Tel1, @Tel2, @Fax, @PagWeb, @Correo, @Calle, @Colonia, @CP, @NumExt, @NumInt, @IdPoblacion,
			@IdStatus, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE dbo.Sucursales SET IdEmpresa=@IdEmpresa, Nombre=@Nombre, 
			NombreLargo=@NombreLargo, Tel1=@Tel1, Tel2=@Tel2, Fax=@Fax, PagWeb=@PagWeb, Correo=@Correo,
			Calle=@Calle, Colonia=@Colonia, CP=@CP, NumExt=@NumExt, NumInt=@NumInt, IdPoblacion=@IdPoblacion,
			IdStatus=@IdStatus, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdSucursal=@Id


