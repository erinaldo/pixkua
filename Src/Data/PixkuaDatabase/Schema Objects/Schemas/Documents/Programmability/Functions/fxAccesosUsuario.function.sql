CREATE FUNCTION [Documents].[fxAccesosUsuario](@IdUsuario as int)
RETURNS TABLE
AS
RETURN	(
	SELECT S.IdSucursal, W.IdDocumentoTipo AS IdTipo, S.IdStatus, S.[Status] AS Estatus, 
		IsNull(A.Aplicar,0) AS Aplicar, IsNull(A.Cancelar, 0) AS Cancelar, IsNull(A.Blocked, 0) AS Blocked
	FROM
		(
		SELECT S.IdStatus, S.Status, US.IdSucursal
		FROM Documents.Status S, dbo.UsuariosSucursales US 
		WHERE US.IdUsuario=1
		) AS S
	JOIN Documents.Workflow W 
		ON W.IdStatus=S.IdStatus
	LEFT JOIN
		(
		SELECT ISNULL(AU.IdSucursal, AG.IdSucursal) AS IdSucursal, 
			ISNULL(AU.IdTipo, AG.IdTipo) AS IdTipo, 
			ISNULL(AU.IdStatus, AG.IdStatus) AS IdStatus, 
			ISNULL(AU.Aplicar, AG.Aplicar) AS Aplicar,
			ISNULL(AU.Cancelar, AG.Cancelar) AS Cancelar,
			ISNULL(AG.Blocked, AU.Blocked) AS Blocked
		FROM (	
			SELECT A.IdSucursal, A.IdTipo, A.IdStatus, Aplicar, Cancelar,
				CAST (0 AS Bit) AS Blocked
			FROM Documents.AccesoUsuarios A 
			WHERE A.IdUsuario=@IdUsuario
			) AS AU
		FULL OUTER JOIN
			(
			SELECT US.IdSucursal, GP.IdTipo, GP.IdStatus, GP.Aplicar, GP.Cancelar,
				CAST (1 AS Bit) AS Blocked
			FROM Documents.AccesoGrupos GP JOIN dbo.UsuariosGrupos UG
				ON GP.IdGrupo=UG.IdGrupo
			JOIN UsuariosSucursales US 
				ON UG.IdUsuario=US.IdUsuario
			WHERE UG.IdUsuario=@IdUsuario
			) AS AG ON AU.IdSucursal=AG.IdSucursal AND AU.IdTipo=AG.IdTipo AND AU.IdStatus=AG.IdStatus
		) AS A	
		ON A.IdStatus=S.IdStatus AND A.IdTipo=W.IdDocumentoTipo AND S.IdSucursal=A.IdSucursal
		)


