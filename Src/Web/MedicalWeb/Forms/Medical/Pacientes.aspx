<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Pacientes.aspx.vb" Inherits="Azteca.Web.Pacientes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Catálogo de Pacientes</title>
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
   
     <style type="text/css"> 
        nav li {
            display: inline-block;
            padding: 5px;
            background: red;
        }
    </style>

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
    <script src="../../Scripts/JQuery/jquery-azteca-ventas.js" type="text/javascript"></script>

    <script src="../../Scripts/JQueryUI/jquery-ui-azteca-medicina.js" type="text/javascript"></script>
    
   

    <script type="text/javascript">
        function ViewModel() {
            var self = this;
            this.CatalogInfo = new Business.Medicina.PacienteInfo();
            this.CatalogService = new Business.Medicina.PacienteService();

        }

        $(document).ready(function () {

            var CatalogViewModel = new ViewModel();


            /*****************************************************************************/
            //Definir validador del formulario
            var validatorOptions = {
                rules: {
                    txtNombre: "required"//,
                    //cboIdEspecialidad: "required",
                    //txtRFC: "required",
                    //txtCedula: "required"
                },
                messages: {
                    txtNombre: "Por favor ingrese el nombre del Paciente"//,
                    //cboIdEspecialidad: "Por favor seleccione una especialidad",
                    //txtRFC: "Por favor ingrese el RFC",
                    //txtCedula: "Debe introducir la cédula."
                }
            }

            /*****************************************************************************/
            //Grid de catalogo de pacientes
            var Columns = [
                         { headerText: "ID", visible: false, dataKey: "ID" },
                         { headerText: "IdPaciente", visible: false, dataKey: "IdPaciente" },
                         { headerText: "Codigo", dataKey: "Codigo", dataType: "string", filterOperator: "BeginsWith", width: 70 },
                         { headerText: "Nombre", dataKey: "Nombre", dataType: "string", filterOperator: "BeginsWith", width: 250 },
                         { headerText: "Edad", dataKey: "Edad", dataType: "string", filterOperator: "BeginsWith", width: 50 },
                         { headerText: "Calle", dataKey: "Calle", dataType: "string", filterOperator: "BeginsWith", width: 150 },
                         { headerText: "Colonia", dataKey: "Colonia", dataType: "string", filterOperator: "BeginsWith", width: 150 },
                         { headerText: "Poblacion", dataKey: "Poblacion", dataType: "string", filterOperator: "BeginsWith", width: 180 },
                         { headerText: "C.P.", dataKey: "CP", dataType: "string", filterOperator: "BeginsWith", width: 70 },
                         { headerText: "Fecha Nacimiento", dataKey: "FechaNacimiento", visible: false },
                         { headerText: "PrimeraConsulta", dataKey: "PrimeraConsulta", visible: false },
                         { headerText: "Sexo", dataKey: "Sexo", visible: false },
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
                    $('#chkAfiliado').attr('checked', info.Afiliado);
                    $('#optMasculino').prop('checked', (info.Sexo == 0));
                    $('#optFemenino').prop('checked', (info.Sexo == 1));                    
                },
                SavingInfo: function (viewModel) {
                    viewModel.CatalogInfo.Afiliado($('#chkAfiliado').is(':checked'));
                }
            }
            var Form = new Kernel.Forms.CatalogForm(CatalogOptions);

            /*****************************************************************************/
            //Generar elementos especificos de la forma

            $("#tabs").wijtabs({ alignment: 'left' });
            $("#dtpFechaNacimiento").wijinputdate({ showTrigger: true, dateFormat: 'dd/MM/yyyy' });

            //$("#txtFecha").wijinputdate({ textChanged: function (e, arg) {});

            $("#optFemenino").change(function () {
                $('#optMasculino').prop("selected",false);
               // $('#optMasculino').attr("selected", "unselected");
            });

            Kernel.Controls.PoblacionesSelector($('#selPoblacion'));
            $('#selPoblacion').css({ 'width': '310px' });
            Kernel.Controls.PoblacionesSelector($('#selPoblacionFis'));
            //Enlazar view model del catálogo con ko
            /*****************************************************************************/
            ko.applyBindings(CatalogViewModel, $('#form1')[0]);

            //CatalogViewModel.CargarEspecialidades();
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
                        <input id="Text1" name="txtNombre" type="text" class="TextField" style="width:570px" tabindex="1" data-bind="value: CatalogInfo.Cliente.Nombre" />
                    </td>
                </tr>                
        </table>

        <div id="tlbMenu"></div>
            <div id="tabs">
                <ul>
                    <li><a href="#tabs-1">Generales</a></li>
                    <li><a href="#tabs-2">Facturación</a></li>
                </ul>
                <div id="tabs-1">
                     <table id="tblGenerales" cellpadding="0" cellspacing="0">
                        <tr>
                            <td class="RequiredLabel">Fecha Nacimiento:</td>
                            <td >
                                <input id="dtpFechaNacimiento" name="dtpFechaNacimiento" type="text" class="TextField" style="width:270px" data-bind="value: CatalogInfo.FechaNacimiento" />
                            </td>
                            <td>

                            </td>
                            <td>
                                <input id="chkAfiliado" name="chkAfiliado"  type="checkbox" tabindex="3"  />
                                <label for="chkAfiliado" style="font-size:small; font-weight:bold" >Afiliado</label>                                
                            </td>
                            <!--td class="RequiredLabel">Afiliado:</td>
                            <td>
                                <input id="chkAfiliado" name="chkAfiliado" type="checkbox" class="TextField" style="width:250px" data-bind="value: CatalogInfo.Afiliado" />
                            </td-->
                        </tr>
                        <tr>
                            <td class="NormalLabel">Sexo:</td>
                            <td>                     
                                 <ul id="EditMenu" style="width:250px; display:inline-block;" 
                                    class="ui-menu ui-state-default" type="disc">                                    
                                     <li id="mnuMasculino" style="display:inline-block; height: 21px;" class="ui-menu-item" >
                                        <input id="optMasculino"type="radio" checked="checked" name="Sexo" />Masculino</li>
                                     <li id="mnuFemenino"  style="display:inline-block" class="ui-menu-item">
                                        <input id="optFemenino" type="radio"  name="Sexo"/>Femenino</li>                                                                        
                                </ul>                              
                                
                           
                            </td>
                           
                        </tr>
                       
                                  
                        <tr>
                            <td class="RequiredLabel">Calle:</td>
                            <td>
                                <input id="txtCalle" name="txtCalle" type="text" class="TextField" style="width:250px" tabindex="1" data-bind="value: CatalogInfo.Cliente.Calle" />
                            </td>
                        <!--/tr>
                        <tr-->
                            <td class="RequiredLabel">Numero:</td>
                            <td>
                                <input id="txtNumExt" name="txtNumExt" type="text" class="TextField" style="width:100px" tabindex="1" data-bind="value: CatalogInfo.Cliente.NumExt" />
                            </td>

                        <!--/tr>
                        <tr-->
                            <td class="RequiredLabel">Int.:</td>
                            <td>
                                <input id="txtNumInt" name="txtNumInt" type="text" class="TextField" style="width:100px" tabindex="1" data-bind="value: CatalogInfo.Cliente.NumInt" />
                            </td>
                        </tr>    
                                
                        <tr>
                            <td class="RequiredLabel">Colonia:</td>
                            <td>
                                <input id="txtColonia" name="txtColonia" type="text" class="TextField" style="width:250px" tabindex="1" data-bind="value: CatalogInfo.Cliente.Colonia" />
                            </td>
                        </tr>    

                        <tr>
                          
                        </tr>    

                        <tr>                                
                            <td class="RequiredLabel" >Población:</td> 
                            <td>
                                <div id="selPoblacion" tabindex="9" data-bind="selectorValue: CatalogInfo.Cliente.IdPoblacion" "></div>
                            </td>
                            <td></td>
                            <td></td>
                            <td class="RequiredLabel">C.P.:</td>
                            <td>
                                <input id="txtCP" name="txtCP" type="text" class="TextField" style="width:100px" tabindex="1" data-bind="value: CatalogInfo.Cliente.CP" />
                            </td>
                        </tr>
                           
                        <tr>
                            <td class="NormalLabel">Telefono:</td>
                            <td>
                                <input id="txtTelefono" name="txtTelefono" type="text" class="TextField" style="width:250px" data-bind="value: CatalogInfo.Cliente.Telefonos" />
                            </td>
                        </tr>
                        <tr>
                            <td class="NormalLabel">Correo:</td>
                            <td>
                                <input id="txtCorreo" name="txtCorreo" type="text" class="TextField" style="width:250px" data-bind="value: CatalogInfo.Cliente.Correo" />
                            </td>
                        </tr>             
                    </table>         
                </div>



                <div id="tabs-2">
                    <table id="tblFacturacion" cellpadding="0" cellspacing="0">
                        <tr>
                        <td class="RequiredLabel">RFC:</td>
                        <td>
                            <input id="txtRFC" name="txtRFC" type="text" class="TextField" style="width:150px" tabindex="1" data-bind="value: CatalogInfo.Cliente.RFC" />
                        </td>
                        </tr>    
                        <tr>
                        <td class="RequiredLabel">Razón Social:</td>
                        <td>
                            <input id="txtRazonSocial" name="txtRazonSocial" type="text" class="TextField" style="width:600px" tabindex="1" data-bind="value: CatalogInfo.Cliente.RazonSocial" />
                        </td>
                        </tr>    

                        <tr>
                        <td class="RequiredLabel">Calle:</td>
                        <td>
                            <input id="txtCalleFis" name="txtCalleFis" type="text" class="TextField" style="width:300px" tabindex="1" data-bind="value: CatalogInfo.Cliente.CalleFiscal" />
                        </td>
                        </tr>
                        <tr>
                        <td class="RequiredLabel">Num.Ext:</td>
                        <td>
                            <input id="txtNumExtFis" name="txtNumExtFis" type="text" class="TextField" style="width:100px" tabindex="1" data-bind="value: CatalogInfo.Cliente.NumExtFiscal" />
                        </td>
                    </tr>
                        <tr>
                        <td class="RequiredLabel">Num.Int:</td>
                        <td>
                            <input id="txtNumIntFis" name="txtNumIntFis" type="text" class="TextField" style="width:100px" tabindex="1" data-bind="value: CatalogInfo.Cliente.NumIntFiscal" />
                        </td>
                        </tr>    
                                
                        <tr>
                        <td class="RequiredLabel">Colonia:</td>
                        <td>
                            <input id="txtColoniaFis" name="txtColoniaFis" type="text" class="TextField" style="width:600px" tabindex="1" data-bind="value: CatalogInfo.Cliente.ColoniaFiscal" />
                        </td>
                        </tr>    

                        <tr>
                        <td class="RequiredLabel">C.P.:</td>
                        <td>
                            <input id="txtCPFis" name="txtCPFis" type="text" class="TextField" style="width:600px" tabindex="1" data-bind="value: CatalogInfo.Cliente.CPFiscal" />
                        </td>
                        </tr>    
                        <>
                    <tr>                                
                        <td class="RequiredLabel" >Población:</td> 
                        <td>
                            <div id="selPoblacionFis" tabindex="9" data-bind="selectorValue: CatalogInfo.Cliente.IdPoblacionFiscal"></div>
                        </td>
                    </tr>

                    </table>
                </div>
            </div>

            
        </div>           
    </div> 
    </form>
</body>
</html>
