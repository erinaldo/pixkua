<%@ Page Title="Inicio de Sesión" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table id="tblLogin" border="0" cellpadding="0" align="center" width="100%">
        <tr>
            <td align="center">
                <asp:Login ID="Login1" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE" 
                    BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                    Font-Size="10pt" ForeColor="#333333" Height="193px" Width="389px" 
                    UserNameLabelText="Número de Proveedor:" 
                    FailureText="Error de inicio de sesión. Intente de nuevo." 
                    InstructionText="Ingrese su número de proveedor y password para ingresar al sitio de servicios." 
                    LoginButtonText="Iniciar Sesión" 
                    PasswordRequiredErrorMessage="El password es requerido" 
                    RememberMeText="Recordarme la próxima vez" TitleText="Inicio de Sesión" 
                    UserNameRequiredErrorMessage="El Número de proveedor es requerido.">
                    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                    <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" 
                        BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
                    <TextBoxStyle Font-Size="0.8em" />
                    <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" 
                        ForeColor="White" />
                </asp:Login>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

