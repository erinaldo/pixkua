/// <reference path="http://localhost:52859/Onili/Scripts/JQuery/jquery-1.7.2-vsdoc.js" />

$('link.cssTheme').attr('href', 'http://code.jquery.com/ui/1.10.3/themes/cupertino/jquery-ui.min.css');

Kernel = new Object();
Business = new Object();

//Inicializar objeto App que contiene variables de entorno
function ApplicationInfo() {
    this.PageSize = 0;
    this.Path = "";
    this.ImagePath = "";
    this.ServicePath = "";
    this.Session = new Object();
    this.Session.SessionID = "";
    this.Session.UserName = "";
    this.DefaultCompany = new Object();
    this.DefaultCompany.Identity = 1;
    this.DefaultCompany.Nombre = "";
    this.DefaultBranch = new Object();
    this.DefaultBranch.Identity = 1;
    this.DefaultBranch.Nombre = "";
    this.Theme = "";
}

var App = new ApplicationInfo();


$(document).ready(function () {
    App = $.parseJSON($('#__App').val());
    //
    App.Path = window.location.protocol + "//" + window.location.host + App.VirtualDirectory;
    App.ImagePath = App.Path + 'Images';
    App.ServicePath = App.Path + 'Services';
});

/*****************************************************************************/
/********************** SERVICIOS DE CATÁLOGOS *******************************/
/*****************************************************************************/
function CatalogInfo() {
    this.Identity = ko.observable(0);
    this.Code = ko.observable("");
    this.Active = ko.observable(false);
    this.IdBranch = 0;
    this.IdCompany = 0;
    this.LastUpdate = "";
    this.CreateDate = "";
    this.PCUpdate = "";
    this.ActivateDate = "";
    this.DeactivateDate = "";
    this.UserCreate = 0;
    this.UserUpdate = 0;
    this.SessionID = "";
}
CatalogInfo.prototype.MapFields = function (info) {
    this.Identity(info.Identity);
    this.Code(info.Code);
    this.Active(info.Active);
    this.IdBranch = info.IdBranch;
    this.IdCompany = info.IdCompany;
    this.LastUpdate = info.LastUpdate;
    this.CreateDate = info.CreateDate;
    this.ActivateDate = info.ActivateDate;
    this.DeactivateDate = info.DeactivateDate;
    this.PCUpdate = info.PCUpdate;
    this.UserCreate = info.UserCreate;
    this.UserUpdate = info.UserUpdate;
    this.SessionID = info.SessionID;
}

function CatalogService(config) {
    this.WebService = config.WebService;
    this.Config = config;        
}

CatalogService.prototype.Create = function () {
    var data = { 'sessionID': App.Session.SessionID }
    var thisService = this;
    return $.ajax({
        type: "POST",
        url: App.ServicePath + '/' + this.Config.WebService + '/Create',
        data: JSON.stringify(data),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var Result = $.parseJSON(msg);
            if (thisService.Config.CreateCallback != undefined) thisService.Config.CreateCallback(Result);
        },
        error: function (e) {
            var Error = { message: e.responseText };
            if (thisService.Config.ErrorCallback != undefined) thisService.Config.ErrorCallback(Error, "Create");
        }
    });
}

CatalogService.prototype.Update = function (info) {
    if (info.IdCompany == 0) info.IdCompany = App.DefaultCompany.Identity;
    if (info.IdBranch == 0) info.IdBranch = App.DefaultBranch.Identity;

    var strInfo = JSON.stringify(info);
    var data = { 'sessionID': App.Session.SessionID, 'info': strInfo }
    var thisService = this;
    return $.ajax({
        type: "POST",
        url: App.ServicePath + '/' + this.Config.WebService + '/Update',
        data: JSON.stringify(data),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var Result = $.parseJSON(msg);
            if (thisService.Config.UpdateCallback != undefined) thisService.Config.UpdateCallback(Result);
        },
        error: function (e, textStatus, error) {
            var Error = { message: e.responseText };
            if (thisService.Config.ErrorCallback != undefined) thisService.Config.ErrorCallback(Error, "Update");
        }
    });
}

CatalogService.prototype.ChangeStatus = function (itemID, active) {
    var data = { 'sessionID': App.Session.SessionID, 'itemID': itemID, 'active': active }
    var thisService = this;
    return $.ajax({
        type: "POST",
        url: App.ServicePath + '/' + this.Config.WebService + '/ChangeStatus',
        data: JSON.stringify(data),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            if (thisService.Config.ChangeStatusCallback != undefined) thisService.Config.ChangeStatusCallback();
        },
        error: function (e) {
            var Error = { message: e.responseText };
            if (thisService.Config.ErrorCallback != undefined) thisService.Config.ErrorCallback(Error, "ChangeStatus");
        }
    });
}

CatalogService.prototype.GetDetailByID = function (itemID, checkStatus) {
    var data = { 'sessionID': App.Session.SessionID, 'itemID': itemID, 'checkStatus': checkStatus }
    var thisService = this;
    return $.ajax({
        type: "POST",
        url: App.ServicePath + '/' + this.Config.WebService + '/GetDetailByID',
        data: JSON.stringify(data),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var Result = $.parseJSON(msg);
            if (thisService.Config.GetDetailCallback != undefined) thisService.Config.GetDetailCallback(Result);
        },
        error: function (e) {
            var Error = { message: e.responseText };
            if (thisService.Config.ErrorCallback != undefined) thisService.Config.ErrorCallback(Error, "GetDetailByID");
        }
    });
}

CatalogService.prototype.GetDetailByCode = function (idBranch, code, checkStatus) {
    var data = { 'sessionID': App.Session.SessionID, 'idBranch': idBranch, 'code': code, 'checkStatus': checkStatus }
    var thisService = this;
    return $.ajax({
        type: "POST",
        url: App.ServicePath + '/' + this.Config.WebService + '/GetDetailByCode',
        data: JSON.stringify(data),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var Result = $.parseJSON(msg);
            if (thisService.Config.GetDetailCallback != undefined) thisService.Config.GetDetailCallback(Result);
        },
        error: function (e) {
            var Error = { message: e.responseText };
            if (thisService.Config.ErrorCallback != undefined) thisService.Config.ErrorCallback(Error, "GetDetailByCode");
        }
    });
}

CatalogService.prototype.GetDetailFromCache = function (itemID) {
    var data = { 'sessionID': App.Session.SessionID, 'itemID': itemID }
    var thisService = this;
    return $.ajax({
        type: "POST",
        url: App.ServicePath + '/' + this.Config.WebService + '/GetDetailFromCache',
        data: JSON.stringify(data),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var Result = $.parseJSON(msg);
            if (thisService.Config.GetDetailCallback != undefined) thisService.Config.GetDetailCallback(Result);
        },
        error: function (e) {
            var Error = { message: e.responseText };
            if (thisService.Config.ErrorCallback != undefined) thisService.Config.ErrorCallback(Error, "GetDetailFromCache");
        }
    });
}

CatalogService.prototype.Delete = function (itemID) {
    var data = { 'sessionID': App.Session.SessionID, 'itemID': itemID }
    var thisService = this;
    return $.ajax({
        type: "POST",
        url: App.ServicePath + '/' + this.Config.WebService + '/Delete',
        data: JSON.stringify(data),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {            
            if (thisService.Config.DeleteCallback != undefined) thisService.Config.DeleteCallback();
        },
        error: function (e) {
            var Error = { message: e.responseText };
            if (thisService.Config.ErrorCallback != undefined) thisService.Config.ErrorCallback(Error, "Delete");
        }
    });
}

CatalogService.prototype.GetTotalRecords = function (idBranch, conditions) {
    var data = { 'sessionID': App.Session.SessionID, 'idBranch': idBranch, 'conditions': conditions }
    var thisService = this;
    return $.ajax({
        type: "POST",
        url: App.ServicePath + '/' + this.Config.WebService + '/GetTotalRecords',
        data: JSON.stringify(data),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var Result = $.parseJSON(msg);
            if (thisService.Config.GetTotalRecordsCallback != undefined) thisService.Config.GetTotalRecordseCallback(Result);
        },
        error: function (e) {
            var Error = { message: e.responseText };
            if (thisService.Config.ErrorCallback != undefined) thisService.Config.ErrorCallback(Error, "GetTotalRecords");
        }
    });
}

CatalogService.prototype.Search = function (idBranch, conditions, sortOrder, page) {
    var strSortOrder = JSON.stringify(sortOrder);
    var strCondiciones = JSON.stringify(conditions);
    var data = { 'sessionID': App.Session.SessionID, 'idBranch': idBranch, 'conditions': strCondiciones, 'sortOrder': strSortOrder, 'page': page }
    var thisService = this;
    return $.ajax({
        type: "POST",
        url: App.ServicePath + '/' + this.Config.WebService + '/Search',
        data: JSON.stringify(data),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var Result = $.parseJSON(msg);
            if (thisService.Config.SearchCallback != undefined) thisService.Config.SearchCallback(Result);
        },
        error: function (e) {
            var Error = { message: e.responseText };
            if (thisService.Config.ErrorCallback != undefined) thisService.Config.ErrorCallback(Error, "Search");
        }
    });
}

CatalogService.prototype.CallServiceMethod = function (method, params) {
    return $.ajax({ type: "POST", url: App.ServicePath + "/" + this.Config.WebService + '/' + method, data: JSON.stringify(params), contentType: "application/json; charset=utf-8", dataType: "json",
        success: function (msg) {
        },
        error: function (e) {
        }
    });
}

/*****************************************************************************/
/********************** SERVICIOS DE JERARQUÍAS *******************************/
/*****************************************************************************/
function HierarchyInfo() {
    var self = this;
    this.Nombre = ko.observable("");
    this.IdPadre = ko.observable(0);
    this.Orden = ko.observable(0);
    this.Nivel = 0;
    this.Path = "";
    this.NamedPath = ko.observable("");
}
HierarchyInfo.prototype = new CatalogInfo();

HierarchyInfo.prototype.MapFields = function (info) {
    this.Nombre(info.Nombre);
    this.IdPadre(info.IdPadre);
    this.Orden(info.Orden);
    this.Nivel = info.Nivel;
    this.Path = info.Path;
    this.NamedPath(info.NamedPath);
    CatalogInfo.prototype.MapFields.call(this, info);
}

function HierarchyService(config) {
    var self = this;
    self.WebService = config.WebService;    
    self.Config = config;        
}
HierarchyService.prototype = new CatalogService({ WebService: '' });

HierarchyService.prototype.LoadChildren = function (idCompany, idParent) {
    var self = this;
    var data = { 'sessionID': App.Session.SessionID, 'idCompany': idCompany, 'idParent': idParent }    
    return self.CallServiceMethod("LoadChildren", data);
}

HierarchyService.prototype.MoveNode = function (idNode, idTargetParent, order) {
    var self = this;
    var data = { 'sessionID': App.Session.SessionID, 'idNode': idNode, 'idTargetParent': idTargetParent, 'order': order }
    return self.CallServiceMethod("MoveNode", data);
}

HierarchyService.prototype.CreateAndSave = function (idParent) {
    var self = this;
    var data = { 'sessionID': App.Session.SessionID, 'idParent': idParent, 'idCompany': App.DefaultCompany.Identity }
    return self.CallServiceMethod("CreateAndSave", data);
}

/****************************************************************/
/******************* GENERAL ************************************/
/****************************************************************/

Kernel.General = {}


//Catálogo de paises
Kernel.General.PaisInfo= function() {
    this.Nombre = ko.observable("");    
}
Kernel.General.PaisInfo.prototype = new CatalogInfo();
Kernel.General.PaisService = function () {    
    var self = this;    
    this.LoadList = function () {
        var data = { 'sessionID': App.Session.SessionID }
        return self.CallServiceMethod("LoadList", data);
    }
}
Kernel.General.PaisService.prototype = new CatalogService({WebService: "Kernel/General/Pais.svc"});


//Catálogo de Estados
Kernel.General.EstadoInfo=function() {
    this.Nombre = ko.observable("");
    this.IdPais = ko.observable(0);
}
Kernel.General.EstadoInfo.prototype = new CatalogInfo();
Kernel.General.EstadoService = function () {
    var self = this;
    this.LoadList = function (idPais) {
        var data = { 'sessionID': App.Session.SessionID, 'idPais': idPais }
        return self.CallServiceMethod("LoadList", data);
    }
}
Kernel.General.EstadoService.prototype = new CatalogService({ WebService: 'Kernel/General/Estado.svc' });


//Catálogo de municipios
Kernel.General.MunicipioInfo = function () {
    var self = this;
    this.Nombre = ko.observable("");
    this.IdEstado = ko.observable(0);
    this.Estado = {}
    this.Estado.IdPais = ko.observable(0);
}
Kernel.General.MunicipioInfo.prototype = new CatalogInfo();
Kernel.General.MunicipioService = function () {
    var self = this;
    this.LoadList = function (idEstado) {
        var data = { 'sessionID': App.Session.SessionID, 'idEstado': idEstado }        
        return self.CallServiceMethod("LoadList", data);
    }
}
Kernel.General.MunicipioService.prototype = new CatalogService({ WebService: 'Kernel/General/Municipio.svc' });

//Catálogo de poblaciones
Kernel.General.PoblacionInfo = function () {
    var self = this;
    this.Nombre = ko.observable("");
    this.IdMunicipio = ko.observable(0);
    this.Municipio = {}
    this.Municipio.IdEstado = ko.observable(0);
    this.Municipio.Estado = {}
    this.Municipio.Estado.IdPais = ko.observable(0);
}
Kernel.General.PoblacionInfo.prototype = new CatalogInfo();
Kernel.General.PoblacionService = function () {
    var self = this;
    this.LoadList = function (idMunicipio) {
        var data = { 'sessionID': App.Session.SessionID, 'idMunicipio': idMunicipio }
        return self.CallServiceMethod("LoadList", data);
    }
}
Kernel.General.PoblacionService.prototype = new CatalogService({ WebService: 'Kernel/General/Poblacion.svc' });

//Domicilio
Kernel.General.DomicilioInfo = function () {
    var self = this;
    this.Calle = ko.observable('');
    this.NumeroExterior = ko.observable('');
    this.NumeroInterior = ko.observable('');
    this.Colonia = ko.observable('');
    this.CP = ko.observable('');
    this.Cruce1 = ko.observable('');
    this.Cruce2 = ko.observable('');
    this.IdPoblacion = ko.observable(0);
    this.MapFields = function (info) {
        self.Calle(info.Calle);
        self.NumeroExterior(info.NumeroExterior);
        self.NumeroInterior(info.NumeroInterior);
        self.Colonia(info.Colonia);
        self.CP(info.CP);
        self.Cruce1(info.Cruce1);
        self.Cruce2(info.Cruce2);
        self.IdPoblacion(info.IdPoblacion);
    }
}

//Personas
Kernel.General.PersonaInfo = function () {
    var self = this;
    this.Nombre = ko.observable('');
    this.ApellidoPaterno = ko.observable('');
    this.ApellidoMaterno = ko.observable('');
    this.TelefonoCasa = ko.observable('');
    this.TelefonoOficina = ko.observable('');
    this.Correo = ko.observable('');
    this.Celular = ko.observable('');
    this.Sexo = ko.observable('M');
    this.Domicilio = new Kernel.General.DomicilioInfo();
    this.MapFields = function (info) {
        self.Nombre(info.Nombre)
        self.ApellidoPaterno(info.ApellidoPaterno);
        self.ApellidoMaterno(info.ApellidoMaterno);
        self.TelefonoCasa(info.TelefonoCasa);
        self.TelefonoOficina(info.TelefonoOficina);
        self.Correo(info.Correo);
        self.Celular(info.Celular);
        self.Sexo(info.Sexo);
        self.Domicilio.MapFields(info.Domicilio);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Kernel.General.PersonaInfo.prototype = new CatalogInfo();

/****************************************************************/
/******************* Security ************************************/
/****************************************************************/

Kernel.Security = {}

//Empresas
Kernel.Security.EmpresaInfo = function () {
    var self = this;
    this.Nombre = ko.observable("");
    this.NombreLargo = ko.observable("");
    this.RFC = ko.observable("");
    this.RazonSocial = ko.observable("");
    this.Calle = ko.observable("");
    this.NumExt = ko.observable("");
    this.NumInt = ko.observable("");
    this.Colonia = ko.observable("");
    this.CP = ko.observable("");
    this.IdPoblacion = ko.observable(0);

    this.MapFields = function (info) {
        self.Nombre(info.Nombre);
        self.RFC(info.RFC);
        self.RazonSocial(info.RazonSocial);
        self.Calle(info.Calle);
        self.NumExt(info.NumExt);
        self.NumInt(info.NumInt);
        self.Colonia(info.Colonia);
        self.CP(info.CP);
        self.IdPoblacion(info.IdPoblacion);                    
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Kernel.Security.EmpresaInfo.prototype = new CatalogInfo();
Kernel.Security.EmpresaService = function () {
    var self = this;
    this.CargarSucursales = function (idEmpresa) {
        var data = { 'sessionID': App.Session.SessionID, 'idEmpresa': idEmpresa }
        return self.CallServiceMethod("LoadSucursalesList", data);
    }
}
Kernel.Security.EmpresaService.prototype = new CatalogService({ WebService: 'Kernel/Security/Empresa.svc' });


//Sucursales
Kernel.Security.SucursalInfo = function () {
    var self = this;
    this.Nombre = ko.observable("");
    this.Telefono1 = ko.observable("");
    this.Telefono2 = ko.observable("");
    this.Fax = ko.observable("");
    this.PaginaWeb = ko.observable("");
    this.Correo = ko.observable("");
    this.Calle = ko.observable("");
    this.Colonia = ko.observable("");
    this.CP = ko.observable("");
    this.NumExt = ko.observable("");
    this.NumInt = ko.observable("");
    this.IdPoblacion = ko.observable(0);
    this.Empresa = new Kernel.Security.EmpresaInfo();
    this.MapFields = function (info) {
        self.Nombre(info.Nombre);        
        self.Telefono1(info.Telefono1);
        self.Telefono2(info.Telefono2);
        self.Fax(info.Fax);
        self.PaginaWeb(info.PaginaWeb);
        self.Correo(info.Correo);
        self.Calle(info.Calle);
        self.NumExt(info.NumExt);
        self.NumInt(info.NumInt);
        self.Colonia(info.Colonia);
        self.CP(info.CP);
        self.IdPoblacion(info.IdPoblacion);
        self.Empresa.MapFields(info.Empresa);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Kernel.Security.SucursalInfo.prototype = new CatalogInfo();
Kernel.Security.SucursalService = function () {
    var self = this;
    this.LoadList = function (idEmpresa) {
        var data = { 'sessionID': App.Session.SessionID, 'idEmpresa': idEmpresa }
        return self.CallServiceMethod("LoadList", data);
    }

    this.LoadListByUser = function (idEmpresa, idUsuario) {
        var data = { 'sessionID': App.Session.SessionID, 'idEmpresa': idEmpresa, 'idUsuario': idUsuario }
        return self.CallServiceMethod("LoadListByUser", data);
    }

    this.LoadUserList = function (idSucursal) {
        var data = { 'sessionID': App.Session.SessionID, 'idSucursal': idSucursal }
        return self.CallServiceMethod("LoadUserList", data);
    }

    this.AddUser = function (idSucursal, idUsuario) {
        var data = { 'sessionID': App.Session.SessionID, 'idSucursal': idSucursal, 'idUsuario': idUsuario }
        return self.CallServiceMethod("AddUser", data);
    }

    this.RemoveUser = function (idSucursal, idUsuario) {
        var data = { 'sessionID': App.Session.SessionID, 'idSucursal': idSucursal, 'idUsuario': idUsuario }
        return self.CallServiceMethod("RemoveUser", data);
    }

}
Kernel.Security.SucursalService.prototype = new CatalogService({ WebService: 'Kernel/Security/Sucursal.svc' });

//Usuarios
Kernel.Security.UsuarioInfo = function () {
    var self = this;
    this.UserName = ko.observable('');
    this.Password = ko.observable('');
    this.DomainUser = ko.observable('');
    this.IdPersona = ko.observable(0);
    this.Persona = new Kernel.General.PersonaInfo();
    this.MapFields = function (info) {
        self.UserName(info.UserName);
        self.Password(info.Password);        
        self.DomainUser(info.DomainUser);
        self.IdPersona(info.IdPersona);
        self.Persona.MapFields(info.Persona);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Kernel.Security.UsuarioInfo.prototype = new CatalogInfo();
Kernel.Security.UsuarioService = function () {
    var self = this;
    this.Login = function (userName, password, workStation) {
        var data = { 'userName': userName, 'password': password, 'workStation': workStation }
        return self.CallServiceMethod("LogIn", data);
    }

    this.LogOut = function () {
        var data = { 'sessionID': App.Session.SessionID }
        return self.CallServiceMethod("LogOut", data);
    }

    this.LoadGroups = function (idUsuario) {
        var data = { 'sessionID': App.Session.SessionID, 'idUsuario': idUsuario }
        return self.CallServiceMethod("LoadGroups", data);
    }

    this.AddGroup = function (idUsuario, idGrupo) {
        var data = { 'sessionID': App.Session.SessionID, 'idUsuario': idUsuario, 'idGrupo': idGrupo }
        return self.CallServiceMethod("AddGroup", data);
    }

    this.RemoveGroup = function (idUsuario, idGrupo) {
        var data = { 'sessionID': App.Session.SessionID, 'idUsuario': idUsuario, 'idGrupo': idGrupo }
        return self.CallServiceMethod("RemoveGroup", data);
    }

    this.LoadBranchAccess = function (idUsuario) {
        var data = { 'sessionID': App.Session.SessionID, 'idUsuario': idUsuario }
        return self.CallServiceMethod("LoadBranchAccess", data);
    }

    this.AddBranch = function (idUsuario, idSucursal) {
        var data = { 'sessionID': App.Session.SessionID, 'idUsuario': idUsuario, 'idSucursal': idSucursal }
        return self.CallServiceMethod("AddBranch", data);
    }

    this.RemoveBranch = function (idUsuario, idSucursal) {
        var data = { 'sessionID': App.Session.SessionID, 'idUsuario': idUsuario, 'idSucursal': idSucursal }
        return self.CallServiceMethod("RemoveBranch", data);
    }

    this.SaveBranchAccess = function (idUsuario, accesos) {
        var data = { 'sessionID': App.Session.SessionID, 'idUsuario': idUsuario, accesos: accesos }
        return self.CallServiceMethod("SaveBranchAccess", data);
    }

}
Kernel.Security.UsuarioService.prototype = new CatalogService({ WebService: 'Kernel/Security/Usuario.svc' });

//Grupos de usuarios
Kernel.Security.GrupoInfo = function () {
    var self = this;
    this.Nombre = ko.observable('');
    this.MapFields = function (info) {
        self.Nombre(info.Nombre);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Kernel.Security.GrupoInfo.prototype = new CatalogInfo();
Kernel.Security.GrupoService = function () {
    var self = this;

    this.AddUser = function (idGrupo, idUsuario) {
        var data = { 'sessionID': App.Session.SessionID, 'idGrupo': idGrupo, 'idUsuario': idUsuario }
        return self.CallServiceMethod("AddUser", data);
    }

    this.RemoveUser = function (idGrupo, idUsuario) {
        var data = { 'sessionID': App.Session.SessionID, 'idGrupo': idGrupo, 'idUsuario': idUsuario }
        return self.CallServiceMethod("RemoveUser", data);
    }

    this.LoadUsers = function (idGrupo) {
        var data = { 'sessionID': App.Session.SessionID, 'idGrupo': idGrupo}
        return self.CallServiceMethod("LoadUsers", data);
    }
}
Kernel.Security.GrupoService.prototype = new CatalogService({ WebService: 'Kernel/Security/Grupo.svc' });

//Modulos
Kernel.Security.ModuloInfo = function () {
    var self = this;
    this.Descripcion = ko.observable('');
    this.ImageFile = ko.observable('');
    this.IdModuloCategoria = ko.observable(0);
    this.MapFields = function (info) {
        self.Descripcion(info.Descripcion);
        self.ImageFile(info.ImageFile);
        self.IdModuloCategoria(info.IdModuloCategoria);
        HierarchyInfo.prototype.MapFields.call(self, info);
    }
}
Kernel.Security.ModuloInfo.prototype = new HierarchyInfo();
Kernel.Security.ModuloService = function () {
    var self = this;

    this.LoadCategories = function () {
        var data = { 'sessionID': App.Session.SessionID }
        return self.CallServiceMethod("LoadCategoriesList", data);
    }

}
Kernel.Security.ModuloService.prototype = new HierarchyService({ WebService: 'Kernel/Security/Modulo.svc' });

//Procesos
Kernel.Security.ProcesoInfo = function () {
    var self = this;
    this.Nombre = ko.observable('');
    this.IdModulo = ko.observable(0);
    this.Descripcion = ko.observable('');
    this.IdTipoProceso = ko.observable(0);
    this.Orden = ko.observable('');
    this.ImageFile = ko.observable('');

    this.MapFields = function (info) {
        self.Nombre(info.Nombre);
        self.IdModulo(info.IdModulo);
        self.Descripcion(info.Descripcion);
        self.IdTipoProceso(info.IdTipoProceso);
        self.Orden(info.Orden);
        self.ImageFile(info.ImageFile);
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Kernel.Security.ProcesoInfo.prototype = new CatalogInfo();

Kernel.Security.ProcesoService = function () {
    var self = this;
}
Kernel.Security.ProcesoService.prototype = new CatalogService({ WebService: 'Kernel/Security/Proceso.svc' });