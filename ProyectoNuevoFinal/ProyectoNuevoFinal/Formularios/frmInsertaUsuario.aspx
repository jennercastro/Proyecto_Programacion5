<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaMaestra.Master" AutoEventWireup="true" 
    CodeBehind="frmInsertaUsuario.aspx.cs" Inherits="ProyectoNuevoFinal.Formularios.frmInsertaUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="container">
     <h1>Mantenimiento de Clientes - Insertar</h1>
     
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
                            <asp:TextBox placeholder="Cédula" ID="txtCedula"  runat="server"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="rfvCedula" runat="server" ControlToValidate="txtCedula" ErrorMessage="Ingrese su cédula"></asp:RequiredFieldValidator>
                         </div>
                        <div class="col-sm-4 form-group">
                            <label>Nombre</label><br />
                            <asp:TextBox placeholder="Nombre" ID="txtNombre" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Ingrese su nombre"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-sm-4 form-group">
                            <label>Primer Apellido</label><br />
                            <asp:TextBox placeholder="Primer Apellido"  ID="txtPrimerApellido" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="rfvPrimerApellido" runat="server" ControlToValidate="txtPrimerApellido" ErrorMessage="Ingrese su primer apellido"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-sm-4 form-group">
                            <label>Segundo Apellido</label><br />
                            <asp:TextBox placeholder="Segundo Apellido" ID="txtSegundoApellido" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="rfvSegundoApellido" runat="server" ControlToValidate="txtSegundoApellido" ErrorMessage="Ingrese su Segundo Apellido"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-sm-4 form-group">
                            <label>Correo</label><br />
                            <asp:TextBox placeholder="Correo"  ID="txtCorreo" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Ingrese su correo"></asp:RequiredFieldValidator>
                            <br />
                        </div>
                        <div class="col-sm-4 form-group">
                            <label>Teléfono 1</label><br />
                            <asp:TextBox placeholder="Teléfono 1"   ID="txtTelefono1" runat="server"></asp:TextBox>
                            &nbsp;
                            <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ControlToValidate="txtTelefono1" ErrorMessage="Ingrese su télefono"></asp:RequiredFieldValidator>
                            <br />
                        </div>
                        <div class="col-sm-4 form-group">
                            <label>Teléfono 2</label><br />
                            <asp:TextBox placeholder="Teléfono 2"  ID="txtTelefono2" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;
                            <br />
                        </div>
                         <div class="col-sm-4 form-group">
                            <label>Fecha de Nacimiento</label><br />
                            <asp:TextBox placeholder="Fecha de Nacimiento" ID="txtFechaNacimiento" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;
                             <asp:RequiredFieldValidator ID="rfvFechaNacimiento" runat="server" ControlToValidate="txtFechaNacimiento" ErrorMessage="Ingrese su fecha de nacimiento"></asp:RequiredFieldValidator>
                            <br />
                        </div>
                          <div class="col-sm-4 form-group">
                            <label>Género</label><br />
                              <asp:DropDownList ID="DropDownListGenero" runat="server">
                                  <asp:ListItem>Femenino</asp:ListItem>
                                  <asp:ListItem>Masculino</asp:ListItem>
                                  <asp:ListItem>Indefinido</asp:ListItem>
                              </asp:DropDownList>
                            &nbsp;
                              <asp:RequiredFieldValidator ID="rfvGenero" runat="server" ControlToValidate="DropDownListGenero" ErrorMessage="Ingrese su género"></asp:RequiredFieldValidator>
                            <br />
                        </div>

                         <div class="col-sm-4 form-group">
                            <label>Tipo Usuario</label><br />
                             <asp:DropDownList ID="DroListTipoUsuario" runat="server" ></asp:DropDownList>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:RequiredFieldValidator ID="rfvTipoUsuario" runat="server" ControlToValidate="DroListTipoUsuario" ErrorMessage="Ingrese un tipo de usuario"></asp:RequiredFieldValidator>
                            <br />
                        </div>
                        
                         <div class="col-sm-4 form-group">
                            <label>Tipo de cobertura</label><br />
                             <asp:DropDownList ID="DropListCobertura" runat="server"></asp:DropDownList>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:RequiredFieldValidator ID="rfvTipoCobertura" runat="server" ControlToValidate="DropListCobertura" ErrorMessage="Ingrese su tipo de Cobertura"></asp:RequiredFieldValidator>
                             <br />
                             <br />
                            <label>Alias de Usuario</label><br />
                            <asp:TextBox placeholder="Fecha de Nacimiento" ID="txtAliasUsuario" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;
                             <asp:RequiredFieldValidator ID="rfvAliasUsuario" runat="server" ControlToValidate="txtAliasUsuario" ErrorMessage="Debe Ingresar un Alias para Usuario"></asp:RequiredFieldValidator>
                             <br />
                             <label>Contraseña</label><br />
                            <asp:TextBox placeholder="Fecha de Nacimiento" ID="txtPassUsuario" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;
                             <asp:RequiredFieldValidator ID="rfvPassUsuario" runat="server" ControlToValidate="txtPassUsuario" ErrorMessage="Debe Ingresar una Contraseña"></asp:RequiredFieldValidator>
                             <br />
                             <label>Dirección</label><br />
                            <asp:TextBox placeholder="Fecha de Nacimiento" ID="txtDireccion" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;
                             <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" ErrorMessage="Debe Ingresar su Dirección"></asp:RequiredFieldValidator>
                             <br />
                             <br />
                             <br />
                            <br />
                        </div>
                    </div>
                    <br />
                    <center>
                    <div class="form-horizontal">
                        <div class="col-md-12">
                            <asp:Button ID="btnInsertar" runat="server" class="btn btn-success  btn-lg" Text="Insertar" OnClick="btnInsertar_Click"  />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <input type="reset" value="Limpiar" class="btn btn-info btn-lg " />
                            
                      
                        </div>
                    </div>
                 </center>
                </div>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
        </div>
    </div>
</div>
    <br/><br/>

</asp:Content>
