

/*******Eliminacion de Movimientos Tit******************/
DECLARE @IdMovimientoTit AS VARCHAR(18)
DECLARE cTran CURSOR FOR 
	select t.IdMovimientoTit
	from inventory.movimientosTit t

	OPEN cTran
	FETCH NEXT FROM cTran INTO @IdMovimientoTit

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		exec [Inventory].[MovimientosTitDEL] @IdMovimientoTit

		FETCH NEXT FROM cTran INTO @IdMovimientoTit
	END
CLOSE cTran
DEALLOCATE cTran

/*******Eliminacion de Ordenes Tit******************/
DECLARE @IdOrdenTit AS VARCHAR(18)
DECLARE cTran CURSOR FOR 
	select t.IdOrdenTit
	from purchasing.OrdenesTit t

	OPEN cTran
	FETCH NEXT FROM cTran INTO @IdOrdenTit

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		exec [Purchasing].[OrdenesTitDEL] @IdOrdenTit

		FETCH NEXT FROM cTran INTO @IdOrdenTit
	END
CLOSE cTran
DEALLOCATE cTran
--Eliminamos el detalle
delete Purchasing.OrdenesDet

/*******Eliminacion de Requsiciones******************/
DECLARE @IdRequisicionTit AS VARCHAR(18)
DECLARE cTran CURSOR FOR 
	select t.IdRequisicion
	from purchasing.Requisiciones t

	OPEN cTran
	FETCH NEXT FROM cTran INTO @IdRequisicionTit

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		exec [Purchasing].[RequisicionesDEL] @IdRequisicionTit

		FETCH NEXT FROM cTran INTO @IdRequisicionTit
	END
CLOSE cTran
DEALLOCATE cTran

/*******Eliminacion de Recepciones******************/
DECLARE @IdRecepcionTit AS VARCHAR(18)
DECLARE cTran CURSOR FOR 
	select t.IdRecepcionTit
	from Purchasing.RecepcionesTit t

	OPEN cTran
	FETCH NEXT FROM cTran INTO @IdRecepcionTit

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		EXEC [Purchasing].[RecepcionesTitDEL] @IdRecepcionTit

		FETCH NEXT FROM cTran INTO @IdRecepcionTit
	END
CLOSE cTran
DEALLOCATE cTran
--Eliminamos el detalle
delete Purchasing.RecepcionesDet

/*******Eliminacion de Proveedores******************/
DELETE Purchasing.ProveedoresArticulos 
DELETE Purchasing.ProveedoresContactos 
DELETE Purchasing.ProveedoresServicios 
DECLARE @ID AS VARCHAR(18)
DECLARE cTran CURSOR FOR 
	select p.IdProveedor
	from Purchasing.Proveedores p

	OPEN cTran
	FETCH NEXT FROM cTran INTO @ID

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		EXEC [Purchasing].[ProveedoresDEL] @ID 

		FETCH NEXT FROM cTran INTO @ID
	END
CLOSE cTran
DEALLOCATE cTran

/*******Eliminacion de Ordenes de Venta ******************/

DECLARE @IdVentaTit AS VARCHAR(18)
DECLARE cTran CURSOR FOR 
	select t.IdVentaTit
	from sales.VentasTit t

	OPEN cTran
	FETCH NEXT FROM cTran INTO @IdVentaTit

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		exec [Sales].[VentaFormasPagoDEL] @IdVentaTit
		exec [Sales].[VentasTitDEL] @IdVentaTit

		FETCH NEXT FROM cTran INTO @IdVentaTit
	END
CLOSE cTran
DEALLOCATE cTran

/******* Eliminacion de Lista de Precios ******************/
DECLARE @IdListaPrecio AS int
DECLARE cTran CURSOR FOR 
	select t.IdListaPrecio
	from sales.ListasPrecios t
	where t.IdListaPrecio<>1
	OPEN cTran
	FETCH NEXT FROM cTran INTO @IdListaPrecio

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		exec [Sales].[ListasPreciosDEL] @IdListaPrecio

		FETCH NEXT FROM cTran INTO @IdListaPrecio
	END
CLOSE cTran
DEALLOCATE cTran
delete sales.ListasPreciosArticulos where IdListaPrecio<>1
delete sales.ListasPreciosServicios where IdListaPrecio<>1
delete sales.ArticulosZonasVenta where IdZonaVenta<>1


/******* Eliminacion de Articulos de Inventario ******************/
delete Inventory.Inventario
delete inventory.InventarioFisico
delete Inventory.InventarioHist
delete Production.OrdenesTrabajo
delete sales.ArticulosPresentaciones

DECLARE @IdArticuloStock AS int
DECLARE cTran CURSOR FOR 
	select t.IdArticuloStock
	from inventory.ArticulosStock t

	OPEN cTran
	FETCH NEXT FROM cTran INTO @IdArticuloStock

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		
		exec [Inventory].[ArticulosStockDEL] @IdArticuloStock

		FETCH NEXT FROM cTran INTO @IdArticuloStock
	END
CLOSE cTran
DEALLOCATE cTran

/******* Eliminacion de Articulos de Venta ******************/

DECLARE @IdArticulo AS int
DECLARE cTran CURSOR FOR 
	select t.IdArticulo
	from sales.Articulos t

	OPEN cTran
	FETCH NEXT FROM cTran INTO @IdArticulo

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		
		exec [Sales].[ArticulosDEL] @IdArticulo

		FETCH NEXT FROM cTran INTO @IdArticulo
	END
CLOSE cTran
DEALLOCATE cTran

/******* Eliminacion de Servicios ******************/
delete sales.ServiciosZonasVenta
DECLARE @IdServicio AS int
DECLARE cTran CURSOR FOR 
	select t.IdServicio
	from sales.Servicios t

	OPEN cTran
	FETCH NEXT FROM cTran INTO @IdServicio

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		
		exec Sales.[ServiciosDEL] @IdServicio

		FETCH NEXT FROM cTran INTO @IdServicio
	END
CLOSE cTran
DEALLOCATE cTran

/******* Eliminacion de Clientes ******************/
delete sales.ClasificacionesClientes
delete sales.ClientesContactos
delete sales.ClientesDomicilios
DECLARE @IdCliente AS int
DECLARE cTran CURSOR FOR 
	select t.IdCliente
	from sales.Clientes t

	OPEN cTran
	FETCH NEXT FROM cTran INTO @IdCliente

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		
		exec [Sales].[ClientesDEL] @IdCliente

		FETCH NEXT FROM cTran INTO @IdCliente
	END
CLOSE cTran
DEALLOCATE cTran

/***************** Se elimina la configuracion general  **********************/
delete dbo.Usuarios where IdUsuario<>1
delete dbo.UsuariosGrupos where IdUsuario<>1
delete dbo.UsuariosSucursales where IdUsuario<>1
delete dbo.GruposPoliticas where idgrupo<>1
delete dbo.GruposProcesos where IdGrupo<>1
delete dbo.GruposUsr where IdGrupo<>1
delete dbo.UsuariosGrupos where IdGrupo<>1
delete dbo.AccesoPoliticas where IdUsuario<>1
delete dbo.AccesoProcesos where IdUsuario<>1
delete dbo.Personas where IdPersona<>1
delete sales.UnidadesNegocio where IdSucursal<>1
delete dbo.Sucursales where IdSucursal<>1
delete dbo.Empresas where IdEmpresa<>1


/********************** Eliminacion de Clientes ****************************/
delete sales.ClientesContactos where IdCliente<>1
delete sales.ClientesDomicilios where IdCliente<>1
delete sales.ClasificacionesClientes where IdCliente<>1
delete sales.PromocionesClientes where IdSucursal<>1
delete sales.Clientes where IdCliente<>1

/***************** Eliminiacion de Produccion ***************************/
delete Production.Movimientos
delete Production.Ensambles
delete Production.Incidencias
delete Production.OrdenesTrabajo
delete Production.OrdenesTrabajoEnsambles

/********************** Eliminacion de la informacion en el schema Church **************************/
delete Church.Bautismos
delete Church.Comuniones
delete Church.Confirmaciones
delete Church.Defunciones
delete Church.Traslados
delete Church.Matrimonios
delete Church.Folios
delete Church.Parroquias
delete Church.Sacerdotes
delete Church.Solicitantes

/************  Eliminamos la informacion de Tesoreria ***********************/
delete Treasury.Bancos
delete Treasury.Beneficiarios
delete Treasury.CajasAccesos
delete Treasury.Cajas
delete Treasury.Conceptos
delete Treasury.ContrarecibosDet
delete Treasury.ContrarecibosTit
delete Treasury.CxPDocumentos
delete Treasury.CxPDocumentosTipos
delete Treasury.CxPEstadosCuenta
delete Treasury.CxPSaldosHist
delete Treasury.PagosDet
delete Treasury.PagosTipos

/*****************************************/





