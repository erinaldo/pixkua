-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 10-Mar-2006
-- Description:	Agrega o modifica la información de Catalogos
-- =============================================
CREATE PROCEDURE [dbo].[CatalogosUPD]
	@Id AS int out,
	@IdSucursal AS int,
	@IdEmpresa as int,
	@Codigo AS varchar(10)='',
	@IdProceso AS int,
	@KeyMode AS char(1),
	@SearchMode AS char(1),
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Catalogos', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.Catalogos(IdCatalogo, IdSucursal, IdProceso, KeyMode, SearchMode, IdStatus, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @IdSucursal, @IdProceso, @KeyMode, @SearchMode, @IdStatus, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE dbo.Catalogos SET IdSucursal=@IdSucursal, IdProceso=@IdProceso, KeyMode=@KeyMode, SearchMode=@SearchMode, IdStatus=@IdStatus, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdCatalogo=@ID


