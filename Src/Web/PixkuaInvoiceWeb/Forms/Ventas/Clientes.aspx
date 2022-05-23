<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Clientes.aspx.vb" Inherits="Azteca.Web.Clientes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administración de Clientes</title>
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
    <script src="../../../Scripts/JQuery/jquery-azteca-kernel.js?<%=ScriptsVersion%>" type="text/javascript"></script>    
    <script src="../../../Scripts/JQueryUI/jquery-ui-widgets.js?<%=ScriptsVersion%>" type="text/javascript"></script>
    <script src="../../../Scripts/JQueryUI/jquery-ui-azteca-kernel.js" type="text/javascript"></script>
    <script src="../../../Scripts/JQuery/jquery-azteca-ventas.js" type="text/javascript"></script>

    <script type="text/javascript">
    

        /*****************************************************************************/
        //Definir View Model del catálogo
        function ViewModel() {
            var self = this;
            this.CatalogInfo = new  Business.Ventas.ClienteInfo();
            this.CatalogService = new Business.Ventas.ClienteService();
            
//            this.Sucursales = ko.observableArray([]);
//            this.CargarSucursales = function (idEmpresa) {
//                self.CatalogService.CargarSucursales(idEmpresa)
//                        .done(function (data) {
//                            var Result = $.parseJSON(data);
//                            self.Sucursales(Result);
//                        })
//                        .fail(function (e, textStatus, error) {
//                            Form.MsgBox({ title: 'Error', message: e.responseText, icon: 'error', okButton: true });
//                        });
//            }
        }

  
        var CatalogViewModel = new ViewModel();


        $(document).ready(function () {

            //Definir validador del formulario
            var validatorOptions = {
                rules: {
                    txtNombre: "required",
                    selPoblacion: "required",
                    txtCRFC: "required"
                    
                },
                messages: {
                    txtNombre: "Por favor ingrese el nombre",
                    selPoblacion: "Por favor elija una población válida",
                    txtRFC: "Por favor ingrese el RFC"
                }
            }


            /*****************************************************************************/
            //Definir las columnas de la lista de elementos del catálogo
            var Columns = [{ headerText: "ID", visible: false, dataKey: "ID" },
                                { headerText: "Codigo", width: 80, dataKey: "Codigo", dataType: "string", filterOperator: "BeginsWith" },
                                { headerText: "Nombre", width: 250, dataKey: "Nombre", dataType: "string", filterOperator: "BeginsWith" },
                                { headerText: "RFC", width: 185, dataKey: "RFC", dataType: "string", filterOperator: "BeginsWith" },
                                { headerText: "RazonSocial", width: 250, dataKey: "RazonSocial", dataType: "string", filterOperator: "BeginsWith" },
                                { headerText: "Telefonos", width: 90, dataKey: "Telefonos", dataType: "string", filterOperator: "BeginsWith" },
                                { headerText: "Estatus", width: 90, dataKey: "Estatus", dataType: "string", filterOperator: "BeginsWith" },
                                { headerText: "Poblacion", visible: false, dataKey: "Poblacion" },
                                { headerText: "Municipio", visible: false, dataKey: "Municipio" },
                                { headerText: "Calle", visible: false, dataKey: "Calle" }
                              ];

            /*****************************************************************************/
            //Inicializar opciones del catálogo
            var CatalogOptions = {
                ViewModel: CatalogViewModel,
                ValidatorOptions: validatorOptions,
                MainDiv: $('#MainDiv'),
                EditForm: $('#EditForm'),
                DialogWidth: 750,
                ListColumns: Columns,
                CloseOnSave: false,
                AddingItem: function (viewModel, info) {
                    //viewModel.CargarSucursales(info.Identity);
                },
                LoadingInfo: function (viewModel, info) {
                    //viewModel.CargarSucursales(info.Identity);
                },
                SavingInfo: function (viewModel) {

                }
            }
        
            var Form = new Kernel.Forms.CatalogForm(CatalogOptions);

            var selPoblacion = new Kernel.Controls.PoblacionesSelector($('#selPoblacion'));

            //Enlazar view model del catálogo con ko
            /*****************************************************************************/
            ko.applyBindings(CatalogViewModel, $('#form1')[0]);

           

    });

    </script>

    <form id="form1" runat="server">
        <div id="MainDiv" class="ui-form">  
   
            <div id="EditForm">
           
               <table id="tblMain">
                    <tr>
                        <td>
                            <table id="tblEdit">
                                <tr> <!--Codigo-->
                                    <%--<td style="width:60px" width="100px" class="NormalLabel">Código:</td>                    
                                    <td>
                                        <input id="txtCodigo" name="txtCodigo" type="text" class="TextField" style="width:100px" tabindex="1" data-bind="value: CatalogInfo.Code" />
                                    </td>--%>
                                    <td style="width:60px" width="200px" class="NormalLabel">Correo Electrónico:</td>                 
                                    <td>
                                        <input id="txtCorreo" name="txtCorreo" type="text" class="TextField" style="width:200px" tabindex="1" data-bind="value: CatalogInfo.Correo" />
                                    </td>

                                </tr>
                                <tr>
                                    <td class="RequiredLabel">Nombre:</td>
                                    <td>
                                        <input id="txtNombre" name="txtNombre" type="text" class="TextField" style="width:600px" tabindex="1" data-bind="value: CatalogInfo.Nombre" />
                                    </td>
                                 </tr>
                                 <tr>
                                    <td class="RequiredLabel">RFC:</td>
                                    <td>
                                        <input id="txtRFC" name="txtRFC" type="text" class="TextField" style="width:150px" tabindex="1" data-bind="value: CatalogInfo.RFC" />
                                    </td>
                                 </tr>    
                                 <tr>
                                    <td class="RequiredLabel">Razón Social:</td>
                                    <td>
                                        <input id="txtRazonSocial" name="txtRazonSocial" type="text" class="TextField" style="width:600px" tabindex="1" data-bind="value: CatalogInfo.RazonSocial" />
                                    </td>
                                 </tr>    

                                 <tr>
                                    <td class="RequiredLabel">Calle:</td>
                                    <td>
                                        <input id="txtCalle" name="txtCalle" type="text" class="TextField" style="width:300px" tabindex="1" data-bind="value: CatalogInfo.CalleFiscal" />
                                    </td>
                                 </tr>
                                 <tr>
                                    <td class="RequiredLabel">Num.Ext:</td>
                                    <td>
                                        <input id="txtNumExt" name="txtNumExt" type="text" class="TextField" style="width:100px" tabindex="1" data-bind="value: CatalogInfo.NumExtFiscal" />
                                    </td>
                                </tr>
                                 <tr>
                                    <td class="RequiredLabel">Num.Int:</td>
                                    <td>
                                        <input id="txtNumInt" name="txtNumInt" type="text" class="TextField" style="width:100px" tabindex="1" data-bind="value: CatalogInfo.NumIntFiscal" />
                                    </td>
                                 </tr>    
                                
                                 <tr>
                                    <td class="RequiredLabel">Colonia:</td>
                                    <td>
                                        <input id="txtColonia" name="txtColonia" type="text" class="TextField" style="width:600px" tabindex="1" data-bind="value: CatalogInfo.ColoniaFiscal" />
                                    </td>
                                 </tr>    

                                 <tr>
                                    <td class="RequiredLabel">C.P.:</td>
                                    <td>
                                        <input id="txtCP" name="txtCP" type="text" class="TextField" style="width:600px" tabindex="1" data-bind="value: CatalogInfo.CPFiscal" />
                                    </td>
                                 </tr>    

                                <tr>                                
                                    <td class="RequiredLabel" >Población:</td> 
                                    <td>
                                        <div id="selPoblacion" tabindex="9" data-bind="selectorValue: CatalogInfo.IdPoblacionFiscal"></div>
                                    </td>
                                </tr>

                            </table>
                        </td>
                    </tr>
                </table>
            </div> <!--EditForm-->                                
   
        </div> <!--MainDiv-->

    </form>
</body>
</html>
