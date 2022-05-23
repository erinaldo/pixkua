<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Doctores.aspx.vb" Inherits="Azteca.Web.Doctores" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Catálogo de Doctores</title>
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
    <script src="../../Scripts/JQuery/jquery-azteca-medicina.js" type="text/javascript"></script>
    
    <script src="../../Scripts/JQueryUI/jquery-ui-azteca-medicina.js" type="text/javascript"></script>
    <script type="text/javascript">
        function ViewModel() {
            var self = this;
            this.CatalogInfo = new Business.Medicina.DoctorInfo();
            this.CatalogService = new Business.Medicina.DoctorService();

            this.Especialidades = ko.observableArray([]);

            this.CargarEspecialidades = function () {
                self.CatalogService.CargarEspecialidades()
                    .done(function (data) {
                        var result = $.parseJSON(data);
                        self.Especialidades(result);
                    })
                    .fail(function (e) {
                        Form.MsgBox({ title: 'Error', message: e.responseText, icon: 'error', okButton: true });
                    });
            }
        }

        $(document).ready(function () {

            var CatalogViewModel = new ViewModel();


            /*****************************************************************************/
            //Definir validador del formulario
            var validatorOptions = {
                rules: {
                    txtNombre: "required",
                    cboIdEspecialidad: "required",
                    txtRFC: "required",
                    txtCedula: "required"
                },
                messages: {
                    txtNombre: "Por favor ingrese el nombre del doctor",
                    cboIdEspecialidad: "Por favor seleccione una especialidad",
                    txtRFC: "Por favor ingrese el RFC",
                    txtCedula: "Debe introducir la cédula."
                }
            }

            /*****************************************************************************/
            //Grid de catalogo de usuarios
            var Columns = [
                         { headerText: "ID", visible: false, dataKey: "ID" },
                         { headerText: "IdDoctor", visible: false, dataKey: "IdDoctor" },
                         { headerText: "Codigo", dataKey: "Codigo", dataType: "string", filterOperator: "BeginsWith", width: 100 },
                         { headerText: "Nombre", dataKey: "Nombre", dataType: "string", filterOperator: "BeginsWith", width: 250 },
                         { headerText: "Especialidad", dataKey: "Especialidad", dataType: "string", filterOperator: "BeginsWith", width: 120 },
                         { headerText: "RFC", dataKey: "RFC", dataType: "string", filterOperator: "BeginsWith", width: 100 },
                         { headerText: "Cédula", dataKey: "Cedula", dataType: "string", filterOperator: "BeginsWith", width: 100 },
                         { headerText: "Estatus", dataKey: "Estatus", dataType: "string", filterOperator: "BeginsWith", width: 90 }
                        ];

            /*****************************************************************************/
            //Inicializar opciones del catálogo
            var CatalogOptions = {
                ViewModel: CatalogViewModel,
                ValidatorOptions: validatorOptions,
                MainDiv: $('#MainDiv'),
                EditForm: $('#EditForm'),
                ListColumns: Columns,
                CloseOnSave: true,
                DialogWidth: 900,
                AddingItem: function (viewModel, info) {

                },
                LoadingInfo: function (viewModel, info) {

                },
                SavingInfo: function (viewModel) {

                }
            }
            var Form = new Kernel.Forms.CatalogForm(CatalogOptions);

            /*****************************************************************************/
            //Generar elementos especificos de la forma

            $("#tabs").wijtabs({ alignment: 'left' });

            Kernel.Controls.UsuariosSelector($('#selUsuario'));
            Kernel.Controls.PoblacionesSelector($('#selPoblacion'));
            //Enlazar view model del catálogo con ko
            /*****************************************************************************/
            ko.applyBindings(CatalogViewModel, $('#form1')[0]);

            CatalogViewModel.CargarEspecialidades();
        });
    </script>
    
    <form id="form1" runat="server">
    <div id="MainDiv" class="ui-form">
    <div id="EditForm">
         
        <table id="tblMain" cellpadding="0" cellspacing="0">
                <tr>
                    <td style="width:60px" width="800px" class="NormalLabel">Código:</td>                    
                    <td>
                        <div style="width:250px" id="lblCodigo" class="NormalLabel" data-bind="text: CatalogInfo.Codigo"></div>
                    </td>
                </tr>
                <tr>
                    <td class="RequiredLabel">Nombre:</td>
                    <td>
                        <input id="Text1" name="txtNombre" type="text" class="TextField" style="width:570px" tabindex="1" data-bind="value: CatalogInfo.Nombre" />
                    </td>
                </tr>                
        </table>

         <div id="tlbMenu"></div>
            <div id="tabs">
                <ul>
                    <li><a href="#tabs-1">Generales</a></li>
                    <li><a href="#tabs-2">Domicilio</a></li>
                </ul>
                <div id="tabs-1">
                    <table id="tblGenerales" cellpadding="0" cellspacing="0">
                        <tr>
                            <td class="NormalLabel" style="width:120px">Usuario:</td>
                            <td>
                                <div id="selUsuario" data-bind="selectorValue: CatalogInfo.IdUsuario"></div>
                            </td>
                        </tr>
                        <tr>
                            <td class="NormalLabel">Especialidad:</td>
                            <td>
                                <select id="cboEspecialidad" name="cboEspecialidad" data-bind="options: Especialidades, optionsText: 'Nombre', optionsValue: 'IdEspecialidad', value: CatalogInfo.IdEspecialidad"></select>
                            </td>
                        </tr>
                        <tr>
                            <td class="RequiredLabel">RFC:</td>
                            <td>
                                <input id="txtRFC" name="txtRFC" type="text" class="TextField" style="width:350px" data-bind="value: CatalogInfo.RFC" />
                            </td>
                        </tr>
                        <tr>
                            <td class="RequiredLabel">Cedula:</td>
                            <td>
                                <input id="txtCedula" name="txtCedula" type="text" class="TextField" style="width:250px" data-bind="value: CatalogInfo.Cedula" />
                            </td>
                        </tr>
                        <tr>
                            <td class="NormalLabel">Correo:</td>
                            <td>
                                <input id="txtCorreo" name="txtCorreo" type="text" class="TextField" style="width:250px" data-bind="value: CatalogInfo.Correo" />
                            </td>
                        </tr>
                        <tr>
                            <td class="NormalLabel">Tel. Casa:</td>
                            <td>
                                <input id="txtTelCasa" name="txtTelCasa" type="text" class="TextField" style="width:150px" data-bind="value: CatalogInfo.TelefonoCasa" />
                            </td>
                        </tr>
                        <tr>
                            <td class="NormalLabel">Celular:</td>
                            <td>
                                <input id="txtCelular" name="txtCelular" type="text" class="TextField" style="width:150px" data-bind="value: CatalogInfo.Celular" />
                            </td>
                        </tr>
                        <tr>
                            <td class="NormalLabel">Tel. Oficina:</td>
                            <td>
                                <input id="txtTelOficina" name="txtTelOficina" type="text" class="TextField" style="width:150px" data-bind="value: CatalogInfo.TelefonoOficina" />
                            </td>
                        </tr>
                    </table>         
                </div>
                <div id="tabs-2">
                    <table id="tblDomicilio" cellpadding="0" cellspacing="0">
                        <tr>                            
                            <td style="width:80px" class="NormalLabel">Calle:</td>
                            <td>
                                <input id="txtCalle" name="txtCalle" type="text" class="TextField" style="width:350px" data-bind="value: CatalogInfo.Calle" />
                            </td> 
                        </tr>               
                        <tr>
                            <td colspan="2" align="left">
                                <table cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td style="width:80px" class="NormalLabel">Num. Ext.:</td>
                                        <td style="padding-right:8px">
                                            <input id="txtNumExt" name="txtNumExt" type="text" class="TextField" style="width:70px" data-bind="value: CatalogInfo.NumExt" />
                                        </td>
                                        <td style="width:70px" class="NormalLabel">Num. Int.:</td> 
                                        <td>
                                            <input id="txtNumInt" name="txtNumInt" type="text" class="TextField" style="width:70px" data-bind="value: CatalogInfo.NumInt" />
                                        </td>
                                    </tr>
                                </table> 
                            </td>                                
                        </tr>
                        <tr>
                            <td class="NormalLabel">Colonia:</td>
                            <td>
                                <input id="txtColonia" name="txtColonia" type="text" class="TextField" style="width:350px" data-bind="value: CatalogInfo.Colonia" />
                            </td>
                        </tr>
                        <tr>                            
                            <td style="width:40px" class="NormalLabel">CP:</td>
                            <td>
                                <input id="txtCP" name="txtCP" type="text" class="TextField" style="width:80px" data-bind="value: CatalogInfo.CP" />
                            </td>
                        </tr>
                        <!--
                        <tr>                            
                            <td class="RequiredLabel">Población:</td> 
                            <td>
                                <div id="selPoblacion" data-bind="selectorValue: CatalogInfo.IdPoblacion"></div>                                
                            </td>                            
                        </tr>
                        -->
                    </table>
                </div>
            </div>

            
        </div>           
    </div> 
    </form>
</body>
</html>
