<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaMaestra.Master" AutoEventWireup="true" 
    CodeBehind="frmModificarCobertura.aspx.cs" Inherits="ProyectoNuevoFinal.Formularios.frmModificarCobertura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
     <h1>Mantenimiento de Adicciones - Modificar</h1>
       <asp:HiddenField ID="HiddenUsuario1" runat="server" />
<div class="col-lg-12 well">
        <div class="row">
                <div class="col-sm-12">
                    <div class="row">
                      
                    <asp:Panel ID="PanelAlerta" runat="server" CssClass="col-md-12" Visible="false">
                        <div class="alert alert-danger alert-dismissable" role="alert">
                            <span class="glyphicon glyphicon-warning-sign"></span> <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
                         </div>
                    </asp:Panel>
                        <center>
                       
                            <div class="col-lg-12">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <div class="col-lg-6 form-group">
                                &nbsp;
                                <asp:Label ID="Label1" runat="server" Text=" ID"></asp:Label>
                                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-lg-6 form-group">
                                <asp:Label ID="Label2" runat="server" Text="Cobertura"></asp:Label>
                                  &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                            </div>
                        </div>
                              <div class="col-lg-12">
                             <div class="col-lg-6 form-group">
                                <asp:Label ID="Label3" runat="server" Text="Descripción"></asp:Label>
                                  &nbsp;
                                <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                            </div>
                             <div class="col-lg- form-group">
                                <asp:Label ID="Label4" runat="server" Text="Porcentaje"></asp:Label>
                                  &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="txtProcentaje" runat="server"></asp:TextBox>
                            </div>
                          </div>
                            <br />
                    

                        </div>
                    </div>
                    <br />
                    </center>
                    <div class="form-horizontal">
                        <div class="col-md-12">
                            <asp:Button ID="btnModificar" runat="server" class="btn btn-success  btn-lg" Text="Modificar" OnClick="btnModificar_Click"/>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         
                        </div>
                    </div>
                </div>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
        </div>
    </div>
    <br/><br/>

</asp:Content>
