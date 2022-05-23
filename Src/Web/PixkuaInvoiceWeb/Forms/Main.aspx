<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Main.aspx.vb" Inherits="Azteca.Web.Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 157px;
        }
    </style>
</head>
<body class="page">
    <form id="form1" runat="server">
    <table id="tblHeader" border="0" cellpadding="0" cellspacing="0" width="100%" class="ui-widget">
        <tr>
            <td class="ui-widget-content" align="left">
               Azteca Software
            </td>
        </tr>
        <tr>
            <td class="ui-widget-header" style="font-size:20pt; vertical-align:bottom; background:color.grey">
                <table id="tblTitle" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                       <td style="vertical-align:bottom; width:80%">
                                <img src="../Images/Header-azteca-software.png" alt="Logo" height="226px" 
                                style="width: 1210px" />                            
                        </td>
                        
                        
                    </tr>
                </table>
                
                
            </td>
        </tr>
    </table>
    <div class="pageContent">
        <table id="tblMain" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <div id="MenuPrincipal" 
                        style="width:200px; height:600px; background-color: #C0C0C0;">
                        <h3 style="background-color: #333333; text-align: center; color: #FFFFFF;">Opciones</h3>
                        <div>
                            <table id="tblFinanzas" class="PanelContent" cellpadding="0" cellspacing="0" width="100%">
                                <tr>
                                    <td class="PanelOptionImage">
                                        <a href="#"><img src="../Images/Factura.png" alt="Facturacion"/></a>                                                
                                    </td>
                                </tr>
                                <tr>
                                    <td class="PanelOptionText"><a href="#">Facturación CFDI</a></td>
                                </tr>
                                <tr>
                                    <td class="PanelOptionImage">
                                        <a href="#"><img src="../Images/Nomina.png" alt="Nomina"/></a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="PanelOptionText"><a href="Ventas/Clientes.aspx">Catálogo de Clientes</a></td>
                                </tr>
                                <tr>
                                    <td style="height:150px"></td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </td>
                <td class="OptionsList">
                    <ul>
                        <li><a href="Kernel/General/Paises.aspx" class="Paises" target="_blank">Catálogo de Paises</a></li>
                        <li><a href="Kernel/General/Estados.aspx" class="Estados" target="_blank">Catálogo de Estados</a></li>
                        <li><a href="Kernel/General/Municipios.aspx" class="Municipios" target="_blank">Catálogo de Municipios</a></li>
                        <li><a href="Kernel/General/Poblaciones.aspx" class="Poblaciones" target="_blank">Catálogo de Poblaciones</a></li>
                        <li><a href="Kernel/Security/Empresas.aspx" class="Empresas" target="_blank">Catálogo de Empresas</a></li>
                        <li><a href="Kernel/Security/Usuarios.aspx" class="Usuarios" target="_blank">Catálogo de Usuarios</a></li>
                        <li><a href="Kernel/Security/Grupos.aspx" class="Grupos" target="_blank">Catálogo de Grupos</a></li>
                        <li><a href="Kernel/Security/Modulos.aspx" class="Grupos" target="_blank">Catálogo de Móduos</a></li>
                        <li><a href="Ventas/Clientes.aspx" class="Grupos" target="_blank">Catálogo de Clientes</a></li>
                        <li><a href="RH/TiposEvento.aspx" class="Grupos" target="_blank">Catálogo de tipos de evento</a></li>
                        <li><a href="BienesRaices/Predios.aspx" class="Predios" target="_blank">Administración de Predios</a></li>
                        <li><a href="Inventario/Articulos.aspx" class="Articulos" target="_blank">Catálogo de Artículos</a></li>
                        <li><a href="Inventario/ArticulosTipos.aspx" class="Articulos" target="_blank">Catálogo de Tipos de Artículos</a></li>
                    </ul>
                </td>
                <td class="PanelInfo" valign="top">
                    <table id="tblSesion" class="ui-widget ui-corner-all" width="100%" border="0" cellpadding="0" cellspacing="0">
                        <tr>
                            <td class="ui-widget-header">Sesión</td>
                        </tr>
                        <tr>
                            <td class="ui-widget-content">
                                <p>Empresa:</p>
                                <p>Azteca Software S.A. de R.L./p>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>

    <div id="OptionDialog" title="Opción">
    </div>
    </form>
</body>
</html>
