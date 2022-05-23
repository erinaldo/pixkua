CREATE PROCEDURE [Documents].[GrupoAccesosINS]
	@IdGrupo as int,
	@IdTipo as int,
	@IdStatus as int,
	@Aplicar as bit,
	@Cancelar as bit
AS
	SET NOCOUNT ON
	
	INSERT INTO Documents.AccesoGrupos (IdGrupo, IdTipo, IdStatus, Aplicar, Cancelar)
	VALUES (@IdGrupo, @IdTipo, @IdStatus, @Aplicar, @Cancelar)


