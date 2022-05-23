-- =============================================
-- Author: Victor Moreno
-- Create date: 01-dic-2016
-- Description:	Obtiene la información del OrdenesTrabajo especificado.
-- =============================================
create FUNCTION Production.fxOrdenesTrabajoSEL(@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT [IdOrdenTrabajo]
      ,[Codigo]
      ,[Nombre]
      ,[Fecha]
      ,[IdArticuloStock]
      ,[CantDeseada]
      ,[CantRecibida]
      ,[Version]
      ,[IdOrdenTrabajoTipo]
      ,[FechaPromEntrega]
	  ,FechaRecepcion
      ,[HoraLiberado]
      ,[HoraCierre]
      ,[EntregasParciales]
      ,[ExigirRecepcion]
      ,[Observaciones]
      ,[IdEnsambleActual]
      ,[IdIncidenciaActual]
      ,[FechaEnsambleUltimaRecepcion]
      ,[FechaEnsambleUltimaEntrega]
      ,[IdAlmacenInsumos]
      ,[IdAlmacenPT]
      ,[IdCuenta]
      ,[IdStatus]
      ,[IdWorkFlow]
      ,[IdSucursal]
      ,[IdEmpresa]
      ,[CreateDate]
      ,[LastUpdate]
      ,[PCUpdate]
      ,[UserCreate]
      ,[UserUpdate]
		FROM Production.OrdenesTrabajo 
		WHERE IdOrdenTrabajo=@ID)