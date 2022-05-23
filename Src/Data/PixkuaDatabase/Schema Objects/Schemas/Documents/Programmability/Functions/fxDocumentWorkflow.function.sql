-- =============================================
-- Author: Alejandro Lopez Cadena
-- ALTER  date: <<FECHA>>
-- Description:	Obtiene el flujo de trabajo por los que pasa el documento <<>>
-- Recibe el parametro de IdUsuario para implementar los permisos por usuario y 
-- retornar en la columna Allowed si el usuario tiene permiso a realizar ese cambio de status
-- =============================================
CREATE FUNCTION [Documents].[fxDocumentWorkflow](@IdSucursal as int, @IdDocumentoTipo AS int, @IdUsuario as int)
RETURNS TABLE
AS
	RETURN
		(
	SELECT @IdDocumentoTipo as IdDocumentoTipo, WF.IdStatus, WF.Secuencia, S.[Status], 
		S.StatusApplied,  A.Aplicar AS AllowApply, A.Cancelar AS AllowCancel
	FROM Documents.Workflow as WF
	INNER JOIN Documents.Status as S 
		ON S.IdStatus = WF.IdStatus
	LEFT JOIN (
			SELECT ISNULL(AU.IdSucursal, AG.IdSucursal) AS IdSucursal, 
				ISNULL(AU.IdTipo, AG.IdTipo) AS IdTipo, 
				ISNULL(AU.IdStatus, AG.IdStatus) AS IdStatus, 
				ISNULL(AG.Aplicar, AU.Aplicar) AS Aplicar,
				ISNULL(AG.Cancelar, AU.Cancelar) AS Cancelar
			FROM (	
				SELECT A.IdSucursal, A.IdTipo, A.IdStatus, Aplicar, Cancelar
				FROM Documents.AccesoUsuarios A 
				WHERE A.IdUsuario=@IdUsuario
				) AS AU
			FULL OUTER JOIN
				(
				SELECT US.IdSucursal, GP.IdTipo, GP.IdStatus, GP.Aplicar, GP.Cancelar
				FROM Documents.AccesoGrupos GP JOIN dbo.UsuariosGrupos UG
					ON GP.IdGrupo=UG.IdGrupo
				JOIN UsuariosSucursales US 
					ON UG.IdUsuario=US.IdUsuario
				WHERE UG.IdUsuario=@IdUsuario
			) AS AG
			ON AU.IdSucursal=AG.IdSucursal AND AU.IdTipo=AG.IdTipo AND AU.IdStatus=AG.IdStatus
		) AS A ON A.IdStatus=WF.IdStatus AND A.IdTipo=WF.IdDocumentoTipo
	WHERE WF.IdDocumentoTipo = @IdDocumentoTipo AND A.IdSucursal=@IdSucursal
		)


