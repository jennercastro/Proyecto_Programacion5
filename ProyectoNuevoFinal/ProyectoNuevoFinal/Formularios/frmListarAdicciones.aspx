<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaMaestra.Master" AutoEventWireup="true" 
    CodeBehind="frmListarAdicciones.aspx.cs" Inherits="ProyectoNuevoFinal.Formularios.frmListarAdicciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br/><br/>
    <center>
    <asp:GridView ID="GridViewAdicciones" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
             <asp:BoundField DataField="Id" HeaderText="ID" />
            <asp:BoundField DataField="Nombre" HeaderText="Adicciones" />
         
             <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="frmEliminarAdicciones.aspx?Id={0}" NavigateUrl="~/Formularios/frmElimarAdicciones.aspx" Text="Eliminar" />
         
             <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="frmModificarAdicciones.aspx?Id={0}" NavigateUrl="~/Formularios/frmListaUsuarios.aspx" Text="Modificar" />
         
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
    <br/>
    <br/>
    <br/>
    <br/><br/><br/><br/><br/>
</asp:Content>