<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmCerrarSesion.aspx.cs"
    Inherits="ProyectoNuevoFinal.Formularios.frmCerrarSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <h1>Cierre de la Sesion del Usuario</h1>
    <p>Desea Salir de la aplicacion?</p>
    <p>&nbsp;<asp:Button ID="btnSi" runat="server" OnClick="btnSi_Click" Text="SI" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="NO" />
    </p>

</asp:Content>
