CREATE FUNCTION [Documents].[fxAccesosGrupo](@IdGrupo as int)
RETURNS TABLE
AS
RETURN	(

	SELECT W.IdDocumentoTipo AS IdTipo, S.IdStatus, S.[Status] AS Estatus,
		IsNull(A.Aplicar,0) AS Aplicar, IsNull(A.Cancelar, 0) AS Cancelar	
	FROM Documents.[Status] S JOIN Documents.Workflow W
		ON S.IdStatus=W.IdStatus
	LEFT JOIN 
			(
			SELECT IdTipo, IdStatus, Aplicar, Cancelar
			FROM Documents.AccesoGrupos A 		
			WHERE IdGrupo=@IdGrupo
			) AS A
		ON A.IdStatus=S.IdStatus AND A.IdTipo=W.IdDocumentoTipo
		)


