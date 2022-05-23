CREATE PROCEDURE [Documents].[GrupoAccesosUPD]
	@IdGrupo as int,
	@IdTipo as int,
	@IdStatus as int,
	@Aplicar as bit,
	@Cancelar as bit
AS
	SET NOCOUNT ON
	
	IF EXISTS (SELECT IdGrupo FROM Documents.AccesoGrupos WHERE IdGrupo=@IdGrupo AND IdTipo=@IdTipo AND IdStatus=@IdStatus)
		UPDATE Documents.AccesoGrupos SET Aplicar=@Aplicar, Cancelar=@Cancelar
		WHERE IdGrupo=@IdGrupo AND IdTipo=@IdTipo AND IdStatus=@IdStatus		
	ELSE	
		INSERT INTO Documents.AccesoGrupos (IdGrupo, IdTipo, IdStatus, Aplicar, Cancelar)
		VALUES (@IdGrupo, @IdTipo, @IdStatus, @Aplicar, @Cancelar)


