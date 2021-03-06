

--delete production.OrdenesTrabajoEnsambles
--delete Production.OrdenesTrabajoInsumos
--delete production.OrdenesTrabajo
--delete production.Movimientos


--Public Structure TipoMovimientoOT
--    Const InicioProceso = "IP"
--    Const FinProceso = "FP"
--    Const InicioIncidencia = "II"
--    Const FinIncidencia = "FI"
--    Const EntregaMaterial = "EM"
--    Const RecepcionMaterial = "RM"
--    Const ValidacionPre = "VP"
--    Const ValidacionCalidad = "VC"
--End Structure

GO
/************************CREACION DE LA TABLA PRINCIPAL*****************************************/
if not exists(select t.object_id From sys.tables t where t.name='OrdenesTrabajo' and SCHEMA_NAME(t.schema_id) = 'Production') begin


CREATE TABLE Production.OrdenesTrabajo(
	IdOrdenTrabajo INT NOT NULL,
	Codigo varchar(32) not null,
	Nombre varchar(64) not null,
	Fecha DATE not null,
	IdArticuloStock int not null,
	CantDeseada decimal(19,4) not null,
	CantRecibida decimal(19,4) null,
	Version int null,
	IdOrdenTrabajoTipo int null,
	FechaPromEntrega datetime not null,	
	FechaRecepcion datetime not null,
	HoraLiberado datetime null,
	HoraCierre datetime null,
	EntregasParciales bit not null,
	ExigirRecepcion bit not null,
	Observaciones varchar(256) not null,
	[IdEnsambleActual] [int] NOT NULL CONSTRAINT [DF_OrdenesTrabajo_IdEnsambleUltimo]  DEFAULT ((0)),
	[IdIncidenciaActual] [int] NOT NULL CONSTRAINT [DF_OrdenesTrabajo_IdIncidenciaUltimo]  DEFAULT ((0)),
	FechaEnsambleUltimaRecepcion datetime null,
	FechaEnsambleUltimaEntrega datetime null,
	IdAlmacenInsumos int not null,
	IdAlmacenPT int not null,
	IdCuenta int null,
	[IdStatus] [int] NOT NULL CONSTRAINT [DF_OrdenesTrabajo_IdStatus]  DEFAULT ((1)),
	[IdWorkFlow] [int] NOT NULL CONSTRAINT [DF_OrdenesTrabajo_IdWorkFlow]  DEFAULT ((1)),
	[IdSucursal] [int] NOT NULL CONSTRAINT [DF_OrdenesTrabajo_IdSucursal]  DEFAULT ((0)),
	[IdEmpresa] [int] NOT NULL CONSTRAINT [DF_OrdenesTrabajo_IdEmpresa]  DEFAULT ((1)),
	[CreateDate] [datetime] NOT NULL CONSTRAINT [DF_OrdenesTrabajo_CreateDate]  DEFAULT (getdate()),
	[LastUpdate] [datetime] NOT NULL CONSTRAINT [DF_OrdenesTrabajo_LastUpdate]  DEFAULT (getdate()),
	[PCUpdate] [varchar](32) NOT NULL CONSTRAINT [DF_OrdenesTrabajo_PCUpdate]  DEFAULT (host_name()),
	[UserCreate] [int] NOT NULL CONSTRAINT [DF_OrdenesTrabajo_UserCreate]  DEFAULT ((0)),
	[UserUpdate] [int] NOT NULL CONSTRAINT [DF_OrdenesTrabajo_UserUpdate]  DEFAULT ((0)),
	CONSTRAINT PK_Production_OrdenesTrabajo PRIMARY KEY (IdOrdenTrabajo),
	CONSTRAINT FK_Production_OrdenesTrabajo_ArticuloStock FOREIGN KEY (IdArticuloStock) REFERENCES Inventory.ArticulosStock(IdArticuloStock)
)
end

GO
/************************INSERCION DE CODIGO CONSECUTIVO*****************************************/
IF not exists (select  ll.IdLlave  from dbo.Llaves ll where ll.Tabla='Production.OrdenesTrabajo') begin
	insert into dbo.Llaves(Tabla, Llave) values('Production.OrdenesTrabajo', 1000)
end

GO
/************************CREACION DE LA TABLA ORDENESTRABAJO E INSUMOS*****************************************/
if not exists(select t.object_id From sys.tables t where t.name='OrdenesTrabajoInsumos' and SCHEMA_NAME(t.schema_id) = 'Production') begin


CREATE TABLE Production.OrdenesTrabajoInsumos(
	IdOrdenTrabajoInsumo int identity(1,1) not null,
	IdOrdenTrabajo int not null,
	IdArticuloStock int not null,
	Cantidad decimal(19,4),
	IdUnidadMedida int not null,
	Costo decimal(19,4) NULL,
	Surtir bit NOT NULL CONSTRAINT [DF_OrdenesTrabajoInsumos_Surtir] DEFAULT 0,
	MermaPorc decimal(19,4) not null,
	CONSTRAINT PK_Production_OrdenesTrabajoInsumos_Orden_Articulo PRIMARY KEY (IdOrdenTrabajo, IdArticuloStock),
	CONSTRAINT FK_Production_OrdenesTrabajoInsumos_Orden FOREIGN KEY (IdOrdenTrabajo) REFERENCES Production.OrdenesTrabajo(IdOrdenTrabajo) ON DELETE CASCADE
)
end

GO
/*********************************** UPD TABLA DE ORDENESINSUMOS *********************************************************/
CREATE PROCEDURE [Production].[OrdenesTrabajoInsumosUPD]
	@IdOrdenTrabajo as int,
	@IdArticuloStock as int,
	@Cantidad  as decimal(19,4),
	@IdUnidadMedida as int,
	@Costo as decimal(19,4),
	@Surtir as bit,
	@MermaPorc as decimal(19,4)
AS
	SET NOCOUNT ON
	
	IF NOT EXISTS(SELECT IdOrdenTrabajo  FROM Production.OrdenesTrabajoInsumos  WHERE IdOrdenTrabajo = @IdOrdenTrabajo  AND IdArticuloStock=@IdArticuloStock)
	BEGIN		
		INSERT INTO Production.OrdenesTrabajoInsumos (IdOrdenTrabajo, IdArticuloStock, Cantidad, IdUnidadMedida, Costo, Surtir, MermaPorc)
		VALUES (@IdOrdenTrabajo , @IdArticuloStock, @Cantidad, @IdUnidadMedida, @Costo, @Surtir, @MermaPorc)
	END
	ELSE
		UPDATE Production.OrdenesTrabajoInsumos  SET Surtir=@Surtir, Cantidad=@Cantidad, IdUnidadMedida=@IdUnidadMedida, MermaPorc = @MermaPorc
		WHERE (IdOrdenTrabajo = @IdOrdenTrabajo  AND IdArticuloStock=@IdArticuloStock)


GO
/********************************************* DEL DE ORDENES E INSUMOS ******************************************************/
CREATE PROCEDURE [Production].[OrdenesTrabajoInsumosDEL]
@IdOrdenTrabajo as int,
@IdArticuloStock as int
AS
	DELETE Production.OrdenesTrabajoInsumos
	WHERE IdOrdenTrabajo = @IdOrdenTrabajo AND IdArticuloStock=@IdArticuloStock


GO
/******************************************* SE ACTUALIZAN LOS CONCEPTOS *******************************************************************************************************/
declare @IdMax as int
SELECT @IdMax = max(IdDocumentoTipo ) fROM Documents.tipos 
update dbo.Llaves set Llave = @IdMax where Tabla='Documents.Tipos'

SELECT @IdMax = max(IdDocumentoTipo ) fROM Inventory.Conceptos
update dbo.Llaves set Llave = @IdMax where Tabla='Inventory.Conceptos'



/**************************************************************** SEL DE ORDENES E INSUMOS **************************************************************************/
GO
CREATE FUNCTION [Production].[fxOrdenesTrabajoInsumosSEL](@IdOrdenTrabajo as int)
RETURNS TABLE	
AS
	RETURN(	SELECT OTI.IdOrdenTrabajo , AX.IdArticuloStock , AX.Nombre AS NombreInsumo, OTI.Cantidad, OTI.IdUnidadMedida, OTI.Costo, OTI.MermaPorc ,
			UM.IdUnidadMedidaTipo, UM.Nombre AS UM, OTI.Surtir
			FROM Production.OrdenesTrabajoInsumos  AS OTI
			INNER JOIN Inventory.ArticulosStock AX ON AX.IdArticuloStock=OTI.IdArticuloStock
			INNER JOIN Inventory.UnidadesMedida UM ON UM.IdUnidadMedida = OTI.IdUnidadMedida 
			WHERE OTI.IdOrdenTrabajo = @IdOrdenTrabajo 
	)


GO
/************************CREACION DE LA TABLA ORDENESTRABAJO y ENSAMBLES*****************************************/
if not exists(select t.object_id From sys.tables t where t.name='OrdenesTrabajoEnsambles' and SCHEMA_NAME(t.schema_id) = 'Production') begin


CREATE TABLE Production.OrdenesTrabajoEnsambles(
	IdOrdenTrabajoEnsamble int identity(1,1) not null,
	IdOrdenTrabajo int not null,
	IdEnsamble int not null,
	Orden smallint not null,
	CONSTRAINT PK_Production_OrdenesTrabajoEnsamble_Orden_Ensamble PRIMARY KEY (IdOrdenTrabajo, IdEnsamble),
	CONSTRAINT FK_Production_OrdenesTrabajoEnsambles_Orden FOREIGN KEY (IdOrdenTrabajo) REFERENCES Production.OrdenesTrabajo(IdOrdenTrabajo) ON DELETE CASCADE
)
end


GO
/*********************************** UPD TABLA DE ORDENES - ENSAMBLES *********************************************************/
create PROCEDURE [Production].[OrdenesTrabajoEnsamblesUPD]
	@IdOrdenTrabajo as int,
	@IdEnsamble as int,
	@Orden as smallint
AS
	SET NOCOUNT ON
	
	IF NOT EXISTS(SELECT IdOrdenTrabajo  FROM Production.OrdenesTrabajoEnsambles  WHERE IdOrdenTrabajo = @IdOrdenTrabajo  AND IdEnsamble = @IdEnsamble)
	BEGIN		
		INSERT INTO Production.OrdenesTrabajoEnsambles(IdOrdenTrabajo, IdEnsamble, Orden)
		VALUES (@IdOrdenTrabajo , @IdEnsamble, @Orden)
	END
	ELSE
		UPDATE Production.OrdenesTrabajoEnsambles SET Orden = @Orden
		WHERE (IdOrdenTrabajo = @IdOrdenTrabajo  AND IdEnsamble = @IdEnsamble)

GO
/********************************************* DEL DE ORDENES E INSUMOS ******************************************************/
CREATE PROCEDURE [Production].[OrdenesTrabajoEnsamblesDEL]
@IdOrdenTrabajo as int,
@IdEnsamble as int
AS
	DELETE Production.OrdenesTrabajoEnsambles
	WHERE IdOrdenTrabajo = @IdOrdenTrabajo AND IdEnsamble = @IdEnsamble


/**************************************************************** SEL DE ORDENES y ENSAMBLES **************************************************************************/
GO
CREATE FUNCTION [Production].[fxOrdenesTrabajoEnsamblesSEL](@IdOrdenTrabajo as int)
RETURNS TABLE	
AS
	RETURN(	SELECT OTE.IdOrdenTrabajo , E.IdEnsamble , E.Nombre AS NombreEnsamble, OTE.Orden
			FROM Production.OrdenesTrabajoEnsambles  AS OTE
			INNER JOIN Production.Ensambles E ON E.IdEnsamble = OTE.IdEnsamble
			WHERE OTE.IdOrdenTrabajo = @IdOrdenTrabajo 
	)


GO
/************************************************************FUNCION PARA LOS ENSAMBLES DEL COMBOBOX*********************************************************************************************/

CREATE FUNCTION  [Production].[fxEnsamblesComboBox](@IdEmpresa AS INT)
RETURNS TABLE
AS RETURN (
	select 0 as IdEnsamble, '' as Codigo, 'Todos' as Nombre
	union all
	SELECT E.IdEnsamble, E.Codigo, E.Nombre
	FROM Production.Ensambles E
	WHERE E.IdEmpresa = @IdEmpresa AND E.IdStatus=1
)

GO
/************************************************************FX PARA LAS ORDENES DE TRABAJO DEL ADMINISTRADOR**********************************************************/
CREATE FUNCTION  [Production].[fxOrdenesTrabajoAdminLST](@IdWorkFlow as int, @IdEnsamble as int, @IdEmpresa AS INT) 
RETURNS TABLE
AS RETURN (
	SELECT OT.IdOrdenTrabajo , OT.IdArticuloStock ,OT.Codigo AS OT, AX.Codigo AS Codigo, 
	AX.Nombre AS Articulo, OT.CantDeseada AS Cantidad,
	OT.CantRecibida, OT.EntregasParciales, OT.ExigirRecepcion, OT.IdEnsambleActual, OT.IdIncidenciaActual, 
	OT.IdStatus, OT.IdWorkFlow, OT.FechaEnsambleUltimaRecepcion, OT.FechaEnsambleUltimaEntrega,
	isnull(E.Nombre,'') AS EnsambleActual, isnull(I.Nombre,'') AS IncidenciaActual, isnull(S.StatusApplied,'') as StatusActual,
	Fecha
	FROM Production.OrdenesTrabajo OT
	JOIN Inventory.ArticulosStock AX ON AX.IdArticuloStock = OT.IdArticuloStock
	LEFT JOIN Production.Ensambles  E ON E.IdEnsamble = OT.IdEnsambleActual 
	LEFT JOIN Production.Incidencias I ON I.IdIncidencia = OT.IdIncidenciaActual 
	LEFT JOIN Production.Status S on S.IdStatus = OT.IdWorkFlow
	WHERE OT.IdStatus=1 AND OT.IdEmpresa=@IdEmpresa and IdWorkFlow = @IdWorkFlow and (@IdEnsamble=0 or OT.IdEnsambleActual = @IdEnsamble)
)

GO
/*************************** FUNCION QUE OBTIENE TODOS LOS INSUMOS A LIBERAR DE UNA OT ***************************************************************************************/
CREATE FUNCTION Production.fxOrdenesTrabajoInsumosLiberar(@IdOrdenTrabajo as int)
RETURNS TABLE
AS RETURN(
	SELECT AX.IdArticuloStock, AX.Codigo, AX.Nombre , OTI.Cantidad, A.Nombre AS AlmacenOrigen, SUM(I.Disponible / UM.Factor) AS Existencia
	FROM Production.OrdenesTrabajo OT
	JOIN Production.OrdenesTrabajoInsumos  OTI ON OTI.IdOrdenTrabajo = OT.IdOrdenTrabajo 
	LEFT JOIN Inventory .Inventario I ON I.IdArticuloStock=OTI.IdArticuloStock  AND I.IdAlmacen=OT.IdAlmacenInsumos
	JOIN Inventory.ArticulosStock  AX ON AX.IdArticuloStock = OTI.IdArticuloStock 
	JOIN Inventory.Almacenes  A ON A.IdAlmacen = OT.IdAlmacenInsumos
	JOIN Inventory.UnidadesMedida UM ON AX.IdUnidadMedida=UM.IdUnidadMedida	
	WHERE OT.IdOrdenTrabajo = @IdOrdenTrabajo and OTI.Surtir = 1
	GROUP BY AX.IdArticuloStock, AX.Codigo, AX.Nombre, OTI.Cantidad, A.Nombre
)

/*************************** FUNCION QUE OBTIENE TODOS LOS INSUMOS A LIBERAR DE UNA OT A UN ComboBox ***************************************************************************************/
CREATE FUNCTION Production.fxOrdenesTrabajoInsumosLiberarCBO(@IdOrdenTrabajo as int)
RETURNS TABLE
AS RETURN(
	SELECT AX.IdArticuloStock, AX.Codigo, AX.Nombre
	FROM Production.OrdenesTrabajo OT
	JOIN Production.OrdenesTrabajoInsumos  OTI ON OTI.IdOrdenTrabajo = OT.IdOrdenTrabajo 
	JOIN Inventory.ArticulosStock  AX ON AX.IdArticuloStock = OTI.IdArticuloStock 
	WHERE OT.IdOrdenTrabajo = @IdOrdenTrabajo and OTI.Surtir = 1
	GROUP BY AX.IdArticuloStock, AX.Codigo, AX.Nombre
)


GO
/*************************** FUNCION QUE RETORNA EL ENSAMBLE ANTERIOR CON BASE A UNA ORDEN DE TRABAJO ***************************************************************************************/

CREATE FUNCTION Production.fxOrdenesTrabajoEnsambleAntID(@IdOrdenTrabajo as int)
RETURNS INT
AS BEGIN
	DECLARE @ID AS INT=0

	DECLARE @IdEnsambleActual as int

	--Si la orden de trabajo cuenta con subensambles entonces retornar el anterior
	if exists(SELECT * FROM Production.OrdenesTrabajoEnsambles OTE WHERE OTE.IdOrdenTrabajo=@IdOrdenTrabajo) BEGIN

		SELECT @IdEnsambleActual = isnull(IdEnsambleActual,0) FROM Production.OrdenesTrabajo ot where ot.IdOrdenTrabajo=@IdOrdenTrabajo and ot.IdWorkFlow=1

		---Si la OT no ha iniciado el proceso de produccion entonces retornar su primer ensamble
		IF(@IdEnsambleActual = 0) BEGIN
			SET @ID = ISNULL((SELECT TOP 1 IdEnsamble fROM Production.fxOrdenesTrabajoEnsamblesOrden (@IdOrdenTrabajo) O), 0)
		END ELSE BEGIN
			SELECT @ID = ISNULL(IdEnsambleAnt,0) fROM Production.fxOrdenesTrabajoEnsamblesOrden (@IdOrdenTrabajo) O WHERE O.IdEnsamble = @IdEnsambleActual

			--Si el ensamble anterior es 0 entonces la OT  se encuentra en su primer ensamble
			--enviar -1 para procesarlo en el fuente.
			IF(@ID = 0) BEGIN
				SET @ID = -1
			END
		END
	END 

	RETURN @ID
END


GO
/*************************** FUNCION QUE RETORNA EL ENSAMBLE SIGUIENTE CON BASE A UNA ORDEN DE TRABAJO ***************************************************************************************/

CREATE FUNCTION Production.fxOrdenesTrabajoEnsambleSigID(@IdOrdenTrabajo as int)
RETURNS INT
AS BEGIN
	DECLARE @ID AS INT=0

	DECLARE @IdEnsambleActual as int

	--Si la orden de trabajo cuenta con subensambles entonces retornar el siguiente
	if exists(SELECT * FROM Production.OrdenesTrabajoEnsambles OTE WHERE OTE.IdOrdenTrabajo=@IdOrdenTrabajo) BEGIN

		SELECT @IdEnsambleActual = isnull(IdEnsambleActual,0) FROM Production.OrdenesTrabajo ot where ot.IdOrdenTrabajo=@IdOrdenTrabajo and ot.IdWorkFlow=1

		---Si la OT no ha iniciado el proceso de produccion entonces retornar su primer ensamble
		IF(@IdEnsambleActual = 0) BEGIN
			SET @ID = ISNULL((SELECT TOP 1 IdEnsamble fROM Production.fxOrdenesTrabajoEnsamblesOrden (@IdOrdenTrabajo) O), 0)
		END ELSE BEGIN
			SELECT @ID = ISNULL(IdEnsambleSig,0) fROM Production.fxOrdenesTrabajoEnsamblesOrden (@IdOrdenTrabajo) O WHERE O.IdEnsamble = @IdEnsambleActual

			--Si el siguiente ensamble es 0 entonces la OT  ha llegado al final de la cadena de produccion
			--enviar -1 para procesarlo en el fuente.
			IF(@ID = 0) BEGIN
				SET @ID = -1
			END
		END
	END 

	RETURN @ID
END

GO
/****************************** INSERTAR LA CONFIGURACION PARA LA SALIDA DE INSUMOS ******************************************************************************/

--Crear el tipo de documento ( Documents.Tipos)
--Crear el concepto de salida de insumos con la propiedad en automatico (inventory.Conceptos)
--Insertar la configuracion que detona el concepto de salida automatica de insumos por OT
--insert into dbo.Configuracion(path, [key], value) values('Configuracion/Inventario/Conceptos', 'EntradaPorOT', 21)
--insert into dbo.Configuracion(path, [key], value) values('Configuracion/Inventario/Conceptos', 'SalidaPorOT', 22)


GO
/************************* CREAMOS EL SP para modificar el WorkFlow de la OT y el nuevo Ensamble *************************************************************************/

CREATE PROCEDURE Production.OrdenesTrabajoWorkFlow
	@IdOrdenTrabajo AS int,
	@IdWorkFlowStatus as int,
	@IdEnsamble as int,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON

	DECLARE @IdWorkflowActual as int
	DECLARE @FechaOT as datetime
	DECLARE @IdEnsambleActual as int

	SELECT @IdWorkflowActual = isnull(IdWorkFlow,0), @FechaOT = Fecha, @IdEnsambleActual=IdEnsambleActual FROM Production.OrdenesTrabajo OT WHERE OT.IdOrdenTrabajo=@IdOrdenTrabajo

	
	--Si el status a aplicar es Liberado(2)
	IF(@IdWorkFlowStatus = 2) BEGIN
		UPDATE Production.OrdenesTrabajo SET IdEnsambleActual=@IdEnsamble, IdWorkFlow = @IdWorkFlowStatus, HoraLiberado = getdate()
		WHERE IdOrdenTrabajo=@IdOrdenTrabajo

	--Si el status a aplicar es Cerrado(4)
	END ELSE IF (@IdWorkFlowStatus = 4) BEGIN

		--Actualizamos la orden de trabajo
		UPDATE Production.OrdenesTrabajo SET IdEnsambleActual=0, IdWorkFlow = @IdWorkFlowStatus, HoraCierre = getdate()
		WHERE IdOrdenTrabajo=@IdOrdenTrabajo

		IF NOT EXISTS(SELECT * FROM Production.Movimientos M WHERE M.Fecha >= @FechaOT AND M.Clase='FP' AND M.IdEnsamble=@IdEnsamble AND M.IdOrdenTrabajo=@IdOrdenTrabajo) BEGIN
			--Insertamos el cierre del proceso
			EXEC Production.MovimientosUPD @IdOrdenTrabajo, @IdEnsambleActual , 0 , 'FP', 0, 1 , 1, @PCUpdate , @UserUpdate
		END

	END ELSE BEGIN
		UPDATE Production.OrdenesTrabajo SET IdEnsambleActual=@IdEnsamble, IdWorkFlow = @IdWorkFlowStatus
		WHERE IdOrdenTrabajo=@IdOrdenTrabajo
	END

GO
/*********************************************************** CREAR TABLA PARA LAS MOVIMIENTOS E INCIDENCIAS ****************************************************************/
CREATE TABLE Production.Movimientos(
	IdMovimiento int identity(1,1) not null,
	IdOrdenTrabajo int not null,
	IdEnsamble int not null,
	IdIncidencia int null,
	Fecha datetime not null,
	Hora datetime not null,
	Clase char(4) not null,
	Cantidad decimal(19,4) null,
	[IdSucursal] [int] NOT NULL CONSTRAINT [DF_Movimientos_IdSucursal]  DEFAULT ((0)),
	[IdEmpresa] [int] NOT NULL CONSTRAINT [DF_Movimientos_IdEmpresa]  DEFAULT ((1)),
	[PCUpdate] [varchar](32) NOT NULL CONSTRAINT [DF_Movimientos_PCUpdate]  DEFAULT (host_name()),
	[UserCreate] [int] NOT NULL CONSTRAINT [DF_Movimientos_UserCreate]  DEFAULT ((0)),
	CONSTRAINT PK_Production_Movimientos PRIMARY KEY (IdMovimiento)
)


GO
/************************* CREAMOS EL SP para modificar el WorkFlow de la OT y el nuevo Ensamble *************************************************************************/

CREATE PROCEDURE Production.MovimientosUPD
	@IdOrdenTrabajo  as int,
	--Este es el ensamble seleccionado por el usuario desde la interfaz
	@IdEnsamble as int,
	@IdIncidencia as int,
	@Clase as char(4),
	@Cantidad as decimal(19,4),
	@IdSucursal as int,
	@IdEmpresa as int,
	@PCUpdate as varchar(32),
	@UserCreate as int
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	DECLARE @ErrorMessage as nvarchar(4000)='Error general sp: Production.MovimientosUPD'
	DECLARE @CodigoOT  as varchar(32)
	--Este es el ensamble anterior al ensamble seleccionado por el usuario
	DECLARE @IdEnsambleAnt as int
	--Este es el ensamble siguiente al ensamble seleccionado por el usuario
	DECLARE @IdEnsambleSig as int
	--Este es el ensamble en el cual se encuntra actualmente la OT
	DECLARE @IdEnsambleActual as int
	DECLARE @NombreEnsambleAnt as varchar(64) =''
	DECLARE @NombreEnsambleSig as varchar(64) = ''
	DECLARE @NombreEnsambleAplicar as varchar(64) = ''
	DECLARE @FechaOT as datetime
	
	DECLARE @tMovimientos as TABLE(
		IdMovimiento int,
		IdOrdenTrabajo int,
		IdEnsamble int,
		IdIncidencia int,
		Fecha datetime,
		Hora datetime,
		Clase char(4),
		Cantidad decimal(19,4)
	)

	select @CodigoOT= Codigo, @FechaOT = ot.Fecha from Production.OrdenesTrabajo ot where ot.IdOrdenTrabajo=@IdOrdenTrabajo

	--Se obtienen los movimientos de la OT
	insert into @tMovimientos
	select IdMovimiento, IdOrdenTrabajo, IdEnsamble, IdIncidencia, Fecha, Hora, Clase, Cantidad 
	from Production.Movimientos M
	WHERE M.IdOrdenTrabajo=@IdOrdenTrabajo AND M.Fecha>=@FechaOT

	
	select @IdEnsambleAnt = isnull(O.IdEnsambleAnt,0), @IdEnsambleSig = isnull(O.IdEnsambleSig,0)  from Production.fxOrdenesTrabajoEnsamblesOrden (@IdOrdenTrabajo) O WHERE O.IdEnsamble=@IdEnsamble
	SELECT @IdEnsambleActual = IdEnsambleActual FROM Production.OrdenesTrabajo OT WHERE OT.IdOrdenTrabajo = @IdOrdenTrabajo
	
	select @NombreEnsambleAnt = e.Nombre from Production.Ensambles E WHERE E.IdEnsamble = @IdEnsambleAnt
	select @NombreEnsambleSig = e.Nombre from Production.Ensambles E WHERE E.IdEnsamble = @IdEnsambleSig
	select @NombreEnsambleAplicar = e.Nombre from Production.Ensambles E WHERE E.IdEnsamble = @IdEnsamble
	
	
	--IF NOT EXISTS( @IdEnsambleAnt > 0 OR @IdEnsambleSig > 0 ) BEGIN

	--Verificar si la orden de trabajo cuenta con ensambles
	IF EXISTS( SELECT OTE.IdOrdenTrabajoEnsamble FROM Production.OrdenesTrabajoEnsambles OTE WHERE OTE.IdOrdenTrabajo = @IdOrdenTrabajo ) BEGIN
	
		IF(@Clase = 'IP') BEGIN --INICIO DE PROCESO (IP)
			
			--Si la OT ahun no entra al proceso de produccion insertar el Inicio de Proceso
			IF NOT EXISTS(SELECT M.IdMovimiento FROM @tMovimientos M WHERE M.IdOrdenTrabajo=@IdOrdenTrabajo) BEGIN
				INSERT INTO Production.Movimientos (IdOrdenTrabajo, IdEnsamble, IdIncidencia, Fecha, Hora, Clase, Cantidad, IdSucursal , IdEmpresa , PCUpdate , UserCreate)
				VALUES(@IdOrdenTrabajo, @IdEnsamble, @IdIncidencia , convert(date, getdate()), getdate(), @Clase, @Cantidad, @IdSucursal, @IdEmpresa, @PCUpdate, @UserCreate)
		
			--Si la orden en su anterior ensamble no cuenta con Recepciones O Entregas, truncar la transaccion
			END ELSE IF NOT EXISTS(SELECT M.IdMovimiento FROM @tMovimientos M WHERE M.IdOrdenTrabajo = @IdOrdenTrabajo AND M.Clase IN ('RM')  AND M.IdEnsamble = @IdEnsambleAnt) BEGIN
				SET @ErrorMessage = 'EL ensamble anterior (' + @NombreEnsambleAnt + ') no cuenta con recepciones, respecto al ensamble seleccionado: (' + @NombreEnsambleAplicar + ')'
				RAISERROR(@ErrorMessage,18,1)
				RETURN;
			END ELSE IF NOT EXISTS(SELECT M.IdMovimiento FROM @tMovimientos M WHERE M.IdOrdenTrabajo = @IdOrdenTrabajo AND M.Clase IN ('EM')  AND M.IdEnsamble = @IdEnsambleAnt) BEGIN
				SET @ErrorMessage = 'El ensamble anterior (' + @NombreEnsambleAnt + ') no cuenta con entregas, respecto al ensamble seleccionado: (' + @NombreEnsambleAplicar + ')'
				RAISERROR(@ErrorMessage,18,1)
				RETURN;
			
			--Si la OT ya se encuentra en proceso insertar el inicio del siguiente ensamble y cerrar el anterior
			END ELSE BEGIN

				--Insertamos el Fin de proceso del ensamble anterior
				INSERT INTO Production.Movimientos (IdOrdenTrabajo, IdEnsamble, IdIncidencia, Fecha, Hora, Clase, Cantidad, IdSucursal , IdEmpresa , PCUpdate , UserCreate)
				VALUES(@IdOrdenTrabajo, @IdEnsambleAnt, @IdIncidencia , convert(date, getdate()), getdate(), 'FP', @Cantidad, @IdSucursal, @IdEmpresa, @PCUpdate, @UserCreate)

				--Si la orden ahun no cuenta con un inicio de proceso entonces insertarlo
				IF NOT EXISTS(SELECT M.IdMovimiento from @tMovimientos M WHERE M.IdOrdenTrabajo=@IdOrdenTrabajo AND M.IdEnsamble = @IdEnsamble AND M.Clase = 'IP') BEGIN
					--Insertamos el Inicio de Proceso
					INSERT INTO Production.Movimientos (IdOrdenTrabajo, IdEnsamble, IdIncidencia, Fecha, Hora, Clase, Cantidad, IdSucursal , IdEmpresa , PCUpdate , UserCreate)
					VALUES(@IdOrdenTrabajo, @IdEnsamble, @IdIncidencia , convert(date, getdate()), getdate(), @Clase, @Cantidad, @IdSucursal, @IdEmpresa, @PCUpdate, @UserCreate)
				END

				
			END
			
		END ELSE IF(@Clase = 'FP') BEGIN --FIN DE PROCESO (FP)
			
			IF NOT EXISTS(SELECT * FROM @tMovimientos M WHERE M.IdOrdenTrabajo=@IdOrdenTrabajo AND M.IdEnsamble=@IdEnsamble AND M.Clase='FP') BEGIN
				--Insertamos el Inicio de Proceso
				INSERT INTO Production.Movimientos (IdOrdenTrabajo, IdEnsamble, IdIncidencia, Fecha, Hora, Clase, Cantidad, IdSucursal , IdEmpresa , PCUpdate , UserCreate)
				VALUES(@IdOrdenTrabajo, @IdEnsamble, @IdIncidencia , convert(date, getdate()), getdate(), @Clase, @Cantidad, @IdSucursal, @IdEmpresa, @PCUpdate, @UserCreate)
			END ELSE BEGIN
				UPDATE Production.Movimientos SET Fecha=convert(date, getdate()), Hora=GETDATE(), IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, PCUpdate=@PCUpdate, UserCreate=@UserCreate
				WHERE IdOrdenTrabajo=@IdOrdenTrabajo AND IdEnsamble=@IdEnsamble AND Clase='FP'
			END
			
		END ELSE IF(@Clase = 'RM') BEGIN --RECEPCION DE MATERIAL (RM)
			
			--Si el ensamble anterior tiene al menos una entrega entonces insertar la Recepcion del actual ensamble
			IF( EXISTS(SELECT M.IdMovimiento FROM @tMovimientos M WHERE M.IdOrdenTrabajo = @IdOrdenTrabajo AND M.IdEnsamble = @IdEnsambleAnt AND M.Clase = 'EM') OR @IdEnsambleAnt=0) BEGIN
				
				--En caso de que no existe un inicio de proceso en el actual ensamble y se requiere recepcionar entonces insertar un inicio de proceso
				IF NOT EXISTS(SELECT M.IdMovimiento FROM @tMovimientos M WHERE M.IdOrdenTrabajo=@IdOrdenTrabajo  AND M.IdEnsamble = @IdEnsamble  AND M.Clase = 'IP') BEGIN
					INSERT INTO Production.Movimientos (IdOrdenTrabajo, IdEnsamble, IdIncidencia, Fecha, Hora, Clase, Cantidad, IdSucursal , IdEmpresa , PCUpdate , UserCreate)
					VALUES(@IdOrdenTrabajo, @IdEnsamble, @IdIncidencia , convert(date, getdate()), getdate(), 'IP', @Cantidad, @IdSucursal, @IdEmpresa, @PCUpdate, @UserCreate)
				END

				--Insertamos el movimiento
				INSERT INTO Production.Movimientos (IdOrdenTrabajo, IdEnsamble, IdIncidencia, Fecha, Hora, Clase, Cantidad, IdSucursal , IdEmpresa , PCUpdate , UserCreate)
				VALUES(@IdOrdenTrabajo, @IdEnsamble, @IdIncidencia , convert(date, getdate()), getdate(), @Clase, @Cantidad, @IdSucursal, @IdEmpresa, @PCUpdate, @UserCreate)

				--Actualizamos la OT con base al ultimo movimiento
				UPDATE Production.OrdenesTrabajo SET FechaEnsambleUltimaRecepcion = getdate()
				WHERE IdOrdenTrabajo=@IdOrdenTrabajo
			END ELSE BEGIN
				SET @ErrorMessage = 'El ensamble anterior ('+ @NombreEnsambleAnt +') no cuenta con entrega alguna, respecto al ensamble seleccionado: (' + @NombreEnsambleAplicar + ')'
				RAISERROR(@ErrorMessage, 18, 1)
				RETURN;
			END

		END ELSE IF(@Clase = 'EM') BEGIN --ENTREGA DE MATERIAL (EM)

			--Si la OT ya cuenta recepciones al ensamble actual entonces insertar la Entrega
			IF( EXISTS(SELECT M.IdMovimiento  FROM @tMovimientos M WHERE M.IdOrdenTrabajo=@IdOrdenTrabajo AND M.IdEnsamble = @IdEnsamble AND M.Clase='RM') ) BEGIN

				--Insertamos el movimiento
				INSERT INTO Production.Movimientos (IdOrdenTrabajo, IdEnsamble, IdIncidencia, Fecha, Hora, Clase, Cantidad, IdSucursal , IdEmpresa , PCUpdate , UserCreate)
				VALUES(@IdOrdenTrabajo, @IdEnsamble, @IdIncidencia , convert(date, getdate()), getdate(), @Clase, @Cantidad, @IdSucursal, @IdEmpresa, @PCUpdate, @UserCreate)

				--Actualizamos la OT con base al ultimo movimiento
				UPDATE Production.OrdenesTrabajo SET FechaEnsambleUltimaEntrega = getdate()
				WHERE IdOrdenTrabajo=@IdOrdenTrabajo
			END ELSE BEGIN
				SET @ErrorMessage = 'El ensamble seleccionado: ('+ @NombreEnsambleAplicar +').' + 'no cuenta con recepcion alguna.'
				RAISERROR(@ErrorMessage, 18, 1)
				RETURN;
			END

		END ELSE IF(@Clase = 'II') BEGIN  --INICIO DE INCIDENCIA (II)

			IF NOT EXISTS(SELECT ED.IdEnsamble FROM Production.fxEnsamblesDisponiblesII(@IdOrdenTrabajo) ED WHERE ED.IdEnsamble  = @IdEnsamble) BEGIN
				SET @ErrorMessage = 'No es posible agregar una incidencia a un ensamble anterior al actual de la OT: (' + @CodigoOT  + ').'
				RAISERROR(@ErrorMessage, 18,1)
				RETURN;
			END ELSE IF NOT EXISTS(SELECT M.IdMovimiento FROM @tMovimientos M WHERE M.IdOrdenTrabajo = @IdOrdenTrabajo AND M.IdEnsamble = @IdEnsambleAnt  AND M.Clase='EM') 
				AND @IdEnsambleActual > 0 AND @IdEnsambleAnt > 0 BEGIN
				
				SET @ErrorMessage = 'No existen entregas del ensamble anterior: (' + @NombreEnsambleAnt  +') al seleccionado: (' + @NombreEnsambleAplicar  + ')'
				RAISERROR(@ErrorMessage, 18,1)
				RETURN;

			END ELSE IF NOT EXISTS(SELECT M.IdMovimiento FROM @tMovimientos M WHERE M.IdOrdenTrabajo = @IdOrdenTrabajo AND M.IdEnsamble = @IdEnsamble  AND M.Clase='RM') BEGIN
				
				SET @ErrorMessage = 'No existen recepciones en el ensamble seleccionado: (' + @NombreEnsambleAplicar   +')'
				RAISERROR(@ErrorMessage, 18,1)
				RETURN;

			END ELSE BEGIN
				--Insertamos el movimiento en caso de cumplir con los requerimientos
				INSERT INTO Production.Movimientos (IdOrdenTrabajo, IdEnsamble, IdIncidencia, Fecha, Hora, Clase, Cantidad, IdSucursal , IdEmpresa , PCUpdate , UserCreate)
				VALUES(@IdOrdenTrabajo, @IdEnsamble, @IdIncidencia , convert(date, getdate()), getdate(), @Clase, @Cantidad, @IdSucursal, @IdEmpresa, @PCUpdate, @UserCreate)

				--Si se agrego una incidencia cambiar el status de la OT a Espera(3) hasta que esta sea cerrada
				UPDATE Production.OrdenesTrabajo SET IdIncidenciaActual=@IdIncidencia, IdWorkFlow = 3
				WHERE IdOrdenTrabajo=@IdOrdenTrabajo
			END

		END ELSE IF(@Clase = 'FI') BEGIN --FIN DE INCIDENCIA (FI)
			
			--Verificamos que exista un inicio de incidencia del movimiento a insertar
			IF EXISTS(SELECT M.IdMovimiento FROM @tMovimientos M WHERE M.IdOrdenTrabajo = @IdOrdenTrabajo  AND M.IdEnsamble = @IdEnsamble AND M.Clase = 'II') BEGIN
				--Insertamos el movimiento en caso de cumplir con los requerimientos
				INSERT INTO Production.Movimientos (IdOrdenTrabajo, IdEnsamble, IdIncidencia, Fecha, Hora, Clase, Cantidad, IdSucursal , IdEmpresa , PCUpdate , UserCreate)
				VALUES(@IdOrdenTrabajo, @IdEnsamble, @IdIncidencia , convert(date, getdate()), getdate(), @Clase, @Cantidad, @IdSucursal, @IdEmpresa, @PCUpdate, @UserCreate)
				
				--Actualizamos la orden de trabajo con la incidencia y regresamos el status a liberado(2)
				UPDATE Production.OrdenesTrabajo SET IdIncidenciaActual = 0, IdWorkFlow = 2
				WHERE IdOrdenTrabajo=@IdOrdenTrabajo

				
			END ELSE BEGIN
				SET @ErrorMessage = 'No existe un inicio de incidencia de la orden de trabajo: (' + @CodigoOT + ') del ensamble requerido ('  + @NombreEnsambleAplicar +')'
				RAISERROR(@ErrorMessage, 18, 1)
				RETURN;
			END
		END

	END ELSE BEGIN
		SET @ErrorMessage  = 'Ya que la orden de trabajo ' + @CodigoOT + ' no cuenta con ensambles predefinidos.'
		RAISERROR(@ErrorMessage,18,1)
		RETURN;
	END

/*********************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Victor Moreno,>
-- Create date: <Create Date, 2016-12-18,>
-- Description:	<Description, Funcion que devuelve el ultimo ensamble de una Orden de Trabajo ,>
-- =============================================
CREATE FUNCTION Production.fxOrdenTrabajoUltimoEnsambleID
(
	-- Add the parameters for the function here
	@IdOrdenTrabajo as int
)
RETURNS int
AS
BEGIN

	DECLARE @ID AS INT=0

	SELECT TOP 1 @ID = ISNULL(OT.IdEnsamble,0)
	FROM Production.OrdenesTrabajoEnsambles OT WHERE OT.IdOrdenTrabajo = @IdOrdenTrabajo
	ORDER BY OT.Orden DESC

	-- Return the result of the function
	RETURN @ID

END

GO
/************************* RETORNA LOS ENSAMBLES DISPONIBLES PARA AGREGAR UNA INCIDENCIA *************************************************************************/	

CREATE FUNCTION Production.fxEnsamblesDisponiblesII(@IdOrdenTrabajo as int)
RETURNS @tEnsambles TABLE(
	IdEnsamble int
) AS BEGIN

	
	DECLARE @IdEnsamble as int
	declare @IdEnsambleActual as int
	DECLARE @EnsambleEncontrado as bit = 0

	select @IdEnsambleActual = IdEnsambleACtual from Production.OrdenesTrabajo ot where ot.IdOrdenTrabajo=@IdOrdenTrabajo
	
	DECLARE cTran CURSOR FOR 
	SELECT OTE.IdEnsamble FROM Production.OrdenesTrabajoEnsambles OTE
	WHERE OTE.IdOrdenTrabajo = @IdOrdenTrabajo
	ORDER BY OTE.Orden

    OPEN cTran
    FETCH NEXT FROM cTran INTO @IdEnsamble

    WHILE @@FETCH_STATUS = 0
    BEGIN
		
		IF(@IdEnsambleActual = @IdEnsamble) BEGIN
			set @EnsambleEncontrado = 1
		END

		IF(@EnsambleEncontrado = 1) BEGIN
			INSERT INTO @tEnsambles
			SELECT @IdEnsamble
		END

        FETCH NEXT FROM cTran INTO @IdEnsamble
    END
    CLOSE cTran
    DEALLOCATE cTran

	RETURN
END

	
GO
/************************* TABLA DE ESTATUS *************************************************************************/	

CREATE TABLE Production.Status (
	IdStatus int not null,
	Codigo varchar(32) not null,
	Status varchar(32) not null,
	StatusApplied varchar(64) not null,
	Activo bit not null,
	IdSucursal int not null,
	IdEmpresa int not null,
	CreateDate datetime not null,
	LastUpdate datetime not null,
	PCUpdate varchar(64) not null,
	UserCreate int not null,
	UserUpdate int not null,
	CONSTRAINT PK_Production_Status PRIMARY KEY (IdStatus)
)

--Insertamos los status predeterminados
INSERT INTO Production.Status(IdStatus, Codigo, Status, StatusApplied, Activo, IdSucursal, IdEmpresa, CreateDate, LastUpdate, PCUpdate, UserCreate, UserUpdate)
values(1,'1', 'Guardar', 'Guardado', 1, 1, 1, getdate(), getdate(), 'admin', 1, 1)
INSERT INTO Production.Status(IdStatus, Codigo, Status, StatusApplied, Activo, IdSucursal, IdEmpresa, CreateDate, LastUpdate, PCUpdate, UserCreate, UserUpdate)
values(2,'2', 'Liberar', 'Liberado', 1, 1, 1, getdate(), getdate(), 'admin', 1, 1)
INSERT INTO Production.Status(IdStatus, Codigo, Status, StatusApplied, Activo, IdSucursal, IdEmpresa, CreateDate, LastUpdate, PCUpdate, UserCreate, UserUpdate)
values(3,'3', 'EnEspera', 'En Espera', 1, 1, 1, getdate(), getdate(), 'admin', 1, 1)
INSERT INTO Production.Status(IdStatus, Codigo, Status, StatusApplied, Activo, IdSucursal, IdEmpresa, CreateDate, LastUpdate, PCUpdate, UserCreate, UserUpdate)
values(4,'4', 'Cerrar', 'Cerrado', 1, 1, 1, getdate(), getdate(), 'admin', 1, 1)
INSERT INTO Production.Status(IdStatus, Codigo, Status, StatusApplied, Activo, IdSucursal, IdEmpresa, CreateDate, LastUpdate, PCUpdate, UserCreate, UserUpdate)
values(5,'5', 'Cancelar', 'Cancelado', 1, 1, 1, getdate(), getdate(), 'admin', 1, 1)

GO
/************************* TABLA DE ESTATUS *************************************************************************/	

CREATE TABLE Production.MovimientosClases (
	IdMovimientoClase int identity(1, 1) not null,
	Codigo varchar(32) not null,
	Nombre varchar(32) not null,
	Activo bit not null,
	IdSucursal int not null,
	IdEmpresa int not null,
	CreateDate datetime not null,
	LastUpdate datetime not null,
	PCUpdate varchar(64) not null,
	UserCreate int not null,
	UserUpdate int not null,
	CONSTRAINT PK_Production_MovimientosClases PRIMARY KEY (IdMovimientoClase),
	CONSTRAINT UQ_Production_MovimientosClases UNIQUE  (Codigo)
)

GO
--Insertamos los status predeterminados
INSERT INTO Production.MovimientosClases(Codigo, Nombre, Activo, IdSucursal, IdEmpresa, CreateDate, LastUpdate, PCUpdate, UserCreate, UserUpdate)
values('IP', 'Inicio de Proceso', 1, 1, 1, getdate(), getdate(), 'admin', 1, 1)
INSERT INTO Production.MovimientosClases(Codigo, Nombre, Activo, IdSucursal, IdEmpresa, CreateDate, LastUpdate, PCUpdate, UserCreate, UserUpdate)
values('FP', 'Fin de Proceso', 1, 1, 1, getdate(), getdate(), 'admin', 1, 1)
INSERT INTO Production.MovimientosClases(Codigo, Nombre, Activo, IdSucursal, IdEmpresa, CreateDate, LastUpdate, PCUpdate, UserCreate, UserUpdate)
values('II', 'Inicio de Incidencia', 1, 1, 1, getdate(), getdate(), 'admin', 1, 1)
INSERT INTO Production.MovimientosClases(Codigo, Nombre, Activo, IdSucursal, IdEmpresa, CreateDate, LastUpdate, PCUpdate, UserCreate, UserUpdate)
values('FI', 'Fin de Incidencia', 1, 1, 1, getdate(), getdate(), 'admin', 1, 1)
INSERT INTO Production.MovimientosClases(Codigo, Nombre, Activo, IdSucursal, IdEmpresa, CreateDate, LastUpdate, PCUpdate, UserCreate, UserUpdate)
values('EM', 'Entrega de Material', 1, 1, 1, getdate(), getdate(), 'admin', 1, 1)
INSERT INTO Production.MovimientosClases(Codigo, Nombre, Activo, IdSucursal, IdEmpresa, CreateDate, LastUpdate, PCUpdate, UserCreate, UserUpdate)
values('RM', 'Recepción de Material', 1, 1, 1, getdate(), getdate(), 'admin', 1, 1)




GO
/*************** FUNCION PARA VER ORDEN EN LOS ENSAMBLES DE UNA OT ***************************************************************************************************/

CREATE FUNCTION Production.fxOrdenesTrabajoEnsamblesOrden(@IdOrdenTrabajo as int)
RETURNS @tOrden  TABLE(
	IdOrdenTrabajo int,
	IdEnsamble int,
	IdEnsambleAnt int,
	IdEnsambleSig int,
	Orden int
) AS BEGIN

	

	DECLARE @IdEnsamble AS INT,
			@Orden AS INT
			
	
	DECLARE cTran CURSOR FOR 
	SELECT OT.IdEnsamble, OT.Orden
	FROM Production.OrdenesTrabajoEnsambles OT WHERE OT.IdOrdenTrabajo=@IdOrdenTrabajo
	order by OT.Orden

    OPEN cTran
    FETCH NEXT FROM cTran INTO @IdEnsamble, @Orden

    WHILE @@FETCH_STATUS = 0
    BEGIN

		DECLARE @IdEnsambleAnt as int = 0,
				@IdEnsambleSig as int = 0,
				@IdEnsambleInmAnt as int = 0,
				@IdEnsambleInmSig as int = 0
		
		--Cursor para encontrar al ensamble anterior
		DECLARE @IdEnsamble2 AS INT,
				@Orden2 AS INT
	
		DECLARE cTranAnt CURSOR FOR 
		SELECT OT.IdEnsamble, OT.Orden
		FROM Production.OrdenesTrabajoEnsambles OT WHERE OT.IdOrdenTrabajo=@IdOrdenTrabajo
		order by OT.Orden

		OPEN cTranAnt
		FETCH NEXT FROM cTranAnt INTO @IdEnsamble2, @Orden2

		WHILE @@FETCH_STATUS = 0 
		BEGIN
		
			IF(@IdEnsamble = @IdEnsamble2) BEGIN
				set @IdEnsambleAnt = @IdEnsambleInmAnt 
				BREAK
			END
			set @IdEnsambleInmAnt = @IdEnsamble2

			FETCH NEXT FROM cTranAnt INTO @IdEnsamble2, @Orden2
		END
		CLOSE cTranAnt
		DEALLOCATE cTranAnt
		--Fin del cursor Ant


		--Cursor para encontrar al ensamble siguiente
		DECLARE @IdEnsamble3 AS INT,
				@Orden3 AS INT
	
		DECLARE cTranSig CURSOR FOR 
		SELECT OT.IdEnsamble, OT.Orden
		FROM Production.OrdenesTrabajoEnsambles OT WHERE OT.IdOrdenTrabajo=@IdOrdenTrabajo
		order by OT.Orden desc

		OPEN cTranSig
		FETCH NEXT FROM cTranSig INTO @IdEnsamble3, @Orden3

		WHILE @@FETCH_STATUS = 0 
		BEGIN
		
			IF(@IdEnsamble = @IdEnsamble3) BEGIN
				set @IdEnsambleSig = @IdEnsambleInmSig
				BREAK
			END

			set @IdEnsambleInmSig = @IdEnsamble3

			FETCH NEXT FROM cTranSig INTO @IdEnsamble3, @Orden3
		END
		CLOSE cTranSig
		DEALLOCATE cTranSig
		--Fin del Cursor Sig

		--Insertamos el ensamble con su ant y sig.
		INSERT INTO @tOrden(IdOrdenTrabajo, IdEnsamble, IdEnsambleAnt, IdEnsambleSig, Orden)
			VALUES(@IdOrdenTrabajo, @IdEnsamble, @IdEnsambleAnt, @IdEnsambleSig, @Orden)


        FETCH NEXT FROM cTran INTO @IdEnsamble, @Orden
    END
    CLOSE cTran
    DEALLOCATE cTran

	RETURN
END

GO
/*************** FUNCION PARA VER LOS MOVIMIENTOS DE UNA OT ***************************************************************************************************/
CREATE FUNCTION Production.fxOrdenesTrabajoMovsByOT(@IdOrdenTrabajo as int, @IdEnsamble as int = 0)
RETURNS TABLE
RETURN
(
	SELECT isnull(E.Nombre,'') AS Ensamble, isnull(I.Nombre,'') AS Incidencia, M.Fecha, convert(varchar(32), M.Hora, 108) AS Hora, M.Clase, M.Cantidad, U.Usuario
	FROM Production.Movimientos M
	LEFT JOIN Production.Ensambles E ON E.IdEnsamble = M.IdEnsamble
	LEFT JOIN Production.Incidencias I ON I.IdIncidencia = M.IdIncidencia
	JOIN dbo.Usuarios U ON U.IdUsuario = M.UserCreate
	WHERE M.IdOrdenTrabajo=@IdOrdenTrabajo AND (@IdEnsamble = 0 OR M.IdEnsamble = @IdEnsamble)
)
	
GO
/********************** FUNCION PARA EL COMBOBOX DE LAS INCIDENCIAS ***********************************************/
CREATE FUNCTION Production.fxIncidenciasCBO()
RETURNS TABLE
RETURN (
	SELECT I.IdIncidencia, I.Codigo, I.Nombre
	FROM Production.Incidencias I
	WHERE I.IdStatus=1
)

GO
/************************************************************FUNCION PARA LOS ENSAMBLES DEL COMBOBOX POR ORDEN DE TRABAJO*********************************************************************************************/
CREATE FUNCTION  [Production].[fxEnsamblesComboBoxByOT](@IdOrdenTrabajo as int)
RETURNS @tEnsambles TABLE (
	IdEnsamble int,
	Codigo varchar(32),
	Nombre varchar(64)
)
AS BEGIN

	insert into @tEnsambles
	SELECT E.IdEnsamble, E.Codigo, CAST(OTE.Orden AS CHAR(4)) + ' - '  +  E.Nombre as Nombre
	FROM Production.Ensambles E
	JOIN Production.OrdenesTrabajoEnsambles OTE ON OTE.IdEnsamble = E.IdEnsamble
	WHERE E.IdStatus=1 AND OTE.IdOrdenTrabajo = @IdOrdenTrabajo
	ORDER BY OTE.Orden

	RETURN 
END

GO
/********************* SP QUE ACTUALIZA LA CANTIDAD DESCARGADA POR UNA OT *****************************************************************************************************************/

create PROCEDURE Production.OrdenesTrabajoCantidadRecibidaUPD
	@IdOrdenTrabajo  as int,
	@Cantidad as decimal(19,4),
	@Direccion as smallint
	
AS
	SET NOCOUNT ON

	--Si el movimiento es una entrada entonces afectar cantidad recibida
	IF @Direccion>0 begin
		UPDATE Production.OrdenesTrabajo SET CantRecibida = isnull(CantRecibida,0) + (@Cantidad * @Direccion) WHERE IdOrdenTrabajo=@IdOrdenTrabajo
	end

GO
/*************** FUNCION PARA VER LOS MOVIMIENTOS EN INVENTARIO DE UNA OT ***************************************************************************************************/
CREATE FUNCTION Production.fxOrdenesTrabajoMovsInventario(@IdOrdenTrabajo as int)
RETURNS TABLE
RETURN
(
	SELECT T.IdMovimientoTit, T.Fecha, T.HoraMovto, CASE T.Direccion
			WHEN 1 THEN 'Entrada'
			WHEN -1 THEN 'Salida'
		END AS Direccion, T.TotalFlete, A.Nombre AS Almacen, C.Nombre AS Concepto,
		S.StatusApplied AS Estatus, T.Observaciones, AX.Codigo, AX.Nombre, UM.Nombre AS UnidadMedida, UM.Factor,
		D.Cantidad, D.CostoUnitario
	FROM Inventory.MovimientosTit T 
	JOIN Inventory.MovimientosDet D ON T.IdMovimientoTit=D.IdMovimientoTit AND T.Fecha=D.Fecha
	JOIN Inventory.Almacenes A ON T.IdAlmacen=A.IdAlmacen
	JOIN Inventory.Conceptos C ON T.IdConcepto=C.IdConcepto
	JOIN Documents.Status S ON T.IdStatus=S.IdStatus
	JOIN Inventory.ArticulosStock AX ON D.IdArticuloStock=AX.IdArticuloStock
	JOIN Inventory.UnidadesMedida UM ON D.IdUnidadMedida=UM.IdUnidadMedida
	JOIN Production.OrdenesTrabajo OT ON OT.Codigo COLLATE DATABASE_DEFAULT = T.Referencia COLLATE DATABASE_DEFAULT
	WHERE T.Fecha >= OT.Fecha AND OT.IdOrdenTrabajo=@IdOrdenTrabajo
)

GO

