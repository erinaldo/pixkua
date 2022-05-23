/// <reference path="http://localhost:52859/Kali/Scripts/JQuery/jquery-1.7.2-vsdoc.js" />

$('link.cssTheme').attr('href', 'http://code.jquery.com/ui/1.10.3/themes/cupertino/jquery-ui.min.css');

Business.BienesRaices = {}


//Inquilinos
Business.BienesRaices.InquilinoInfo = function () {
    var self = this;
    this.IdPersona = ko.observable(0);
    this.Ocupacion = ko.observable('');
    this.Referencia = ko.observable('');
    this.Persona = new Kernel.General.PersonaInfo();
    this.MapFields = function (info) {
        self.IdPersona(info.IdPersona);
        self.Persona.MapFields(info.Persona);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Business.BienesRaices.InquilinoInfo.prototype = new CatalogInfo();


Business.BienesRaices.InquilinoService = function () { 

}
Business.BienesRaices.InquilinoService.prototype = new CatalogService({ WebService: 'BienesRaices/Inquilino.svc' });


//Fin Inquilino

//Propietario
Business.BienesRaices.PropietarioInfo = function () {
    var self = this;
    this.IdPersona = ko.observable(0);
    this.Ocupacion = ko.observable('');
    this.Referencia = ko.observable('');
    this.Persona = new Kernel.General.PersonaInfo();

    this.MapFields = function (info) {
        self.IdPersona(info.IdPersona);
        self.Persona.MapFields(info.Persona);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Business.BienesRaices.PropietarioInfo.prototype = new CatalogInfo();


Business.BienesRaices.PropietarioService = function () {

}
Business.BienesRaices.PropietarioService.prototype = new CatalogService({ WebService: 'BienesRaices/Propietario.svc' });

//Fin Propietario

//Predio
Business.BienesRaices.PredioInfo = function () {
    var self = this;
    this.Nombre = ko.observable(0);
    this.IdPropietario = ko.observable(0);
    this.IdInquilino = ko.observable(0);
    this.Calle = ko.observable('');
    this.NumExt = ko.observable('');
    this.CajonesEst = ko.observable(0);
    this.MapFields = function (info) {
        self.Nombre(info.Nombre);
        self.IdPropietario(info.IdPropietario);
        self.IdInquilino(info.IdInquilino);
        self.Calle(info.Calle);
        self.NumExt(info.NumExt);
        self.CajonesEst(info.CajonesEst);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Business.BienesRaices.PredioInfo.prototype = new CatalogInfo();


Business.BienesRaices.PredioService = function () {

}
Business.BienesRaices.PredioService.prototype = new CatalogService({ WebService: 'BienesRaices/Predio.svc' });
//Fin Predio


//Vehiculo
Business.BienesRaices.VehiculoInfo = function () {
    var self = this;
    this.Placas = ko.observable(0);
    this.Modelo= ko.observable('');
    this.Marca = ko.observable('');
    this.Anio = ko.observable(0);
    this.Color = ko.observable('');
    this.Tag = ko.observable('');
    this.MapFields = function (info) {
        self.Placas(info.Placas);
        self.Modelo(info.Modelo);
        self.Marca(info.Marca);
        self.Anio(info.Anio);
        self.Color(info.Color);
        self.Tag(info.Tag);        
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Business.BienesRaices.VehiculoInfo.prototype = new CatalogInfo();


Business.BienesRaices.VehiculoService = function () {

}
Business.BienesRaices.VehiculoService.prototype = new CatalogService({ WebService: 'BienesRaices/Vehiculo.svc' });
//Fin Vehiculo

//Servicio Tipo
Business.BienesRaices.ServicioTipoInfo = function () {
    var self = this;
    this.Nombre = ko.observable(0);
    this.MapFields = function (info) {
        self.Nombre(info.Nombre);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Business.BienesRaices.ServicioTipoInfo.prototype = new CatalogInfo();


Business.BienesRaices.ServicioTipoService = function () {

}
Business.BienesRaices.ServicioTipoService.prototype = new CatalogService({ WebService: 'BienesRaices/ServicioTipo.svc' });

//Fin Servicio Tipo

//Servicio
Business.BienesRaices.ServicioInfo = function () {
    var self = this;
    this.IdPersona = ko.observable(0);
    this.IdServicioTipo = ko.observable(0);
    this.Lunes = ko.observable(0);
    this.Martes = ko.observable(0);
    this.Miercoles = ko.observable(0);
    this.Jueves = ko.observable(0);
    this.Viernes = ko.observable(0);
    this.Sabado = ko.observable(0);
    this.Domingo = ko.observable(0);
    this.MapFields = function (info) {
        self.IdPersona(info.IdPersona);
        self.IdServicioTipo(info.IdServicioTipo);
        self.Lunes(info.Lunes);
        self.Martes(info.Martes);
        self.Miercoles(info.Miercoles);
        self.Jueves(info.Jueves);
        self.Viernes(info.Viernes);
        self.Sabado(info.Sabado);
        self.Domingo(info.Domingo);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Business.BienesRaices.ServicioInfo.prototype = new CatalogInfo();


Business.BienesRaices.ServicioService = function () {

}
Business.BienesRaices.ServicioService.prototype = new CatalogService({ WebService: 'BienesRaices/Servicio.svc' });

//Fin Servicio 


//FianzaConcepto
Business.BienesRaices.FianzaConceptoInfo = function () {
    var self = this;
    this.Descripcion = ko.observable(0);
    this.MapFields = function (info) {
        self.Descripcion(info.Descripcion);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Business.BienesRaices.FianzaConceptoInfo.prototype = new CatalogInfo();


Business.BienesRaices.FianzaConceptoService = function () {

}
Business.BienesRaices.FianzaConceptoService.prototype = new CatalogService({ WebService: 'BienesRaices/FianzaConcepto.svc' });

//Fin FianzaConcepto

//Concepto
Business.BienesRaices.ConceptoInfo = function () {
    var self = this;
    this.Nombre = ko.observable(0);
    this.Tipo = ko.observable(0);
    this.Direccion = ko.observable(0);
    this.Automatico = ko.observable(0);
    this.MontoDefault = ko.observable(0);
    this.CuentaContable = ko.observable(0);
    this.MapFields = function (info) {
        self.Nombre(info.Nombre);
        self.Tipo(info.Tipo);
        self.Direccion(info.Direccion);
        self.Automatico(info.Automatico);
        self.MontoDefault(info.MontoDefault);
        self.CuentaContable(info.CuentaContable);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Business.BienesRaices.ConceptoInfo.prototype = new CatalogInfo();


Business.BienesRaices.ConceptoService = function () {

}
Business.BienesRaices.ConceptoService.prototype = new CatalogService({ WebService: 'BienesRaices/Concepto.svc' });

//Fin Concepto


//IncidenciaTipo
Business.BienesRaices.IncidenciaTipoInfo = function () {
    var self = this;
    this.Descripcion = ko.observable(0);
    this.GeneraMulta = ko.observable(0);
    this.CantMulta = ko.observable(0);
    this.Caducidad = ko.observable(0);
    this.ImporteMulta = ko.observable(0);
    this.MapFields = function (info) {
        self.Descripcion(info.Descripcion);
        self.GeneraMulta(info.GeneraMulta);
        self.CantMulta(info.CantMulta);
        self.Automatico(info.Automatico);
        self.Caducidad(info.Caducidad);
        self.ImporteMulta(info.ImporteMulta);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Business.BienesRaices.IncidenciaTipoInfo.prototype = new CatalogInfo();

Business.BienesRaices.IncidenciaTipoService = function () {

}
Business.BienesRaices.IncidenciaTipoService.prototype = new CatalogService({ WebService: 'BienesRaices/IncidenciaTipo.svc' });

//Fin IncidenciaTipo

//Incidencia
Business.BienesRaices.IncidenciaInfo = function () {
    var self = this;
    this.Descripcion = ko.observable(0);
    this.GeneraMulta = ko.observable(0);
    this.CantMulta = ko.observable(0);
    this.Caducidad = ko.observable(0);
    this.ImporteMulta = ko.observable(0);
    this.MapFields = function (info) {
        self.Descripcion(info.Descripcion);
        self.GeneraMulta(info.GeneraMulta);
        self.CantMulta(info.CantMulta);
        self.Automatico(info.Automatico);
        self.Caducidad(info.Caducidad);
        self.ImporteMulta(info.ImporteMulta);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Business.BienesRaices.IncidenciaInfo.prototype = new CatalogInfo();

Business.BienesRaices.IncidenciaService = function () {

}
Business.BienesRaices.IncidenciaService.prototype = new CatalogService({ WebService: 'BienesRaices/Incidencia.svc' });

//Fin Incidencia


//GastoClasificacion
Business.BienesRaices.GastoClasificacionInfo = function () {
    var self = this;
    this.Descripcion = ko.observable(0);
    this.MapFields = function (info) {
        self.Descripcion(info.Descripcion);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Business.BienesRaices.GastoClasificacionInfo.prototype = new CatalogInfo();


Business.BienesRaices.GastoClasificacionService = function () {

}
Business.BienesRaices.GastoClasificacionService.prototype = new CatalogService({ WebService: 'BienesRaices/GastoClasificacion.svc' });

//Fin GastoClasificacion



//GastoConcepto
Business.BienesRaices.GastoConceptoInfo = function () {
    var self = this;
    this.Descripcion = ko.observable(0);
    this.IdGastoClasificacion = ko.observable(0);
    this.CuentaContable = ko.observable(0);
    this.MapFields = function (info) {
        self.Descripcion(info.Descripcion);
        self.IdGastoClasificacion(info.GeneraMulta);
        self.CuentaContable(info.CantMulta);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Business.BienesRaices.GastoConceptoInfo.prototype = new CatalogInfo();

Business.BienesRaices.GastoConceptoService = function () {

}
Business.BienesRaices.GastoConceptoService.prototype = new CatalogService({ WebService: 'BienesRaices/GastoConcepto.svc' });

//Fin GastoConcepto
