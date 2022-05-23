/// <reference path="http://localhost:52859/Onili/Scripts/JQuery/jquery-1.7.2-vsdoc.js" />

$('link.cssTheme').attr('href', 'http://code.jquery.com/ui/1.10.3/themes/cupertino/jquery-ui.min.css');

Business.Inventario = {}

//Articulos
Business.Inventario.ArticuloInfo = function () {
    var self = this;
    this.Descripcion = ko.observable('');
    this.IdArticuloTipo = ko.observable(0);
    this.MapFields = function (info) {
        self.Descripcion(info.Descripcion);
        self.IdArticuloTipo(info.IdArticuloTipo);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Business.Inventario.ArticuloInfo.prototype = new CatalogInfo();
Business.Inventario.ArticuloService = function () {
}
Business.Inventario.ArticuloService.prototype = new CatalogService({WebService: 'Inventario/Articulo.svc'});
// Fin Articulos


//ArticulosTipo
Business.Inventario.ArticuloTipoInfo = function () {
    var self = this;
    this.Descripcion = ko.observable('');
    this.MapFields = function (info) {
        self.Descripcion(info.Descripcion);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}

Business.Inventario.ArticuloTipoInfo.prototype = new CatalogInfo();
Business.Inventario.ArticuloTipoService = function () {
    var self = this;
    this.LoadList = function () {
        var data = { 'sessionID': App.Session.SessionID }
        return self.CallServiceMethod("LoadList", data);
    }
}
Business.Inventario.ArticuloTipoService.prototype = new CatalogService({ WebService: 'Inventario/ArticuloTipo.svc' });
//Fin ArticulosTipo