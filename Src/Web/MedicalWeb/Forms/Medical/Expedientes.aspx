<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Expedientes.aspx.vb" Inherits="Azteca.Web.Expedientes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Expediente clínico</title>
    <!--THEME-->
    <link href="http://code.jquery.com/ui/1.10.3/themes/south-street/jquery-ui.min.css" class="cssTheme"
        rel="stylesheet" type="text/css" />    
    <!--Wijmo Widgets CSS-->
    <link href="http://cdn.wijmo.com/jquery.wijmo-pro.all.3.20132.8.min.css" rel="stylesheet" type="text/css" />    
    <link href="../../Styles/wijgrid.css" rel="Stylesheet" type="text/css" />
    <link href="../../Styles/wijtabs.css" rel="Stylesheet" type="text/css" />
    <!--AZTECA-->
    <link href="../../Styles/jquery-ui-form.css" rel="stylesheet" type="text/css" />
    <link href="../../Styles/jquery-ui-widgets.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <!--jQuery-->  
    <script src="http://ajax.aspnetcdn.com/ajax/jquery/jquery-1.9.1.min.js" type="text/javascript"></script>   
    <script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.10.1/jquery-ui.min.js" type="text/javascript"></script>
    <script src="../../../Scripts/Json/json2.js" type="text/javascript"></script>
    <!--jQuery Validate--> 
    <script src="http://ajax.aspnetcdn.com/ajax/jquery.validate/1.11.1/jquery.validate.min.js" type="text/javascript"></script>    
    <!--Wijmo Widgets JavaScript-->    
    <script src="http://cdn.wijmo.com/jquery.wijmo-open.all.3.20132.8.min.js" type="text/javascript"></script>
    <script src="http://cdn.wijmo.com/jquery.wijmo-pro.all.3.20132.8.min.js" type="text/javascript"></script>    
    <!--Knockout-->
    <script src="http://cdn.wijmo.com/wijmo/external/knockout-2.2.0.js" type="text/javascript"></script>    
    <script src="http://cdn.wijmo.com/external/knockout.wijmo.js" type="text/javascript"></script>    
    <!--AZTECA-->
    <script src="../../Scripts/JQuery/jquery-azteca-kernel.js?<%=ScriptsVersion%>" type="text/javascript"></script>    
    <script src="../../Scripts/JQueryUI/jquery-ui-widgets.js?<%=ScriptsVersion%>" type="text/javascript"></script>
    <script src="../../Scripts/JQueryUI/jquery-ui-azteca-kernel.js" type="text/javascript"></script>
    <script src="../../Scripts/JQuery/jquery-azteca-ventas.js" type="text/javascript"></script>
    <script src="../../Scripts/JQuery/jquery-azteca-medicina.js" type="text/javascript"></script>    
    <script src="../../Scripts/JQueryUI/jquery-ui-azteca-medicina.js" type="text/javascript"></script>
    <!--GLOBALIZE-->
    <script src="../../Scripts/globalize.js" type="text/javascript"></script>
    <script src="../../Scripts/cultures/globalize.cultures.js" type="text/javascript"></script>
    <script type="text/javascript">

        function Registro (idExpediente, idDoctor, doctor, diagnostico, medicina, motivo, generales, observaciones, tratamiento) {
            var fecha = new Date();
            this.IdExpediente = ko.observable(idExpediente);
            this.FechaStr = ko.observable(Globalize.format(fecha, "d", "es-MX") + ' ' + Globalize.format(fecha, "t", "es-MX"));
            this.Fecha = ko.observable(fecha.getTime());
            this.IdDoctor = ko.observable(idDoctor);
            this.Doctor = ko.observable(doctor);
            this.Diagnostico = ko.observable(diagnostico);
            this.Medicina = ko.observable(medicina);
            this.Motivo = ko.observable(motivo);
            this.Generales = ko.observable(generales);
            this.Observaciones = ko.observable(observaciones);
            this.Tratamiento = ko.observable(tratamiento);
        }

        var ViewModel = function () {
            var self = this;

            this.PacienteSvc = new Business.Medicina.PacienteService();
            this.PacienteInf = new Business.Medicina.PacienteInfo();
            this.DoctorSvc = new Business.Medicina.DoctorService();
            this.CurrentDoctor = new Business.Medicina.DoctorInfo();
            this.IdPaciente = 0;
            this.Registros = ko.observableArray([]);

            this.CargarRegistros = function () {
                self.PacienteSvc.LoadRegistros(self.IdPaciente)
                    .done(function (data) {
                        var List = $.parseJSON(data);
                        self.Registros(List);
                    })
                    .fail(function (ex, error) {
                        $('#msgbox').msgbox('show', { title: "Error", message: error, icon: "error", okButton: true });
                    });
            }

            this.SaveRegistro = function (registro) {
                self.PacienteSvc.GuardarRegistro(registro.IdExpediente(), registro.IdDoctor(), self.IdPaciente, registro.Diagnostico(), registro.Medicina(), registro.Motivo(), registro.Generales(), registro.Observaciones(), registro.Tratamiento())
                    .done(function (data) {
                        var localRegister = self.FindRegistro();

                        if (localRegister == null) {
                            registro.IdExpediente(data);
                            self.Registros.push(ko.toJS(registro));
                        }
                        else {
                            localRegister.IdExpediente = data;
                            localRegister.Diagnostico = registro.Diagnostico();
                            localRegister.Medicina = registro.Medicina();
                            localRegister.Motivo = registro.Motivo();
                            localRegister.Generales = registro.Generales();
                            localRegister.Observaciones = registro.Observaciones();
                            localRegister.Tratamiento = registro.Tratamiento();
                        }

                        $('#dlgAddRecord').dialog('close');
                    })
                    .fail(function (ex, error) {
                        $('#msgbox').msgbox('show', { title: "Error", message: error, icon: "error", okButton: true });
                    });
            }

            this.RemoveRegistro = function (registro) {
                self.Registros.remove(registro);
            }

            this.DisplayRegistro = function (index) {
                var Registro = self.Registros()[index];
                $('#lblFecha').text(Registro.FechaStr);
                $('#lblDoctor').text(Registro.Doctor);
                $('#txtDiagnosticoView').val(Registro.Diagnostico);
                $('#txtMedicinaView').val(Registro.Medicina);
                $('#txtMotivoView').val(Registro.Motivo);
                $('#txtGeneralesView').val(Registro.Generales);
                $('#txtObservacionesView').val(Registro.Observaciones);
                $('#txtTratamientoView').val(Registro.Tratamiento);
                $('#hdnCurrentIndex').val(index);
            }

            this.FindRegistro = function () {
                var Today = new Date();
                Today.setHours(0, 0, 0, 0);
                var Registro = null;
                $.each(self.Registros(), function (index, item) {
                    var Fecha = Date.parse(item.Fecha);
                    if (Fecha > Today.getTime() && item.IdDoctor == self.CurrentDoctor.Identity()) {
                        Registro = item;
                    }
                });
                return Registro;
            }

            this.FormatViewColumn = function (args) {
                if (args.row.type & $.wijmo.wijgrid.rowType.data) {
                    args.$container.attr('align', 'center');
                    args.$container.empty().append(
                                    $("<a href='#'><img src='" + App.ImagePath + "/General/View_16.png' alt='' class=''/></a>")
                                    .click(function (e) {
                                        var row = args.row.data;
                                        $('#lblFecha').text(row.FechaStr);
                                        $('#lblDoctor').text(row.Doctor);
                                        $('#txtDiagnosticoView').val(row.Diagnostico);
                                        $('#txtMedicinaView').val(row.Medicina);
                                        $('#txtMotivoView').val(row.Motivo);
                                        $('#txtGeneralesView').val(row.Generales);
                                        $('#txtObservacionesView').val(row.Observaciones);
                                        $('#txtTratamientoView').val(row.Tratamiento);
                                        $('#hdnCurrentIndex').val(args.row.dataRowIndex);
                                        $('#dlgViewRecord').dialog('open');
                                        return false;
                                    })
                                );
                    return true;
                }
            }

            this.FormatRecetaColumn = function (args) {
                if (args.row.type & $.wijmo.wijgrid.rowType.data) {
                    args.$container.attr('align', 'center');
                    args.$container.empty().append(
                                    $("<a href='#'><img src='" + App.ImagePath + "/General/diagnostic_16.png' alt='' class=''/></a>")
                                    .click(function (e) {
                                        var row = args.row.data;
                                        //                                        //var Fecha = row.Fecha.toDateString();
                                        //                                        alert(new Date(row.Fecha));
                                        //                                        alert(new Date(row.Fecha.substring(0, 10)));

                                        //                                        var fecha = new Date(row.Fecha)
                                        //                                        alert(fecha.getFullYear().toString() + ((fecha.getMonth() + 1) < 10 ? "0" + (fecha.getMonth() + 1) : fecha.getMonth() + 1) + "" + fecha.getDate());

                                        window.open('../../Reports/RecetaPrint.aspx?IdExpediente=' + row.IdExpediente + "&Fecha=" + row.Fecha.substring(0, 10), '_blank');
                                        return false;
                                    })
                                );
                    return true;
                }
            }

            this.LoadCurrentDoctor = function () {
                self.DoctorSvc.GetDoctorByUser(App.Session.SessionID)
                    .done(function (data) {
                        if (data != "null") {
                            var Info = $.parseJSON(data);
                            self.CurrentDoctor.MapFields(Info);
                        }
                    })
                    .fail(function (ex, error) {
                        $('#msgbox').msgbox('show', { title: "Error", message: error, icon: "error", okButton: true });
                    });
            }


        }


        $(document).ready(function () {
            var Model = new ViewModel();
            //SET UI
            $("body").on({
                ajaxStart: function () {
                    $(this).addClass("loading");
                },
                ajaxStop: function () {
                    $(this).removeClass("loading");
                }
            });

            //Tabs            
            $("#tabs").wijtabs({ alignment: 'left' });

            $('#tlbVisitas').toolbar({
                buttonHeight: 32, buttonWidth: 32,
                buttons: [
                    { text: "Nuevo", key: "btnNuevo", image: "General/AddItem_64.png" },
                    { text: "Agendar", key: "btnAgendar", image: "Medical/appointment_scheduler_128.png" },
                    { text: "Imprimir", key: "btnImprimir", image: "General/printer_32.png" }
                ],
                buttonClick: function (e, data) {
                    if (data.key == "btnNuevo") {
                        if (Model.CurrentDoctor.Identity() > 0) {
                            var Registro = Model.FindRegistro();
                            if (Registro == null) {
                                $('#hdnIdExpediente').val(0);
                                $('#selDoctor').catalogselector('clear');
                                $('#txtDiagnostico').val('');
                                $('#txtMedicina').val('');
                                $('#txtMotivo').val('');
                                $('#txtGenerales').val('');
                                $('#txtObservaciones').val('');
                                $('#txtTratamiento').val('');
                            }
                            else {
                                $('#hdnIdExpediente').val(Registro.IdExpediente);
                                $('#lblFecha').text(Registro.FechaStr);
                                $('#lblDoctor').text(Registro.Doctor);
                                $('#txtDiagnostico').val(Registro.Diagnostico);
                                $('#txtMedicina').val(Registro.Medicina);
                                $('#txtMotivo').val(Registro.Motivo);
                                $('#txtGenerales').val(Registro.Generales);
                                $('#txtObservaciones').val(Registro.Observaciones);
                                $('#txtTratamiento').val(Registro.Tratamiento);
                            }
                            $('#dlgAddRecord').dialog('open');
                        }
                        else {
                            $('#msgbox').msgbox('show', { title: "Atención", message: "El usuario actual no está ligado a un doctor.", icon: "warning", okButton: true });
                        }
                    }
                    if (data.key == "btnAgendar") {
                        window.open('../../Reports/AgendaSalas.aspx', '_blank');
                    }
                    if (data.key == "btnImprimir") {
                        window.open('../../Reports/ExpedientePrint.aspx?IdPaciente=' + Model.IdPaciente, '_blank');
                    }
                }
            });

            $('#msgbox').msgbox();
            $('#tabs').hide();
            $('#tabsExpedienteView').wijtabs({ alignment: 'left' });
            $('#tabsExpediente').wijtabs({ alignment: 'left' });


            $('#btnCargarExpediente').button();
            $('#btnAgregarRegistro').button();
            $('#btnAceptar').button();
            $('#btnPrimero').button();
            $('#btnAtras').button();
            $('#btnSiguiente').button();
            $('#btnUltimo').button();
            UI.Controls.Medicina.PacienteSelector($('#selPaciente'));
            //UI.Controls.Medicina.DoctorSelector($('#selDoctor'));

            $('#dlgAddRecord').dialog({ autoOpen: false, modal: true, title: 'Agregando Registro', height: 500, width: 1100, appendTo: "#form1", show: "blind" });
            $('#dlgViewRecord').dialog({ autoOpen: false, modal: false, title: 'Constula de Registro', height: 500, width: 1100, appendTo: "#form1", show: "blind" });

            $('#btnPrimero').click(function () {
                if (Model.Registros().length > 0) Model.DisplayRegistro(0);
                return false;
            });

            $('#btnUltimo').click(function () {
                if (Model.Registros().length > 0) Model.DisplayRegistro(Model.Registros().length - 1);
                return false;
            });

            $('#btnSiguiente').click(function () {
                var CurrentIndex = parseInt($('#hdnCurrentIndex').val());
                if (CurrentIndex < (Model.Registros().length - 1)) Model.DisplayRegistro(CurrentIndex + 1);
                return false;
            });

            $('#btnAtras').click(function () {
                var CurrentIndex = parseInt($('#hdnCurrentIndex').val());
                if (CurrentIndex > 0) Model.DisplayRegistro(CurrentIndex - 1);
                return false;
            });
            //SET EVENTS
            $('#btnCargarExpediente').click(function () {
                Model.IdPaciente = $('#selPaciente').catalogselector('option', 'identity');
                if (Model.IdPaciente > 0) {
                    $('#tabs').slideDown('500');
                    Model.CargarRegistros(Model.IdPaciente);
                }
                else {
                    $('#msgbox').msgbox('show', { title: "Información", message: 'Debe seleccionar un paciente', icon: "info", okButton: true });
                }
                return false;
            });

            $('#btnAceptar').click(function () {
                var IdExpediente = $('#hdnIdExpediente').val();
                var IdDoctor = Model.CurrentDoctor.Identity();
                var Doctor = Model.CurrentDoctor.Nombre();
                var Diagnostico = $('#txtDiagnostico').val();
                var Medicina = $('#txtMedicina').val();
                var Motivo = $('#txtMotivo').val();
                var Generales = $('#txtGenerales').val();
                var Observaciones = $('#txtObservaciones').val();
                var Tratamiento = $('#txtTratamiento').val();

                if (IdDoctor == 0)
                    $('#msgbox').msgbox('show', { title: "Información", message: 'Debe elegir un doctor', icon: "info", okButton: true });
                else
                    Model.SaveRegistro(new Registro(IdExpediente, IdDoctor, Doctor, Diagnostico, Medicina, Motivo, Generales, Observaciones, Tratamiento));

                return false;
            });

            Model.LoadCurrentDoctor();
            //ENLAZAR A KO
            ko.applyBindings(Model, $('#form1')[0]);
        });
    </script>
    <form id="form1" runat="server">
        <table id="tblPaciente" border="0" cellpadding="0" cellspacing="0" width="600px">
            <thead>
                <tr>
                    <td colspan="2" class="ui-widget-header">Registro y Consulta de Expedientes</td>
                </tr>
            </thead>
            <tbody class="ui-widget-content">
                <tr>
                    <td class="NormalLabel" style="width:100px; height:40px; border-left:1px solid #C0C0C0">Paciente:</td>
                    <td style="height:40px; border-right:1px solid #C0C0C0">
                        <div id="selPaciente"></div>
                    </td>
                </tr>
                <tr>
                    <td style="border-left:1px solid #C0C0C0; border-bottom:1px solid #C0C0C0"></td>
                    <td valign="bottom" align="right" style="height:40px;border-right:1px solid #C0C0C0; border-bottom:1px solid #C0C0C0; padding-right:5px; padding-bottom:5px">
                        <button id="btnCargarExpediente" style="font-size:10pt">Cargar Expediente</button>
                    </td>
                </tr>
            </tbody>
        </table>
        <br />

        <div id="tabs" style="width:1200px">
            <ul>
                <li><a href="#tabs-1">Visitas</a></li>
                <li><a href="#tabs-2">Recetas</a></li>
            </ul>           
            <div id="tabs-1">
                <div id="tlbVisitas"></div>
                <table id="grdRegistros" data-bind="wijgrid: {data: Registros, allowSorting: true, ensureColumnsPxWidth: true, columns:[
                    { headerText: '', width: 30, cellFormatter: FormatViewColumn},
                    { headerText: '', width: 30, cellFormatter: FormatRecetaColumn},
                    { headerText: 'Fecha', visible: false, dataKey: 'Fecha' },
                    { headerText: 'Medicina', visible: false, dataKey: 'Medicina' },
                    { headerText: 'Motivo', visible: false, dataKey: 'Motivo' },
                    { headerText: 'Generales', visible: false, dataKey: 'Generales' },
                    { headerText: 'Observaciones', visible: false, dataKey: 'Observaciones' },
                    { headerText: 'IdDoctor', visible: false, dataKey: 'IdDoctor' },
                    { headerText: 'Diagnostico', visible: false, dataKey: 'Diagnostico' },
                    { headerText: 'Tratamiento', visible: false, dataKey: 'Tratamiento' },
                    { headerText: 'Fecha', width: 150, dataKey: 'FechaStr', dataType: 'string' },
                    { headerText: 'Doctor', width: 300, dataKey: 'Doctor', dataType: 'string' }                        
                ]}">
                </table>
            </div>
            <div id="tabs-2">
            </div>
        </div>
    </form>    

    <div id="dlgAddRecord">
        <input type="hidden" id="hdnIdExpediente" />

        <table id="tblNewRecord" border="0" cellpadding="0" cellspacing="0" width="1200px;">
            <tr>
                <td class="NormalLabel" style="width:100px">Doctor:</td>
                <td>
                    <div id="lblDoctor1" data-bind="text: CurrentDoctor.Nombre"></div>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <div id="tabsExpediente">
                        <ul>
                            <li><a href="#tabsExp-1">Motivo de Consulta</a></li>
                            <li><a href="#tabsExp-2">Antecedentes personales pat.</a></li>
                            <li><a href="#tabsExp-3">Antecedentes Oftalmológicos</a></li>
                            <li><a href="#tabsExp-4">Exploración Física</a></li>
                            <li><a href="#tabsExp-5">Diagnóstico</a></li>
                            <li><a href="#tabsExp-6">Tratamiento</a></li>
                        </ul>
                        <div id="tabsExp-1">
                            <textarea id="txtDiagnostico" style="width:310px; height:200px;font-size:8pt;"></textarea>
                        </div>
                        <div id="tabsExp-2">
                            <textarea id="txtMedicina" style="width:310px; height:200px;font-size:8pt;"></textarea>
                        </div>
                        <div id="tabsExp-3">
                            <textarea id="txtMotivo" style="width:310px; height:200px;font-size:8pt;"></textarea>
                        </div>
                        <div id="tabsExp-4">
                            <textarea id="txtGenerales" style="width:310px; height:200px;font-size:8pt;"></textarea>
                        </div>
                        <div id="tabsExp-5">
                            <textarea id="txtObservaciones" style="width:310px; height:200px;font-size:8pt;"></textarea>
                        </div>
                        <div id="tabsExp-6">
                            <textarea id="txtTratamiento" style="width:310px; height:200px;font-size:8pt;"></textarea>
                        </div>
                    </div>
                </td>
            </tr>
            <tr>
                <td colspan="2" valign="bottom" align="center" style="height:50px">
                    <button id="btnAceptar" style="font-size:10pt">Aceptar</button>
                </td>
            </tr>
        </table>
    </div>

    <div id="dlgViewRecord">
        <input id="hdnCurrentIndex" type="hidden" value="" />

        <table id="tblViewRecord" border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr>
                <td colspan="2">
                    <button id="btnPrimero"><<</button>
                    <button id="btnAtras"><</button>
                    <button id="btnSiguiente">></button>
                    <button id="btnUltimo">>></button>
                </td>
            </tr>
            <tr>
                <td class="NormalLabel">Fecha:</td>
                <td>
                    <div class="NormalLabel" style="font-weight:bold" id="lblFecha"></div>
                </td>
            </tr>
            <tr>
                <td class="NormalLabel" style="font-weight:bold" class="NormalLabel">Doctor:</td>
                <td>
                    <div id="lblDoctor"></div>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <div id="tabsExpedienteView">
                        <ul>
                            <li><a href="#tabsView-1">Motivo Consulta</a></li>
                            <li><a href="#tabsView-2">Antecedentes Personales Pat.</a></li>
                            <li><a href="#tabsView-3">Antecedentes Oftalmológicos</a></li>
                            <li><a href="#tabsView-4">Exploración Física</a></li>
                            <li><a href="#tabsView-5">Diagnóstico</a></li>
                            <li><a href="#tabsView-6">Tratamiento</a></li>
                        </ul>
                        <div id="tabsView-1">
                            <textarea id="txtDiagnosticoView" readonly="readonly" style="width:310px; height:200px;font-size:8pt;"></textarea>
                        </div>
                        <div id="tabsView-2">
                            <textarea id="txtMedicinaView" readonly="readonly" style="width:310px; height:200px;font-size:8pt;"></textarea>
                        </div>
                        <div id="tabsView-3">
                            <textarea id="txtMotivoView" readonly="readonly" style="width:310px; height:200px;font-size:8pt;"></textarea>
                        </div>
                        <div id="tabsView-4">
                            <textarea id="txtGeneralesView" readonly="readonly" style="width:310px; height:200px;font-size:8pt;"></textarea>
                        </div>
                        <div id="tabsView-5">
                            <textarea id="txtObservacionesView" readonly="readonly" style="width:310px; height:200px;font-size:8pt;"></textarea>
                        </div>
                        <div id="tabsView-6">
                            <textarea id="txtTratamientoView" readonly="readonly" style="width:310px; height:200px;font-size:8pt;"></textarea>
                        </div>
                    </div>
                </td>
            </tr>
        </table>
    </div>

    <div id="msgbox"></div>
    <div class="modal"></div>
</body>
</html>
