<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaMaestra.Master" AutoEventWireup="true" 
    CodeBehind="frmInsertarAdiccion.aspx.cs" Inherits="ProyectoNuevoFinal.Formularios.frmInsertarAdiccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    
 <div class="container">
     <h1>Mantenimiento de Adicciones - Insertar</h1>
     <asp:HiddenField ID="HiddenUsuario" runat="server" />
<div class="col-lg-12 well">
        <div class="row">
                <div class="col-sm-12">
                    <div class="row">

                    <asp:Panel ID="PanelAlerta" runat="server" CssClass="col-md-12" Visible="false">
                        <div class="alert alert-danger alert-dismissable" role="alert">
                            <span class="glyphicon glyphicon-warning-sign"></span> <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
                         </div>
                    </asp:Panel>

                       

                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


                                <asp:Label ID="Label2" runat="server" Text="Ingrese  adicción"></asp:Label>
  
                                &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="txtNombreAdiccion" runat="server"></asp:TextBox>

                       
                            <br />
                    

                        </div>
                    </div>
                    <br />
                    <center>
                    <div class="form-horizontal">
                        <div class="col-md-12">
                            <asp:Button ID="btnGuardar" runat="server" class="btn btn-success  btn-lg" Text="Guardar" OnClick="btnGuardar_Click"   />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                          
                            
                      
                        </div>
                    </div>
                 </center>
                </div>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
        </div>
    </div>

    <br/><br/>
</asp:Content>