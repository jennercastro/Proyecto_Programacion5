<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaMaestra.Master" AutoEventWireup="true" 
    CodeBehind="frmEliminarUsuario.aspx.cs" Inherits="ProyectoNuevoFinal.Formularios.frmEliminarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    div class="container">
     <h1>Mantenimiento de Clientes - Eliminar</h1>
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

                        <div class="col-sm-4 form-group">
                            <label>Cédula</label><br/>
                            <asp:TextBox placeholder="Cédula" ID="txtCedula"  runat="server" Enabled="False"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;
                           
                         </div>
                        <div class="col-sm-4 form-group">
                            <label>Nombre</label><br />
                            <asp:TextBox placeholder="Nombre" ID="txtNombre" runat="server" Enabled="False"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                            
                        </div>
                        <div class="col-sm-4 form-group">
                            <label>Primer Apellido</label><br />
                            <asp:TextBox placeholder="Primer Apellido"  ID="txtPrimerApellido" runat="server" Enabled="False"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                            
                        </div>
                        <div class="col-sm-4 form-group">
                            <label>Segundo Apellido</label><br />
                            <asp:TextBox placeholder="Segundo Apellido" ID="txtSegundoApellido" runat="server" Enabled="False"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                           
                        </div>
                        <div class="col-sm-4 form-group">
                            <label>Correo</label><br />
                            <asp:TextBox placeholder="Correo"  ID="txtCorreo" runat="server" Enabled="False"></asp:TextBox>
                            &nbsp;&nbsp;
                           
                            <br />
                        </div>
                        <div class="col-sm-4 form-group">
                            <label>Teléfono 1</label><br />
                            <asp:TextBox placeholder="Teléfono 1"   ID="txtTelefono1" runat="server" Enabled="False"></asp:TextBox>
                            &nbsp;
                          
                            <br />
                        </div>
                        <div class="col-sm-4 form-group">
                            <label>Teléfono 2</label><br />
                            <asp:TextBox placeholder="Teléfono 2"  ID="txtTelefono2" runat="server" Enabled="False"></asp:TextBox>
                            &nbsp;&nbsp;
                            <br />
                        </div>
                         <div class="col-sm-4 form-group">
                            <label>Fecha de Nacimiento</label><br />
                            <asp:TextBox placeholder="Fecha de Nacimiento" ID="txtFechaNacimiento" runat="server" Enabled="False"></asp:TextBox>
                            &nbsp;&nbsp;
                             
                            <br />
                        </div>
                          <div class="col-sm-4 form-group">
                            <label>Género</label><br />
                            <asp:TextBox placeholder="Género" ID="txtGenero" runat="server" Enabled="False"></asp:TextBox>
                            &nbsp;
                             
                            <br />
                        </div>

                         <div class="col-sm-4 form-group">
                            <label>Tipo Usuario</label><br />
                             <asp:TextBox ID="txtTipo_Usuario" runat="server" Enabled="False"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                           
                            <br />
                        </div>
                        
                         <div class="col-sm-4 form-group">
                            <label>Tipo de cobertura</label><br />
                             <asp:TextBox ID="txtTipoCobertura" runat="server" Enabled="False"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                           
                            <br />
                        </div>
                    </div>
                    <br />
                    <center>
                    <div class="form-horizontal">
                        <div class="col-md-12">
                            <asp:Button ID="btnEliminar" runat="server" class="btn btn-success  btn-lg" Text="Eliminar" OnClick="btnEliminar_Click"  />
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
