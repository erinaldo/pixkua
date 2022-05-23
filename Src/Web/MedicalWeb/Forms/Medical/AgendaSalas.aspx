<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AgendaSalas.aspx.vb" Inherits="Azteca.Web.AgendaSalas" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Agenda de Salas</title>
    <!--THEME-->
    <link href="http://code.jquery.com/ui/1.10.3/themes/south-street/jquery-ui.min.css" class="cssTheme"
        rel="stylesheet" type="text/css" />    
    <!--Wijmo Widgets CSS-->
    <link href="http://cdn.wijmo.com/jquery.wijmo-pro.all.3.20143.59.min.css" rel="stylesheet" type="text/css" />    
    <link href="../../Styles/wijgrid.css" rel="Stylesheet" type="text/css" />
    <link href="../../Styles/wijtabs.css" rel="Stylesheet" type="text/css" />
    <!--AZTECA-->
    <link href="../../Styles/jquery-ui-form.css" rel="stylesheet" type="text/css" />
    <link href="../../Styles/jquery-ui-widgets.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #Events
        {
            width: 900px;
            height:1000px;
        }
         
    </style>
</head>
<body>
    <!--jQuery-->  
    <script src="http://ajax.aspnetcdn.com/ajax/jquery/jquery-1.9.1.min.js" type="text/javascript"></script>   
    <script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.10.1/jquery-ui.min.js" type="text/javascript"></script>
    <script src="../../../Scripts/Json/json2.js" type="text/javascript"></script>
    <script src="../../Scripts/JQuery/purl.js" type="text/javascript"></script>
    <!--jQuery Validate--> 
    <script src="http://ajax.aspnetcdn.com/ajax/jquery.validate/1.11.1/jquery.validate.min.js" type="text/javascript"></script>    
    <!--Wijmo Widgets JavaScript-->    
    <script src="http://cdn.wijmo.com/jquery.wijmo-open.all.3.20143.59.min.js" type="text/javascript"></script>
    <script src="http://cdn.wijmo.com/jquery.wijmo-pro.all.3.20143.59.min.js" type="text/javascript"></script>    
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
        $(document).ready(function () {
            var Service = new Business.Medicina.SalaService();
            var DoctorSvc = new Business.Medicina.DoctorService();
            var IdSala = $.url().param('IdSala');

            function EventoSala(id, idSala, fechaInicial, fechaFinal, fechaRegistro, idDoctor, doctor, idPaciente, paciente, observaciones) {
                this.ID = id;
                this.IdSala = idSala;
                this.FechaInicial = fechaInicial;
                this.FechaFinal = fechaFinal;
                this.FechaRegistro = fechaRegistro;
                this.IdDoctor = idDoctor;
                this.Doctor = doctor;
                this.IdPaciente = idPaciente;
                this.Paciente = paciente;
                this.Observaciones = observaciones;
            }

            //Funciones para carga de información
            function CargarSalas() {
                Service.LoadList()
                    .done(function (data) {
                        var Salas = $.parseJSON(data);
                        $.each(Salas, function (index, item) {
                            $('#cboSala').append($('<option></option>').html(item.Nombre).val(item.IdSala));
                        });
                        if (IdSala != undefined) {
                            $('#cboSala').val(IdSala);

                            Service.CargarAgenda(IdSala)
                                .done(function (data) {
                                    //$('#Events').wijevcal('option', 'eventsData', []);
                                    var ServerEvents = $.parseJSON(data);
                                    var NewEvents = [];
                                    $.each(ServerEvents, function (index, item) {
                                        var NewEvent = {
                                            id: item.ID,
                                            start: new Date(item.FechaInicial),
                                            end: new Date(item.FechaFinal),
                                            subject: item.Doctor + '\r\n' + item.Paciente,
                                            description: item.Observaciones,
                                            tag: JSON.stringify(item)
                                        }
                                        NewEvents.push(NewEvent);
                                        //$('#Events').wijevcal('addEvent', NewEvent);
                                    });
                                    $('#Events').wijevcal('option', 'eventsData', NewEvents);
                                    $('#Events').wijevcal('refresh');
                                })
                                .fail(function (e, error) {
                                    $('#msgbox').msgbox('show', { title: "Error", message: error, icon: "error", okButton: true });
                                });
                        }
                        else {
                            $('#Events').hide();
                        }
                    })
                    .fail(function (e, error) {
                        $('#msgbox').msgbox('show', { title: "Error", message: error, icon: "error", okButton: true });
                    });
            }

            function CombineDateHour(date, hour) {
                var Hours = hour.getHours();
                var Minutes = hour.getMinutes();
                date.setHours(Hours, Minutes);
                return date;
            }

            function LoadCurrentDoctor() {
                DoctorSvc.GetDoctorByUser(App.Session.SessionID)
                    .done(function (data) {
                        if (data != "null") {
                            var Info = $.parseJSON(data);
                            CurrentDoctor.MapFields(Info);
                        }
                    })
                    .fail(function (ex, error) {
                        $('#msgbox').msgbox('show', { title: "Error", message: error, icon: "error", okButton: true });
                    });
            }

            function IsValid() {
                if ($('#selDoctor').catalogselector('value') == 0) {
                    $('#msgbox').msgbox('show', { title: "Atención", message: 'Debe seleccionar un doctor', icon: "warning", okButton: true });
                    return false;
                }
                else if ($('#selPaciente').catalogselector('value') == 0) {
                    $('#msgbox').msgbox('show', { title: "Atención", message: 'Debe seleccionar un paciente', icon: "warning", okButton: true });
                    return false;
                }
                else
                    return true;
            }

            //Crear widget para calendario
            $('#btnCargarAgenda').button();
            $('#btnAceptar').button();
            $('#btnCancelar').button();
            $('#btnEliminar').button();

            $('#txtInicio').datepicker(
            {
                dateFormat: 'dd/mm/yy',
                showOn: 'button',
                buttonImage: '../../Images/General/calendar_16.png',
                buttonImageOnly: true,
                buttonText: 'Seleccionar fecha'
            });

            $('#txtFin').datepicker(
            {
                dateFormat: 'dd/mm/yy',
                showOn: 'button',
                buttonImage: '../../Images/General/calendar_16.png',
                buttonImageOnly: true,
                buttonText: 'Seleccionar fecha'
            });

            $('#txtHoraIni').wijinputdate({ dateFormat: 'T' });
            $('#txtHoraFin').wijinputdate({ dateFormat: 'T' });

            $('#msgbox').msgbox();

            $('#Events').wijevcal();

            //Crear dialogo para edición de eventos
            $('#dlgEditEvent').wijdialog({
                modal: true,
                autoOpen: false,
                width: 800,
                title: 'Editar evento de sala',
                appendTo: $('#form1'),
                captionButtons: {
                    pin: { visible: false },
                    refresh: { visible: false },
                    toggle: { visible: false },
                    minimize: { visible: false },
                    maximize: { visible: false }
                }
            });


            $('#Events').wijevcal({
                culture: 'es-MX',
                beforeEditEventDialogShow: function (e, args) {
                    $('#lblFolio').text('0');
                    $('#txtInicio').datepicker('setDate', args.data.start);
                    $('#txtFin').datepicker('setDate', args.data.end);
                    $('#txtHoraIni').wijinputdate('option', 'date', args.data.start);
                    $('#txtHoraFin').wijinputdate('option', 'date', args.data.end);
                    $('#selDoctor').catalogselector('clear');
                    $('#selPaciente').catalogselector('clear');
                    $('#txtObservaciones').val('');
                    $('#btnEliminar').hide();
                    if (!args.data.isNewEvent) {
                        var event = $.parseJSON(args.data.tag);
                        $('#lblFolio').text(event.ID);
                        $('#selDoctor').catalogselector('load', event.IdDoctor);
                        $('#selPaciente').catalogselector('load', event.IdPaciente);
                        $('#txtObservaciones').val(event.Observaciones);
                        $('#btnEliminar').show();
                    }
                    $('#dlgEditEvent').wijdialog('open');
                    return false;
                }
            });

            $('#btnCargarAgenda').click(function () {
                var IdSala = $('#cboSala').val();
                window.location = 'AgendaSalas.aspx?IdSala=' + IdSala;

                return false;
            });

            $('#btnAceptar').click(function () {
                if (IsValid()) {
                    //Obtener la fecha y hora inicial
                    var FechaIni = $('#txtInicio').datepicker('getDate');
                    var HoraIni = $('#txtHoraIni').wijinputdate('option', 'date');
                    //Obtener la fecha y hora final
                    var FechaFin = $('#txtFin').datepicker('getDate');
                    var HoraFin = $('#txtHoraFin').wijinputdate('option', 'date');

                    var CurrentEvent = new EventoSala();
                    CurrentEvent.ID = $('#lblFolio').text();
                    CurrentEvent.IdSala = $('#cboSala').val();
                    CurrentEvent.FechaInicial = CombineDateHour(FechaIni, HoraIni).getTime();
                    CurrentEvent.FechaFinal = CombineDateHour(FechaFin, HoraFin).getTime();
                    CurrentEvent.IdDoctor = $('#selDoctor').catalogselector('value');
                    CurrentEvent.Doctor = $('#selDoctor').catalogselector('option', 'text');
                    CurrentEvent.IdPaciente = $('#selPaciente').catalogselector('value');
                    CurrentEvent.Paciente = $('#selPaciente').catalogselector('option', 'text');
                    CurrentEvent.Observaciones = $('#txtObservaciones').val();


                    Service.AgendarEvento(CurrentEvent)
                    .done(function (data) {
                        var event = $.parseJSON(data);

                        //Actualizar información del control
                        var NewEvent = {
                            id: event.ID,
                            start: new Date(event.FechaInicial),
                            end: new Date(event.FechaFinal),
                            subject: event.Doctor + '\n' + event.Paciente,
                            description: event.Observaciones,
                            tag: data
                        }
                        if (CurrentEvent.ID == 0) {
                            $('#Events').wijevcal('addEvent', NewEvent);
                        }
                        else {
                            $('#Events').wijevcal('updateEvent', NewEvent);
                            $('#Events').wijevcal('refresh');
                        }
                        $('#dlgEditEvent').wijdialog('close');
                    })
                    .fail(function (e, error) {
                        $('#msgbox').msgbox('show', { title: "Error", message: error, icon: "error", okButton: true });
                    });
                }

                return false;
            });

            $('#btnCancelar').click(function () {
                $('#dlgEditEvent').wijdialog('close');
                return false;
            });

            function deleteEvent(events, idEvent) {
                for (i = 0; i < events.length; i++) {
                    if (events[i].id == idEvent) {
                        events.splice(i, 1);
                        break;
                    }
                }
            }

            $('#btnEliminar').click(function () {
                $('#msgbox').msgbox('show', { title: "Confirmar Acción", message: "¿Está seguro que desea eliminar éste evento?", okButton: true, cancelButton: true, icon: "question",
                    dialogResult: function (e, data) {
                        if (data.resp == "Aceptar") {
                            var ID = $('#lblFolio').text();
                            Service.EliminarEvento(ID)
                                .done(function (data) {
                                    var eventsData = $('#Events').wijevcal('option', 'eventsData');
                                    deleteEvent(eventsData, ID);
                                    $('#Events').wijevcal('option', 'eventsData', eventsData);
                                    $('#Events').wijevcal('refresh');
                                    $('#dlgEditEvent').wijdialog('close');
                                })
                                .fail(function (e, error) {
                                    $('#msgbox').msgbox('show', { title: "Error", message: error, icon: "error", okButton: true });
                                });
                        }
                    }
                });

            });

            UI.Controls.Medicina.PacienteSelector($('#selPaciente'));
            UI.Controls.Medicina.DoctorSelector($('#selDoctor'));

            CargarSalas();
        });
    </script>
    
    <form id="form1" runat="server">
        <table id="tblSala" border="0" cellpadding="0" cellspacing="0" width="850px">
            <thead>
                <tr>
                    <td colspan="2" class="ui-widget-header">Agenda de Salas</td>
                </tr>
            </thead>
            <tbody class="ui-widget-content">
                <tr>
                    <td class="NormalLabel" style="width:100px; height:40px; border-left:1px solid #C0C0C0">Sala:</td>
                    <td style="height:40px; border-right:1px solid #C0C0C0">
                        <select id="cboSala" style="width:200px">                            
                        </select>
                    </td>
                </tr>
                <tr>
                    <td style="border-left:1px solid #C0C0C0; border-bottom:1px solid #C0C0C0"></td>
                    <td valign="bottom" align="right" style="height:40px;border-right:1px solid #C0C0C0; border-bottom:1px solid #C0C0C0; padding-right:5px; padding-bottom:5px">
                        <button id="btnCargarAgenda" style="font-size:10pt">Cargar Agenda</button>
                    </td>
                </tr>
            </tbody>
        </table>
        <br />

        <div id="Events">
        </div>
    </form>

    <div id="dlgEditEvent">
        
        <table id="tblEvent" border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr>
                <td style="width:200px">Folio:</td>
                <td>
                    <div id="lblFolio"></div>
                    <input type="button" id="btnEliminar" value="Eliminar" />
                </td>
            </tr>
            <tr>
                <td >Inicio:</td>
                <td>
                    <input type="text" id="txtInicio" style="width:150px"/>
                    <input type="text" id="txtHoraIni" style="width:100px" />
                </td>
            </tr>
            <tr>
                <td>Fin:</td>
                <td>
                    <input type="text" id="txtFin" style="width:150px" />
                    <input type="text" id="txtHoraFin" style="width:100px" />
                </td>
            </tr>
            <tr>
                <td>Doctor:</td>
                <td>
                    <div id="selDoctor"></div>
                </td>
            </tr>
            <tr>
                <td>Paciente:</td>
                <td>
                    <div id="selPaciente"></div>
                </td>
            </tr>
            <tr>
                <td>Observaciones:</td>
                <td>
                    <textarea id="txtObservaciones" cols="40" rows="10"></textarea>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="right" style="padding-right:30px; height:50px;">
                    <input type="button" id="btnAceptar" value="Aceptar" />
                    <input type="button" id="btnCancelar" value="Cancelar" />
                </td>
            </tr>
        </table>
        <div class="modal"></div>

    </div>

    <div id="msgbox"></div>
    <div class="modal"></div>

</body>
</html>
