<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Usuarios.aspx.vb" Inherits="Azteca.Web.Usuarios" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Catálogo de Usuarios</title>
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
        /*****************************************************************************/
        //Definir View Model del catálogo
        function ViewModel() {
            var self = this;
            this.CatalogInfo = new Kernel.Security.UsuarioInfo();
            this.CatalogService = new Kernel.Security.UsuarioService();

        }

        $(document).ready(function () {

            var CatalogViewModel = new ViewModel();

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
                                { headerText: "Usuario", width: 80, dataKey: "Usuario", dataType: "string", filterOperator: "BeginsWith" },
                                { headerText: "Nombre", width: 250, dataKey: "Nombre", dataType: "string", filterOperator: "BeginsWith" },
                                { headerText: "Estatus", width: 90, dataKey: "Estatus", dataType: "string", filterOperator: "BeginsWith" }
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

            //Enlazar view model del catálogo con ko
            /*****************************************************************************/
            ko.applyBindings(CatalogViewModel, $('#form1')[0]);

                     
        });



    </script>
    <form id="form1" runat="server">
    <div id="MainDiv" class="ui-form">
    <div id="EditForm">
        <table id="tblMain" cellpadding="0" cellspacing="0">
            <tr>
                <td style="width:70px" class="RequiredLabel">Usuario:</td>
                <td>
                    <input id="txtNombreUsuario" name="txtNombreUsuario" type="text" class="TextField" style="width:150px" data-bind="value: CatalogInfo.Usuario" />
                </td>
            </tr>
        </table>

        <div id="tabs">
            <ul>
                <li><a href="#tabs-1">Generales</a></li>
            </ul>
            <div id="tabs-1">
                <table id="tblGenerales" cellpadding="0" cellspacing="0">
                    <tr>
                        <td class="RequiredLabel" style="width:130px">Contraseña:</td>
                        <td>
                            <input id="txtPass" name="txtPass" type="password" class="TextField" style="width:150px" data-bind="value: CatalogInfo.Password" />
                        </td>                            
                    </tr>
                    <tr>
                        <td class="RequiredLabel">Confirmar:</td>
                        <td>
                            <input id="txtConfirmarPass" name="txtConfirmarPass" type="password" class="TextField" style="width:150px" />
                        </td>                            
                    </tr>
                    <tr>
                        <td class="NormalLabel">Usuario Dominio:</td>
                        <td>
                            <input id="txtDomainUser" name="txtDomainUser" type="text" class="TextField" style="width:150px" data-bind="value: CatalogInfo.DomainUser" />
                        </td>
                    </tr>
                    <tr>
                        <td class="RequiredLabel">Nombre:</td>
                        <td>
                            <input id="txtNombre" name="txtNombre" type="text" class="TextField" style="width:350px" data-bind="value: CatalogInfo.Persona.Nombre" />
                        </td>
                    </tr>
                    <tr>
                        <td class="RequiredLabel">Apellido Paterno:</td>
                        <td>
                            <input id="txtApellidoPat" name="txtApellidoPaterno" type="text" class="TextField" style="width:250px" data-bind="value: CatalogInfo.Persona.ApellidoPaterno" />
                        </td>
                    </tr>
                        <tr>
                        <td class="RequiredLabel">Apellido Materno:</td>
                        <td>
                            <input id="txtApellidoMat" name="txtApellidoMaterno" type="text" class="TextField" style="width:250px" data-bind="value: CatalogInfo.Persona.ApellidoMaterno" />
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
