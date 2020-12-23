<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaMaestra.Master" AutoEventWireup="true" 
    CodeBehind="frmLogin.aspx.cs" Inherits="ProyectoNuevoFinal.Formularios.frmLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Alias usuario:
        <asp:TextBox ID="txtAliasUsuario" runat="server"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator ID="rqvcorreo" runat="server" ControlToValidate="txtAliasUsuario" ErrorMessage=" Alias de Usuario Requerido"></asp:RequiredFieldValidator>
        <div>
            Contraseña:
            <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqvPass" runat="server" ControlToValidate="txtpass" ErrorMessage="Contraseña Requerida "></asp:RequiredFieldValidator>

            <br />
            <asp:Label ID="lblResultado" runat="server"></asp:Label>
            <br />

            <asp:Button ID="btningresar" runat="server" OnClick="btningresar_Click" Text="Ingresar" />
                        &nbsp;<asp:Button ID="btnRegistroUsuario" runat="server" OnClick="btnRegistroUsuario_Click" Text="Registrar Usuario" />
&nbsp;<asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>

</asp:Content>
