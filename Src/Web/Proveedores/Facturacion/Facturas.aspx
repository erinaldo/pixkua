<%@ Page Title="Facturas Enviadas" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Facturas.aspx.vb" Inherits="Facturacion_Facturas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 50px;
            text-align:right;
            font:Arial;
            font-size:10pt;
            padding-right:4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Menu ID="mnuFacturas" runat="server" BackColor="#F7F6F3" 
        DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" 
        ForeColor="#7C6F57" Orientation="Horizontal" StaticSubMenuIndent="10px">
        <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <DynamicMenuStyle BackColor="#F7F6F3" />
        <DynamicSelectedStyle BackColor="#5D7B9D" />
        <Items>
            <asp:MenuItem ImageUrl="~/Imagenes/refresh_32.gif" Text="Actualizar Lista" 
                Value="Actualizar"></asp:MenuItem>
            <asp:MenuItem ImageUrl="~/Imagenes/invoice_32.gif" Text="Cargar Factura" 
                Value="Cargar" NavigateUrl="~/Facturacion/CargarFactura.aspx"></asp:MenuItem>
        </Items>
        <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <StaticSelectedStyle BackColor="#5D7B9D" />
    </asp:Menu>

    <table id="tblFacturas" border="0" width="100%" cellpadding="0">
        <tr>
            <td class="style1">Año:</td>
            <td>
                <asp:TextBox ID="txtAnio" runat="server" Width="70px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvAnio" runat="server" 
                    ControlToValidate="txtAnio" Display="Dynamic" 
                    ErrorMessage="Debe introducir el año" Font-Size="8pt"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="rgvAnio" runat="server" ControlToValidate="txtAnio" 
                    Display="Dynamic" ErrorMessage="El año debe ser mayor a 2010" Font-Size="8pt" 
                    MaximumValue="2050" MinimumValue="2010" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="style1">Mes:</td>
            <td>
                <asp:DropDownList ID="cboMes" runat="server" Width="100px">
                    <asp:ListItem Value="1">Enero</asp:ListItem>
                    <asp:ListItem Value="2">Febrero</asp:ListItem>
                    <asp:ListItem Value="3">Marzo</asp:ListItem>
                    <asp:ListItem Value="4">Abril</asp:ListItem>
                    <asp:ListItem Value="5">Mayo</asp:ListItem>
                    <asp:ListItem Value="6">Junio</asp:ListItem>
                    <asp:ListItem Value="7">Julio</asp:ListItem>
                    <asp:ListItem Value="8">Agosto</asp:ListItem>
                    <asp:ListItem Value="9">Septiembre</asp:ListItem>
                    <asp:ListItem Value="10">Octubre</asp:ListItem>
                    <asp:ListItem Value="11">Noviembre</asp:ListItem>
                    <asp:ListItem Value="12">Diciembre</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvMes" runat="server" 
                    ControlToValidate="cboMes" Display="Dynamic" 
                    ErrorMessage="Debe elegir el mes a consultar" Font-Size="8pt"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:GridView ID="grdFacturas" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="HoraComprobante" HeaderText="Fecha" />
                        <asp:BoundField DataField="Serie" HeaderText="Serie" />
                        <asp:BoundField DataField="Folio" HeaderText="Folio" />
                        <asp:BoundField DataField="SubTotal" HeaderText="Sub Total" 
                            DataFormatString="{0:c}" />
                        <asp:BoundField DataField="ImpTrasladados" HeaderText="Impuestos" 
                            DataFormatString="{0:c}" />
                        <asp:BoundField DataField="Total" HeaderText="Total" DataFormatString="{0:c}" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="False" Font-Names="Arial" 
                        Font-Size="10pt" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

