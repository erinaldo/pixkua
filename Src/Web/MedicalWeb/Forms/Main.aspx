<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Main.aspx.vb" Inherits="Azteca.Web.Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pixkua - Menú Principal</title>
    <!--THEME-->
    <link href="http://code.jquery.com/ui/1.10.3/themes/south-street/jquery-ui.min.css" class="cssTheme"
        rel="stylesheet" type="text/css" />

    <!--Wijmo Widgets CSS-->    
    <link href="http://cdn.wijmo.com/jquery.wijmo-complete.all.2.3.9.min.css" rel="stylesheet" type="text/css" />
    <link href="../Styles/jquery-ui-form.css" rel="stylesheet" type="text/css" />
    <link href="../Styles/MainConsole.css" rel="stylesheet" type="text/css" />
    <link href="../Styles/wijaccordion.css" rel="Stylesheet" type="text/css" />
    <link href="../Styles/wijtabs.css" rel="Stylesheet" type="text/css" />

    <!--jQuery-->  
    <script src="http://ajax.aspnetcdn.com/ajax/jquery/jquery-1.8.2.min.js" type="text/javascript"></script>
    <script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.1/jquery-ui.min.js" type="text/javascript"></script>
    <script src="../Scripts/Json/json2.js" type="text/javascript"></script>    
    <!--Wijmo Widgets JavaScript-->    
    <script src="http://cdn.wijmo.com/jquery.wijmo-open.all.3.20132.8.min.js" type="text/javascript"></script>
    <script src="http://cdn.wijmo.com/jquery.wijmo-pro.all.3.20132.8.min.js" type="text/javascript"></script>    
    <!--Knockout-->
    <script src="http://cdn.wijmo.com/wijmo/external/knockout-2.2.0.js" type="text/javascript"></script>    
    <script src="http://cdn.wijmo.com/external/knockout.wijmo.js" type="text/javascript"></script>    
    <!--AZTECA-->
    <script src="../Scripts/JQuery/jquery-azteca-kernel.js?<%=ScriptsVersion%>" type="text/javascript"></script>    
    <script src="../Scripts/JQueryUI/jquery-ui-widgets.js?<%=ScriptsVersion%>" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("body").on({
                ajaxStart: function () {
                    $(this).addClass("loading");
                },
                ajaxStop: function () {
                    $(this).removeClass("loading");
                }
            });

            $('#MsgBox').msgbox();

            $('#MenuPrincipal').wijaccordion();

            $('.PanelOptionImage').live("mouseenter", function () {
                $(this).addClass('ui-state-hover ui-corner-all');
            })
            .live("mouseleave", function () {
                $(this).removeClass('ui-state-hover ui-corner-all');
            });

        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table id="tblMain" border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr>
                <td>
                    <div id="MenuPrincipal" style="width:200px; height:600px">
                        <h3>Administración</h3>
                        <div>
                            <table id="tblAdmin" class="PanelContent" cellpadding="0" cellspacing="0" width="100%">
                                <tbody>
                                    <tr>
                                        <td class="PanelOptionImage">
                                            <a href="Medical/AgendaSalas.aspx" target="_blank"><img src="../Images/Medical/appointment_scheduler_128.png" /></a>                                                
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="PanelOptionText"><a href="Medical/AgendaSalas.aspx" target="_blank">Agenda de Salas</a></td>
                                    </tr>
                                    <tr>
                                        <td class="PanelOptionImage">
                                            <a href="Medical/Expedientes.aspx" target="_blank"><img src="../Images/Medical/medical_history_128.png" /></a>                                                
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="PanelOptionText"><a href="Medical/Expedientes.aspx" target="_blank">Expedientes Clínicos</a></td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <h3>Catálogos</h3>
                        <div>
                            <table id="tblCatalogos" class="PanelContent" cellpadding="0" cellspacing="0" width="100%">
                                <tbody>
                                    <tr>
                                        <td class="PanelOptionImage">
                                            <a href="Medical/Pacientes.aspx" target="_blank"><img src="../Images/Medical/patient_128.png"/></a>                                                
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="PanelOptionText"><a href="Medical/Pacientes.aspx" target="_blank">Pacientes</a></td>
                                    </tr>
                                    <tr>
                                        <td class="PanelOptionImage">
                                            <a href="Medical/Doctores.aspx" target="_blank"><img src="../Images/Medical/doctor_128.png"/></a>                                                
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="PanelOptionText"><a href="Medical/Doctores.aspx" target="_blank">Doctores</a></td>
                                    </tr>

                                     <tr>
                                        <td class="PanelOptionImage">
                                            <a href="Medical/Salas.aspx" target="_blank"><img src="../Images/Medical/operating_room_128.png"/></a>                                                
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="PanelOptionText"><a href="Medical/Salas.aspx" target="_blank">Salas</a></td>
                                    </tr>

                                </tbody>
                            </table>
                        </div>                                
                        <h3>Seguridad</h3>
                        <div>
                            <table id="tblSeguridad" class="PanelContent" cellpadding="0" cellspacing="0" width="100%">
                                <tbody>
                                    <tr>
                                        <td class="PanelOptionImage">
                                            <a href="Security/Usuarios.aspx" target="_blank"><img src="../Images/Security/user_128.png" /></a>                                                
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="PanelOptionText"><a href="Security/Usuarios.aspx" target="_blank">Usuarios</a></td>
                                    </tr>
                                    <tr>
                                        <td class="PanelOptionImage">
                                            <a href="Security/AdminSeguridad.aspx" target="_blank"><img src="../Images/Security/Keys128.png" /></a>                                                
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="PanelOptionText"><a href="Security/AdminSeguridad.aspx" target="_blank">Accesos</a></td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>                                
                    </div>
                </td>
                <td>

                </td>
            </tr>
        </table>
    </form>
</body>
</html>
