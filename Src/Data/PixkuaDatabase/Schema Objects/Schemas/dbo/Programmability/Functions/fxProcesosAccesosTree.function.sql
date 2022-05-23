-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 02-Jun-2006
-- Description:	Obtiene la lista de procesos a las que un usuario tiene acceso
-- =============================================
CREATE  function [dbo].[fxProcesosAccesosTree](@IdUsuario int, @IdSucursal AS int) 
RETURNS Table
AS
RETURN(select P.IdProceso, P.Proceso, P.IdModulo, P.Descr, P.IdProcesoTipo, T.Tipo, 
	F.Ensamblado, F.Namespace, F.Clase, F.URL, P.Orden, P.ImageFile
	from (
		
			SELECT IdProceso 
			FROM dbo.AccesoProcesos A 
			WHERE A.IdUsuario=@IdUsuario AND IdSucursal=@IdSucursal
			UNION
			SELECT IdProceso 
			FROM dbo.GruposProcesos GP JOIN dbo.UsuariosGrupos UG
				ON GP.IdGrupo=UG.IdGrupo
			WHERE UG.IdUsuario=@IdUsuario
		) A
	join Procesos P on P.IdProceso=A.IdProceso
	join ProcesosTipos T on T.IdProcesoTipo=P.IdProcesoTipo	
	join ProcesosFormas F on (F.IdProceso=P.IdProceso and F.Inicial=Cast(1 AS Bit))
	where P.IdStatus=1
)


