/// <reference path="http://localhost:52859/Onili/Scripts/JQuery/jquery-1.7.2-vsdoc.js" />

$('link.cssTheme').attr('href', 'http://code.jquery.com/ui/1.10.3/themes/cupertino/jquery-ui.min.css');

Business.Ventas = {}

///Clientes
Business.Ventas.ClienteInfo = function () {
    var self = this;

    //General
    this.Nombre = ko.observable('');
    this.Calle = ko.observable('');
    this.Cruce1 = ko.observable('');
    this.Cruce2 = ko.observable('');
    this.NumExt = ko.observable('');
    this.NumInt = ko.observable('');
    this.Colonia = ko.observable('');
    this.CP = ko.observable('');
    this.IdPoblacion = ko.observable(0);
    this.Latitud = ko.observable(0);
    this.Longitud = ko.observable(0);
    this.Telefonos = ko.observable('');
    this.Fax = ko.observable('');
    this.Correo = ko.observable('');
    this.PagWeb = ko.observable('');

    //Facturacion
    this.Facturable = ko.observable(1);
    this.RFC = ko.observable('');
    this.RazonSocial = ko.observable('');
    this.CalleFiscal = ko.observable('');
    this.NumExtFiscal = ko.observable('');
    this.NumIntFiscal = ko.observable('');
    this.ColoniaFiscal = ko.observable('');
    this.CPFiscal = ko.observable('');
    this.IdPoblacionFiscal = ko.observable(0);
    this.IdComprobanteAddenda = ko.observable(0);
    this.GLN = ko.observable('');
    this.GLNTienda = ko.observable('');
    this.NumProveedor = ko.observable(0);
    //Ventas
    this.CondicionesPago = ko.observable(0);
    this.IdListaPrecio = ko.observable(1);
    this.IdGrupoDescuentos = ko.observable(0);
    this.IdGama = ko.observable(0);
    this.LimiteCredito = ko.observable(0);
    this.DiasCredito = ko.observable(0);
    this.IdMetodoPago = ko.observable(0);
    this.CuentaPago = ko.observable('');
    //Contabilidad
    //this.IdCuentaContable  = ko.observable(0);
    //this.WebPassword  = ko.observable('');
    this.IdCompany = ko.observable(0);
    this.IdBranch = ko.observable(0);
    this.Active = ko.observable(1);
    this.Code = ko.observable('');

    this.MapFields = function (info) {
        self.Nombre(info.Nombre);
        self.Calle(info.Calle);
        self.Cruce1(info.Cruce1);
        self.Cruce2(info.Cruce2);
        self.NumExt(info.NumExt);
        self.NumInt(info.NumInt);
        self.Colonia(info.Colonia);
        self.CP(info.CP);
        self.IdPoblacion(info.IdPoblacion);
        self.Latitud(info.Latitud);
        self.Longitud(info.Longitud);
        self.Telefonos(info.Telefonos);
        self.Fax(info.Fax);
        self.Correo(info.Correo);
        self.PagWeb(info.PagWeb);
        //Facturacion
        self.Facturable(info.Facturable);
        self.RFC(info.RFC);
        self.RazonSocial(info.RazonSocial);
        self.CalleFiscal(info.CalleFiscal);
        self.NumExtFiscal(info.NumExtFiscal);
        self.NumIntFiscal(info.NumIntFiscal);
        self.ColoniaFiscal(info.ColoniaFiscal);
        self.CPFiscal(info.CPFiscal);
        self.IdPoblacionFiscal(info.IdPoblacionFiscal);
        self.IdComprobanteAddenda(info.IdComprobanteAddenda);
        self.GLN(info.GLN);
        self.GLNTienda(info.GLNTienda);
        self.NumProveedor(info.NumProveedor);
        //Ventas
        self.CondicionesPago(info.CondicionesPago);
        self.IdListaPrecio(info.IdListaPrecio);
        self.IdGrupoDescuentos(info.IdGrupoDescuentos);
        self.IdGama(info.IdGama);
        self.LimiteCredito(info.LimiteCredito);
        self.DiasCredito(info.DiasCredito);
        self.IdMetodoPago(info.IdMetodoPago);
        self.CuentaPago(info.CuentaPago);

        CatalogInfo.prototype.MapFields.call(self, info);
        //self.Identity(info.Identity);
//        self.Code(info.UserCode);
//        self.Active(info.Status);
//        self.IdBranch(info.IdSucursal);
//        self.IdCompany(info.IdEmpresa);
//        self.LastUpdate = info.LastUpdate;
//        self.CreateDate = info.CreateDate;
//        self.ActivateDate = info.ActivateDate;
//        self.DeactivateDate = info.DeactivateDate;
//        self.PCUpdate = info.PCUpdate;
//        self.UserCreate = info.UserCreate;
//        self.UserUpdate = info.UserUpdate;
//        self.SessionID = info.SessionID;
    }
}
Business.Ventas.ClienteInfo.prototype = new CatalogInfo();
Business.Ventas.ClienteService = function () {
}
Business.Ventas.ClienteService.prototype = new CatalogService({ WebService: 'Ventas/Cliente.svc' });
// Fin Articulos
