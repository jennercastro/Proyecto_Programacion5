<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaMaestra.Master" AutoEventWireup="true" 
    CodeBehind="frmListaUsuarios.aspx.cs" Inherits="ProyectoNuevoFinal.Formularios.frmListaUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br/>
    <center>
    <asp:GridView ID="MiGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Cedula" HeaderText="Cédula" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="Apellido1" HeaderText="Primer Apellido" />
            <asp:BoundField DataField="Apellido1" HeaderText="Segundo Apellido" />
            <asp:BoundField DataField="Correo" HeaderText="Correo" />
            <asp:BoundField DataField="Telefono1" HeaderText="Telefono1" />
            <asp:BoundField DataField="Telefono2" HeaderText="Telefono 2" />
            <asp:BoundField DataField="Fecha_Nacimiento" HeaderText="Fecha de Nacimiento" />
            <asp:BoundField DataField="Genero" HeaderText="Género" />
            <asp:BoundField DataField="Cod_Tipo_Usuario" HeaderText="Tipo Usuario" />
            <asp:BoundField DataField="Cobertura" HeaderText="Cobertura Póliza" />
            <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="frmEliminaUsuario.aspx?Id={0}" NavigateUrl="~/Formularios/frmEliminaUsuario.aspx" Text="Eliminar" />
            <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="frmModificarUsuario.aspx?Id={0}" NavigateUrl="~/Formularios/frmModificarUsuario.aspx" Text="Modificar" />
           
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    </center>
    <br/> <br/> <br/> <br/> <br/> <br/> <br/> <br/> <br/> <br/> <br/> <br/> <br/> <br/> <br/> <br/>
</asp:Content>