<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaMaestra.Master" AutoEventWireup="true" 
    CodeBehind="frmListarCoberturaPoliza.aspx.cs" Inherits="ProyectoNuevoFinal.Formularios.frmListarCoberturaPoliza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><br/>
        <asp:GridView ID="GridViewCobertura" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Nombre" HeaderText="Cobertura" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
            <asp:BoundField DataField="Porcentaje" HeaderText="Porcentaje" />
            <asp:HyperLinkField Text="Eliminar" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="frmEliminarCobertura.aspx?Id={0}" NavigateUrl="~/Formularios/frmEliminarCobertura.aspx" />
            <asp:HyperLinkField Text="Modificar" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="frmModificarCobertura.aspx?Id={0}" NavigateUrl="~/Formularios/frmModificarCobertura.aspx" />
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
        </>
    <br/><br/><br/><br/><br/><br/><br/><br/><br/>
</asp:Content>