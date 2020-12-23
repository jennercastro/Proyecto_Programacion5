<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaMaestra.Master" AutoEventWireup="true" 
    CodeBehind="frmModificarUsuario.aspx.cs" Inherits="ProyectoNuevoFinal.Formularios.frmModificarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     
    <div class="container">
     <h1>Mantenimiento de Clientes - Modificar</h1>
<div class="col-lg-12 well">
      
        <div class="row">
          
                <div class="col-sm-12">

                    <div class="row">
                        <div class="col-sm-6 form-group">
                            <label>Cédula</label><br/>
                            <asp:TextBox placeholder="Cédula" ID="txtCedula"  runat="server"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="rfvCedula" runat="server" ControlToValidate="txtCedula" ErrorMessage="Ingrese su cédula"></asp:RequiredFieldValidator>
                         </div>
                        <div class="col-sm-6 form-group">
                            <label>Nombre</label><br />
                            <asp:TextBox placeholder="Nombre" ID="txtNombre" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Ingrese su nombre"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-sm-6 form-group">
                            <label>Primer Apellido</label><br />
                            <asp:TextBox placeholder="Primer Apellido"  ID="txtPrimerApellido" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="rfvPrimerApellido" runat="server" ControlToValidate="txtPrimerApellido" ErrorMessage="Ingrese su primer apellido"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-sm-6 form-group">
                            <label>Segundo Apellido</label><br />
                            <asp:TextBox placeholder="Segundo Apellido" ID="txtSegundoApellido" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="rfvSegundoApellido" runat="server" ControlToValidate="txtSegundoApellido" ErrorMessage="Ingrese su Segundo Apellido"></asp:RequiredFieldValidator>
                            <br />
                        </div>
                        <div class="col-sm-6 form-group">
                            <label>Correo</label><br />
                            <asp:TextBox placeholder="Correo"  ID="txtCorreo" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Ingrese su correo"></asp:RequiredFieldValidator>
                            <br />
                        </div>
                        <div class="col-sm-6 form-group">
                            <label>Teléfono 1</label><br />
                            <asp:TextBox placeholder="Teléfono 1"   ID="txtTelefono1" runat="server"></asp:TextBox>
                            &nbsp;
                            <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ControlToValidate="txtTelefono1" ErrorMessage="Ingrese su télefono"></asp:RequiredFieldValidator>
                            <br />
                        </div>
                        <div class="col-sm-6 form-group">
                            <label>Teléfono 2</label><br />
                            <asp:TextBox placeholder="Teléfono 2"  ID="txtTelefono2" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;
                            <br />
                            <label>Alias de Usuario</label><br />
                             <asp:TextBox ID="txtAliasUsuario" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;
                             <asp:RequiredFieldValidator ID="rfvAliasUsuario" runat="server" ControlToValidate="txtAliasUsuario" ErrorMessage="Debe Ingresar un Alias para Usuario"></asp:RequiredFieldValidator>
                             &nbsp;
                             <label>
                            <br />
                            Contraseña&nbsp;&nbsp;&nbsp; 
                            &nbsp;&nbsp;<br />
                            </label>
                            <br />
                            <asp:TextBox ID="txtPassUsuario" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="rfvPassUsuario" runat="server" ControlToValidate="txtPassUsuario" ErrorMessage="Debe Ingresar una Contraseña"></asp:RequiredFieldValidator>
                             <br />
                             <br />
                             <label>Dirección</label><br />
                             <asp:TextBox ID="txtDireccion" runat="server" Width="502px"></asp:TextBox>
                            &nbsp;&nbsp;
                             <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" ErrorMessage="Debe Ingresar su Dirección"></asp:RequiredFieldValidator>
                            <br />
                        </div>
                         <div class="col-sm-6 form-group">
                            <label>Fecha de Nacimiento</label><br />
                            <asp:TextBox placeholder="Fecha de Nacimiento" ID="txtFechaNacimiento" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;
                             <asp:RequiredFieldValidator ID="rfvFechaNacimiento" runat="server" ControlToValidate="txtFechaNacimiento" ErrorMessage="Ingrese su fecha de nacimiento"></asp:RequiredFieldValidator>
                            <br />
                        </div>
                          <div class="col-sm-6 form-group">
                            <label>Género</label><br />
                            <asp:TextBox placeholder="Género" ID="txtGenero" runat="server"></asp:TextBox>
                            &nbsp;
                              <asp:RequiredFieldValidator ID="rfvGenero" runat="server" ControlToValidate="txtGenero" ErrorMessage="Ingrese su género"></asp:RequiredFieldValidator>
                            <br />
                        </div>

                         <div class="col-sm-6 form-group">
                            <label>Tipo Usuario</label><br />
                             <asp:DropDownList ID="DroListTipoUsuario" runat="server" ></asp:DropDownList>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:RequiredFieldValidator ID="rfvTipoUsuario" runat="server" ControlToValidate="DroListTipoUsuario" ErrorMessage="Ingrese un tipo de usuario"></asp:RequiredFieldValidator>
                            <br />
                        </div>
                        
                         <div class="col-sm-6 form-group">
                            <label>Tipo de cobertura</label><br />
                             <asp:DropDownList ID="DropListCobertura" runat="server"></asp:DropDownList>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:RequiredFieldValidator ID="rfvTipoCobertura" runat="server" ControlToValidate="DropListCobertura" ErrorMessage="Ingrese su tipo de Cobertura"></asp:RequiredFieldValidator>
                             <br />
                             <br />
                            <br />
                        </div>
                    </div>
                    <div class="form-horizontal">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button ID="btnModificar" runat="server" class="btn btn-success  btn-lg" Text="Modificar" OnClick="btnModificar_Click"   />
                            &nbsp;<asp:Label ID="lblResultado" runat="server"></asp:Label>
                      
                        </div>
                    </div>
                 
                </div>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:HiddenField ID="HiddenUsuario" runat="server" />
        </div>
    </div>
</div>

</asp:Content>
