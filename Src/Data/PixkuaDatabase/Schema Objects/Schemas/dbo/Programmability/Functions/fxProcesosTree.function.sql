CREATE  function [dbo].[fxProcesosTree]() 
RETURNS Table
AS
RETURN(select P.IdProceso, P.Proceso, P.IdModulo, P.Descr, P.IdProcesoTipo, T.Tipo,
	F.Ensamblado,F.Namespace, F.Clase, F.URL, P.Orden, P.ImageFile
	from Procesos P 
	join ProcesosTipos T on T.IdProcesoTipo=P.IdProcesoTipo	
	join ProcesosFormas F on (F.IdProceso=P.IdProceso and F.Inicial=Cast(1 AS Bit))
	where P.IdStatus=1)


