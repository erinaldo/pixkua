<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="CargarFactura.aspx.vb" Inherits="Facturacion_CargarFactura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:FileUpload ID="updFactura" runat="server" Width="217px" />
    <asp:Button ID="btnCargar" runat="server" Text="Cargar" />
    <table id="tblCargar" border="0" width="100%">
        <tr>
            <td>
                <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblInfo" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

