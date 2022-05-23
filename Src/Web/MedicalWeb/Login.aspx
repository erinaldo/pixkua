<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="Azteca.Web.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pixkua - Inicio de Sesión</title>
    <!--Wijmo Widgets CSS-->    
    <link href="Styles/redmond/jquery-ui-1.10.3.custom.min.css"
        rel="stylesheet" type="text/css" />    
    <link href="http://cdn.wijmo.com/jquery.wijmo-complete.all.2.3.9.min.css" rel="stylesheet" type="text/css" />        
    <!--AZTECA-->
    <link href="Styles/jquery-ui-form.css" rel="stylesheet" type="text/css" />
    <link href="Styles/jquery-ui-widgets.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <!--jQuery-->  
    <script src="http://ajax.aspnetcdn.com/ajax/jquery/jquery-1.8.2.min.js" type="text/javascript"></script>   
    <script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.1/jquery-ui.min.js" type="text/javascript"></script>
    <script src="Scripts/Json/json2.js" type="text/javascript"></script>
    <!--Wijmo Widgets JavaScript-->
    <script src="http://cdn.wijmo.com/jquery.wijmo-open.all.2.3.9.min.js" type="text/javascript"></script>
    <script src="http://cdn.wijmo.com/jquery.wijmo-complete.all.2.3.9.min.js" type="text/javascript"></script>

    <script type="text/javascript">
        $(document).ready(function () {
            var Empresas;
            var Sucursales;
            var Session;

            $("body").on({
                ajaxStart: function () {
                    $(this).addClass("loading");
                },
                ajaxStop: function () {
                    $(this).removeClass("loading");
                }
            });
            
            $('.ActionButton').button();
            $('.ui-state-error').hide();

            $('#btnIniciarSesion').click(function (e) {                
                $('#ErrorContainer').hide();
                for (var i in Page_Validators) {
                    ValidatorValidate(Page_Validators[i]);
                    if (Page_Validators[i].isvalid == false) { return; }
                }
                Login();
                e.preventDefault();                
            });

            function Login() {
                var url = "Services/Kernel/Usuario.svc/Login";
                var userName = $('#txtNombre').val();
                var password = $('#txtPassword').val();
                var data = { 'userName': userName, 'password': password }
                $.ajax({
                    type: "POST", url: url, data: JSON.stringify(data), contentType: "application/json; charset=utf-8", dataType: "json",
                    success: function (msg) {
                        Session = $.parseJSON(msg);
                        $('#hdnSessionID').val(Session.SessionID);
                        $('#hdnIdEmpresa').val("1");
                        $('#hdnIdSucursal').val("1");
                        <%= Page.ClientScript.GetPostBackEventReference(btnIniciarSesion, String.Empty) %>;
                    },
                    error: function (e) {
                        $('#ErrorContainer').show();
                        $('#ErrorText').text(e.responseText);
                    }
                });
            }


        });

    </script>

    <form id="form1" runat="server">
        <asp:HiddenField ID="hdnSessionID" runat="server"/>
        <asp:HiddenField ID="hdnIdEmpresa" runat="server"/>
        <asp:HiddenField ID="hdnIdSucursal" runat="server"/>

        <table id="tblMain" border="0" cellpadding="10" cellspacing="0" width="100%">
            <tr>
                <td style="height:600px">
                </td>

                <td valign="top" style="width:225px; background: #fafaf4 url(images/ui-bg_highlight-hard_100_fafaf4_1x100.png) 50% 50% repeat-x;">                    
                    <table id="tblLogin" border="0" cellpadding="0" cellspacing="0" width="100%">
                        <thead>
                            <tr>
                                <td colspan="2" class="ui-widget-header ui-corner-all" style="font-weight:bold; text-align:center">Inicio de Sesión</td>
                            </tr>
                        </thead>
                        <tr>
                            <td style="width:80px; height:30px; font-size:14px">Usuario:</td>
                            <td style="text-align:left">
                                <asp:TextBox ID="txtNombre" CssClass="TextBox" runat="server" Width="150px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" 
                                    ControlToValidate="txtNombre" CssClass="ui-state-error-text" Display="Dynamic" 
                                    ErrorMessage="Debe introducir el nombre de usuario" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:left;text-align:left; font-size:14px">Password:</td>
                            <td style="text-align:left">
                                <asp:TextBox ID="txtPassword" CssClass="TextBox" runat="server" Width="150px"
                                    TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="height:50px"></td>
                            <td align="left" valign="bottom">
                                <asp:Button ID="btnIniciarSesion" runat="server" Text="Iniciar Sesión" CssClass="ActionButton"
                                    onclick="btnIniciarSesion_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" valign="bottom" style="height:50px">
                                <div id="ErrorContainer" class="ui-state-error ui-corner-all" style="width:400px">
                                    <div id="ErrorIcon" class="ui-icon ui-icon-alert" style="float:left">
                                    </div>
                                    <p id="ErrorText" class="ui-helper-reset ui-state-error-text">Error</p>                
                                </div>
                            </td>
                        </tr>
                    </table>

                </td>
            </tr>
        </table>

        <div class="modal"></div>
        
    </form>

</body>
</html>
