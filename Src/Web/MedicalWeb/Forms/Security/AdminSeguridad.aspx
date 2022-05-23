<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AdminSeguridad.aspx.vb" Inherits="Azteca.Web.AdminSeguridad" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administrador de Seguridad</title>
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
        $(document).ready(function () {
            function ViewModel() {
                var self = this;
                this.UsuarioSvc = new Kernel.Security.UsuarioService();
                this.Accesos = ko.observableArray([]);

                this.CargarAccesos = function (idUsuario) {
                    self.UsuarioSvc.CargarAccesos(idUsuario)
                        .done(function (data) {
                            var Info = $.parseJSON(data);
                            self.Accesos(Info);
                        })
                        .fail(function (ex, error) {
                            $('#msgbox').msgbox('show', { title: "Error", message: error, icon: "error", okButton: true });
                        });
                }

                this.GuardarAccesos = function () {
                    var idUsuario = $('#selUsuario').catalogselector('value');
                    var accesos = ko.toJSON(self.Accesos);                    
                    self.UsuarioSvc.GuardarAccesos(idUsuario, accesos)
                        .done(function (data) {
                            $('#msgbox').msgbox('show', { title: "Información", message: "Los datos han sido guardados exitosamente.", icon: "info", okButton: true });
                        })
                        .fail(function (ex, error) {
                            $('#msgbox').msgbox('show', { title: "Error", message: error, icon: "error", okButton: true });
                        });
                }
            }

            var Model = new ViewModel();

            Kernel.Controls.UsuariosSelector($('#selUsuario'));
            $('#btnCargarAccesos').button();
            $('#btnCargarAccesos').click(function () {
                var idUsuario = $('#selUsuario').catalogselector('value');
                Model.CargarAccesos(idUsuario);
                $("#tabs").show();
                return false;
            });

            $('#tlbAccesos').toolbar({
                buttonHeight: 32, buttonWidth: 32,
                buttons: [
                    { text: "Guardar", key: "btnGuardar", image: "General/Save_64.png" }
                ],
                buttonClick: function (e, data) {
                    if (data.key == "btnGuardar") {
                        Model.GuardarAccesos();
                    }
                }
            });

            //Tabs            
            $("#tabs").wijtabs({ alignment: 'left' });
            $("#tabs").hide();


            $('#msgbox').msgbox();

            //ENLAZAR A KO
            ko.applyBindings(Model, $('#form1')[0]);
        });
    </script>
    <form id="form1" runat="server">
        <table id="tblUser" border="0" cellpadding="0" cellspacing="0" width="600px">
            <thead>
                <tr>
                    <td colspan="2" class="ui-widget-header">Administrador de Seguridad</td>
                </tr>
            </thead>
            <tbody class="ui-widget-content">
                <tr>
                    <td class="NormalLabel" style="width:100px; height:40px; border-left:1px solid #C0C0C0">Usuario:</td>
                    <td style="height:40px; border-right:1px solid #C0C0C0">
                        <div id="selUsuario"></div>
                    </td>
                </tr>
                <tr>
                    <td style="border-left:1px solid #C0C0C0; border-bottom:1px solid #C0C0C0"></td>
                    <td valign="bottom" align="right" style="height:40px;border-right:1px solid #C0C0C0; border-bottom:1px solid #C0C0C0; padding-right:5px; padding-bottom:5px">
                        <button id="btnCargarAccesos" style="font-size:10pt">Cargar Accesos</button>
                    </td>
                </tr>
            </tbody>
        </table>

        <div id="tabs" style="width:800px">
            <ul>
                <li><a href="#tabs-1">Accesos</a></li>
            </ul>
            <div id="tabs-1">
                <div id="tlbAccesos"></div>
                <table id="grdAccesos" class="ui-widget" border="0" cellpadding="0" cellspacing="0" width="500px" style="border:1px solid #C0C0C0">
                    <thead class=" ui-widget-header ui-border-all">
                        <tr>
                            <td style="width:400px;font-size:14px" >Proceso</td>
                            <td style="font-size:14px" align="center">Acceso</td>
                        </tr>
                    </thead>
                    <tbody data-bind="foreach: Accesos" class="ui-widget-content">
                        <tr>
                            <td style="font-size:10px" data-bind="text: Nombre"></td>
                            <td align="center">
                                <input type="checkbox" data-bind="checked: Acceso" />
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>

        </div>
    </form>

    <div id="msgbox"></div>
    <div class="modal"></div>

</body>
</html>
