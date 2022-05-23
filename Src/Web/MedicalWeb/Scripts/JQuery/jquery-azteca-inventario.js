/// <reference path="http://localhost:52859/Onili/Scripts/JQuery/jquery-1.7.2-vsdoc.js" />

Business.Inventario = {}

Business.Inventario.AreaInfo = function () {
    var self = this;
    this.Nombre = ko.observable('');
    this.MapFields = function (info) {
        self.Nombre(info.Nombre);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Business.Inventario.AreaInfo.prototype = new CatalogInfo();

Business.Inventario.AreaService = function () {
    var shelf = this;
}
Business.Inventario.AreaService.prototype = new CatalogService({ WebService: 'Inventario/Area.svc'});