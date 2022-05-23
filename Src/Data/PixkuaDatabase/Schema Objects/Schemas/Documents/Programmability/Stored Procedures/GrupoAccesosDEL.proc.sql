CREATE PROCEDURE [Documents].[GrupoAccesosDEL]
	@IdGrupo as int,
	@IdTipo as int,
	@IdStatus as int
AS
	DELETE Documents.AccesoGrupos
	WHERE IdGrupo=@IdGrupo AND IdTipo=@IdTipo 
		AND IdStatus=@IdStatus


