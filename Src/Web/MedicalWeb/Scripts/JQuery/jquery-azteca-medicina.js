Business.Medicina = {}

//PACIENTES
/////////////////////////////////////////////////////////////////////////////
Business.Medicina.PacienteInfo = function () {
    var self = this;
    this.Sexo = ko.observable(0);
    this.FechaNacimiento = ko.observable(0);    
    this.IdUltimoDoctor = ko.observable(0);
    this.Ocupacion = ko.observable('');
    this.Afiliado = ko.observable(0);
    this.Diagnostico = ko.observable('');
    this.PrimerConsulta = ko.observable(0);
    this.UltimaConsulta = ko.observable(0);
    this.IdCliente = ko.observable(0);
    this.Cliente = new Business.Ventas.ClienteInfo();
    //this.Cliente = {}
    //General
    this.Cliente.Nombre = ko.observable('');
    this.Cliente.Calle = ko.observable('');
    this.Cliente.Cruce1 = ko.observable('');
    this.Cliente.Cruce2 = ko.observable('');
    this.Cliente.NumExt = ko.observable('');
    this.Cliente.NumInt = ko.observable('');
    this.Cliente.Colonia = ko.observable('');
    this.Cliente.CP = ko.observable('');
    this.Cliente.IdPoblacion = ko.observable(0);
    this.Cliente.Latitud = ko.observable(0);
    this.Cliente.Longitud = ko.observable(0);
    this.Cliente.Telefonos = ko.observable('');
    this.Cliente.Fax = ko.observable('');
    this.Cliente.Correo = ko.observable('');
    this.Cliente.PagWeb = ko.observable('');
    //Facturacion
    this.Cliente.Facturable = ko.observable(1);
    this.Cliente.RFC = ko.observable('');
    this.Cliente.RazonSocial = ko.observable('');
    this.Cliente.CalleFiscal = ko.observable('');
    this.Cliente.NumExtFiscal = ko.observable('');
    this.Cliente.NumIntFiscal = ko.observable('');
    this.Cliente.ColoniaFiscal = ko.observable('');
    this.Cliente.CPFiscal = ko.observable('');
    this.Cliente.IdPoblacionFiscal = ko.observable(0);
    this.Cliente.IdComprobanteAddenda = ko.observable(0);
    this.Cliente.GLN = ko.observable('');
    this.Cliente.GLNTienda = ko.observable('');
    this.Cliente.NumProveedor = ko.observable(0);
    //Ventas
    this.Cliente.CondicionesPago = ko.observable(0);
    this.Cliente.IdListaPrecio = ko.observable(1);
    this.Cliente.IdGrupoDescuentos = ko.observable(0);
    this.Cliente.IdGama = ko.observable(0);
    this.Cliente.LimiteCredito = ko.observable(0);
    this.Cliente.DiasCredito = ko.observable(0);
    this.Cliente.IdMetodoPago = ko.observable(0);
    this.Cliente.CuentaPago = ko.observable('');
    //Contabilidad
    //this.IdCuentaContable  = ko.observable(0);
    //this.WebPassword  = ko.observable('');

    this.MapFields = function (info) {
        self.Sexo(info.Sexo);
        self.FechaNacimiento(info.FechaNacimiento);
        self.IdUltimoDoctor(info.IdUltimoDoctor);
        self.Ocupacion(info.Ocupacion);
        self.Afiliado(info.Afiliado);
        self.Diagnostico(info.Diagnostico);
        self.PrimerConsulta(info.PrimerConsulta);
        self.UltimaConsulta(info.UltimaConsulta);
        self.IdCliente(info.IdCliente);
        self.Cliente.MapFields(info.Cliente);        
        CatalogInfo.prototype.MapFields.call(self, info);
    }
}
Business.Medicina.PacienteInfo.prototype = new CatalogInfo();

Business.Medicina.PacienteService = function () {
    var self = this;

    this.SearchKeyword = function (keyword) {
        var data = { 'sessionID': App.Session.SessionID, 'keyword': keyword }
        return self.CallServiceMethod("SearchKeyword", data);
    }

    this.GuardarRegistro = function (idExpediente, idDoctor, idPaciente, diagnostico, medicina, motivo, generales, observaciones, tratamiento) {
        var data = { 'sessionID': App.Session.SessionID, 'idExpediente': idExpediente, 'idDoctor': idDoctor, 'idPaciente': idPaciente, 'diagnostico': diagnostico, 'medicina': medicina, 'motivo': motivo, 'generales': generales, 'observaciones': observaciones, 'tratamiento': tratamiento }
        return self.CallServiceMethod("GuardarRegistro", data);
    }

    this.LoadRegistros = function (idPaciente) {
        var data = { 'sessionID': App.Session.SessionID, 'idPaciente': idPaciente }
        return self.CallServiceMethod("LoadRegistros", data);
    }


}
Business.Medicina.PacienteService.prototype = new CatalogService({ WebService: 'Medicina/Paciente.svc' });

//SALAS
/////////////////////////////////////////////////////////////////////////////
Business.Medicina.SalaInfo = function () {
    var self = this;
    this.Nombre = ko.observable('');
    this.TiempoAtencion = ko.observable(0);
    this.MapFields = function (info) {
        self.Nombre(info.Nombre);
        self.TiempoAtencion(info.TiempoAtencion);
        CatalogInfo.prototype.MapFields.call(self, info);
    }

}
Business.Medicina.SalaInfo.prototype = new CatalogInfo();

Business.Medicina.SalaService = function () {
    var self = this;

    this.LoadList = function () {
        var data = { 'sessionID': App.Session.SessionID }
        return self.CallServiceMethod("LoadList", data);
    }

    this.AgendarEvento = function (evento) {
        var jsonEvent = JSON.stringify(evento);
        var data = { 'sessionID': App.Session.SessionID, 'evento': jsonEvent }
        return self.CallServiceMethod("AgendarEvento", data);
    }

    this.CargarAgenda = function (idSala) {
        var data = { 'sessionID': App.Session.SessionID, 'idSala': idSala }
        return self.CallServiceMethod("CargarAgenda", data);
    }

    this.EliminarEvento = function (idEvento) {
        var data = { 'sessionID': App.Session.SessionID, 'idEvento': idEvento }
        return self.CallServiceMethod("EliminarEvento", data);
    }

    this.AddUser = function (idSala, idUsuario, Entrada, Salida) {
        var data = { 'sessionID': App.Session.SessionID, 'idSala': idSala, 'idUsuario': idUsuario }
        return self.CallServiceMethod("AddUser", data);
    }

    this.UpdateUser = function (idSala, idUsuario, entrada, salida) {
        var data = { 'sessionID': App.Session.SessionID, 'idSala': idSala, 'idUsuario': idUsuario }
        return self.CallServiceMethod("UpdateUser", data);
    }

    this.RemoveUser = function (idSala, idUsuario) {
        var data = { 'sessionID': App.Session.SessionID, 'idSala': idSala, 'idUsuario': idUsuario }
        return self.CallServiceMethod("RemoveUser", data);
    }

    this.LoadUserAccess = function (idSala) {
        var data = { 'sessionID': App.Session.SessionID, 'idSala': idSala }
        return self.CallServiceMethod("LoadUserAccess", data);
    }

}

Business.Medicina.SalaService.prototype = new CatalogService({ WebService: 'Medicina/Sala.svc' });


//DOCTORES
/////////////////////////////////////////////////////////////////////////////

Business.Medicina.DoctorInfo = function () {
    var self = this;
    this.Nombre = ko.observable('');
    this.Calle = ko.observable('');
    this.NumExt = ko.observable('');
    this.NumInt = ko.observable('');
    this.Colonia = ko.observable('');
    this.CP = ko.observable('');
    this.IdPoblacion = ko.observable(0);
    this.Telefono = ko.observable('');
    this.TelCasa = ko.observable('');
    this.Celular = ko.observable('');
    this.Correo = ko.observable('');
    this.IdEspecialidad = ko.observable(0);
    this.RFC = ko.observable('');
    this.Cedula = ko.observable('');
    this.IdUsuario = ko.observable(0);
    this.MapFields = function (info) {
        self.Nombre(info.Nombre);
        self.Calle(info.Calle);
        self.NumExt(info.NumExt);
        self.NumInt(info.NumInt);
        self.Colonia(info.Colonia);
        self.CP(info.CP);
        self.IdPoblacion(info.IdPoblacion);
        self.Telefono(info.Telefono);
        self.TelCasa(info.TelCasa);
        self.Celular(info.Celular);
        self.Correo(info.Correo);
        self.IdEspecialidad(info.IdEspecialidad);
        self.RFC(info.RFC);
        self.Cedula(info.Cedula);
        self.IdUsuario(info.IdUsuario);
        CatalogInfo.prototype.MapFields.call(self, info);
    }

}
Business.Medicina.DoctorInfo.prototype = new CatalogInfo();

Business.Medicina.DoctorService = function () {
    var self = this;

    this.SearchKeyword = function (keyword) {
        var data = { 'sessionID': App.Session.SessionID, 'keyword': keyword }
        return self.CallServiceMethod("SearchKeyword", data);
    }

    this.CargarEspecialidades = function () {
        var data = { 'sessionID': App.Session.SessionID }
        return self.CallServiceMethod("CargarEspecialidades", data);
    }

    this.GetDoctorByUser = function () {
        var data = { 'sessionID': App.Session.SessionID, 'idUsuario': 0 }
        return self.CallServiceMethod("GetDoctorByUser", data);
    }
}

Business.Medicina.DoctorService.prototype = new CatalogService({ WebService: 'Medicina/Doctor.svc' });