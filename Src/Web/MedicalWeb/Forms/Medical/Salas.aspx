<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Doctores.aspx.vb" Inherits="Azteca.Web.Doctores" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Catálogo de Salas</title>
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
            this.CatalogInfo = new Business.Medicina.SalaInfo();
            this.CatalogService = new Business.Medicina.SalaService();

            /******************USUARIOS***********************************************************/
            this.Usuarios = ko.observableArray([]);

            this.CargaUsuarios = function () {
                self.CatalogService.LoadUserAccess(self.CatalogInfo.Identity())
                        .done(function (data) {
                            var Result = $.parseJSON(data);
                            self.Usuarios(Result);
                        })
                        .fail(function (e, textStatus, error) {
                            Form.MsgBox({ title: 'Error', message: e.responseText, icon: 'error', okButton: true });
                        });
            }

            this.AddUser = function (user) {
                self.CatalogService.AddUser(self.CatalogInfo.Identity(), user.IdUsuario)
                .done(function (data) {
                    self.Usuarios.push(user);
                })
                .fail(function (e) {
                    Form.MsgBox({ title: 'Error', message: e.responseText, icon: 'error', okButton: true });
                });
            }

            this.RemoveUser = function (IdUsuario) {
                self.CatalogService.RemoveUser(self.CatalogInfo.Identity(), IdUsuario)
                    .done(function (data) {
                        self.Usuarios.remove(function (item) {
                            return item.IdUsuario == IdUsuario
                        });
                    })
                        .fail(function (e) {
                            Form.MsgBox({ title: 'Error', message: e.responseText, icon: 'error', okButton: true });
                        });
            }

            /************************************FIN USUARIOS*****************************************/
            
            
                
        }

        $(document).ready(function () {

            function Usuario(data) {
                this.IdUsuario = data.IdUsuario;
                this.Nombre = data.Nombre;
                this.Codigo = data.Codigo;
            }

            var CatalogViewModel = new ViewModel();

            //Definir validador del formulario
            var validatorOptions = {
                rules: {
                    txtNombre: "required",
                    txtTiempoAtencion: "required"
                },
                messages: {
                    txtNombre: "Por favor ingrese el nombre de la Sala",
                    txtTiempoAtencion: "Debe introducir el tiempo en minutos de atención promedio."
                }
            }

            /*****************************************************************************/
            //Grid de catalogo de Salas
            var Columns = [
                         { headerText: "ID", visible: false, dataKey: "ID" },
                         { headerText: "IdSala", visible: false, dataKey: "IdSala" },
                         { headerText: "Codigo", dataKey: "Codigo", dataType: "string", filterOperator: "BeginsWith", width: 100 },
                         { headerText: "Nombre", dataKey: "Nombre", dataType: "string", filterOperator: "BeginsWith", width: 250 },
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
                    $("#txtTiempoAtencion").val(info.TiempoAtencion);
                    CatalogViewModel.CargaUsuarios();
                },
                SavingInfo: function (viewModel) {
                    viewModel.CatalogInfo.TiempoAtencion( $("#txtTiempoAtencion").val());
                }
            }
            var Form = new Kernel.Forms.CatalogForm(CatalogOptions);

            /*****************************************************************************/
            //Generar elementos especificos de la forma
            $("#tabs").wijtabs({ alignment: 'left' });
            $("#txtTiempoAtencion").wijinputnumber({ increment: 5, decimalPlaces: 0, showDropDownButton: true });
            //Enlazar view model del catálogo con ko
            /*****************************************************************************/
            ko.applyBindings(CatalogViewModel, $('#form1')[0]);

            //CatalogViewModel.CargarEspecialidades();

            //-------------------------USUARIOS----------------------------------------

            //Crear cuadro de diálogo para selección de usuarios y callback cuando se seleccionen elementos
            var dlgUsuarios = new Kernel.Dialogs.UsuariosList($('#lstUsuarios'), true, function (e, args) {
                var selectedSites = dlgUsuarios.GetSelection();
                var currentSites = CatalogViewModel.Usuarios();
                $.each(selectedSites, function (index, selectedSite) {
                    //Verificar si ya existe el almacen en el area
                    var match = $.grep(currentSites, function (currentSite, index) {
                        return currentSite.IdUsuario == selectedSite.ID;
                    });
                    if (match.length == 0) {
                        var user = new Usuario({ IdUsuario: selectedSite.ID, Codigo: selectedSite.Codigo, Nombre: selectedSite.Usuario, Entrada: false, Salida: false });
                        CatalogViewModel.AddUser(user);
                    }
                });
            });


            $('#tlbMenuUsuarios').toolbar({
                buttonHeight: 32, buttonWidth: 32,
                buttons: [{ text: "Agregar", key: "btnAgregar", image: "General/AddItem_64.png"}],
                buttonClick: function (e, data) {
                    if (data.key == "btnAgregar") {
                        dlgUsuarios.Show();
                    }
                }
            });

            //Grid para información de usuarios
            $("#grdUsuarios").wijgrid({ ensureColumnsPxWidth: true, showFilter: true, allowPaging: true, pageSize: 10, allowEditing: true,
                columns: [
                { headerText: "", width: 30, showFilter: false,
                    cellFormatter: function (args) {
                        if (args.row.type & $.wijmo.wijgrid.rowType.data) {
                            args.$container.attr('align', 'center');
                            args.$container.empty().append(
                                $("<a href='#'><img src='" + App.ImagePath + "/General/Trash_16.png' alt='' class=''/></a>")
                                    .click(function (e) {
                                        CatalogViewModel.RemoveUser(args.row.data.IdUsuario);
                                        return false;
                                    })
                                );
                            return true;
                        }
                    }
                },
                { headerText: "ID", visible: false, dataKey: "IdUsuario" },
                { headerText: "Usuario", dataKey: "Codigo", dataType: "string", width: 80, filterOperator: "BeginsWith" },
                { headerText: "Nombre", dataKey: "Nombre", dataType: "string", width: 300, filterOperator: "BeginsWith" }
    ]
            });

            //-------------------------FIN DE USUARIOS----------------------------------------

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
                            <li><a href="#tabs-2">Seguridad</a></li>
                        </ul>
                        <div id="tabs-1">
                            <table id="tblGenerales" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td class="NormalLabel" style="width:120px">Tiempo de Atención Promedio(Min):</td>
                                    <td>
                                        <input id="txtTiempoAtencion" name="txtTiempoAtencion" type="text" class="TextField" style="width:150px" tabindex="2" data-bind="text: CatalogInfo.TiempoAtencion"/>
                                    </td>
                                </tr>
                            </table>         
                        </div>

                        <div id="tabs-2">
                            <div id="tlbMenuUsuarios" data-bind="buttonDisabled: (CatalogInfo.Identity() > 0), index:0"></div>
                            <table id="grdUsuarios" data-bind="wijgrid: { data: Usuarios }"></table>
                        </div>

                    </div>
                 </div>

            </div>
        </div>
    </form>

     <div id="lstUsuarios"></div>

</body>
</html>
