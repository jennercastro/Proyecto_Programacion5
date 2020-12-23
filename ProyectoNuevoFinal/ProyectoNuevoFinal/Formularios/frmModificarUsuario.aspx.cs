using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoNuevoFinal.Formularios
{
    public partial class frmModificarUsuario : System.Web.UI.Page
    {
        fiairap1Entities ModeloBD = new fiairap1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                CargaDatosClientes();
            }
        }



        void CargaDatosClientes()
        {

            String CodigoCliente = this.Request.QueryString["Id"];

            if (!String.IsNullOrEmpty(CodigoCliente))
            {
                int Id = Convert.ToInt16(CodigoCliente);

                listarUsuariosWhere5_Result RegistroCliente =
                    this.ModeloBD.listarUsuariosWhere5(Id).FirstOrDefault();

                //Cargar la lista y el dropdwonlist


                //Cargar los valores del registro de clientes
                //En cada uno de los controles.
                this.HiddenUsuario.Value = RegistroCliente.Id.ToString();
                this.txtCedula.Text = RegistroCliente.Cedula.ToString();
                this.txtNombre.Text = RegistroCliente.Nombre.ToString();
                this.txtPrimerApellido.Text = RegistroCliente.Apellido1.ToString();
                this.txtSegundoApellido.Text = RegistroCliente.Apellido2.ToString();
                this.txtCorreo.Text = RegistroCliente.Correo;
                this.txtTelefono1.Text = RegistroCliente.Telefono1.ToString();
                this.txtTelefono2.Text = RegistroCliente.Telefono2.ToString();
                this.txtFechaNacimiento.Text = RegistroCliente.Fecha_Nacimiento.ToString();
                this.txtGenero.Text = RegistroCliente.Genero.ToString();
                this.DroListTipoUsuario.SelectedValue = RegistroCliente.Cod_Tipo_Usuario.ToString();
                this.DropListCobertura.SelectedValue = RegistroCliente.Cobertura.ToString();
                //this.ddlTipoCliente.SelectedValue = RegistroCliente.id_TipoCliente.toString();*/


            }

        }

        //Este método sirve para cargar los datos de la tabla tipo_Usuario al Dropdown




        protected void btnModificar_Click(object sender, EventArgs e)
        {
            //Validar que todos los datos se encuentren correctos.

            int Id = Convert.ToInt16(this.HiddenUsuario.Value);


            int Id_Tipo_Usuario = Convert.ToInt32(this.DroListTipoUsuario.SelectedValue);
            int Id_Cobertura_Poliza = Convert.ToInt32(this.DropListCobertura.SelectedValue);
            int Cedula = Convert.ToInt32(this.txtCedula.Text);
            int tel1 = Convert.ToInt32(this.txtTelefono1.Text);
            int tel2 = Convert.ToInt32(this.txtTelefono2.Text);
            DateTime FechaNaci = Convert.ToDateTime(this.txtFechaNacimiento.Text);
            string Alias_Usuario = this.txtAliasUsuario.Text;
            string PassUsuario = this.txtPassUsuario.Text;
            string Direccion = this.txtDireccion.Text;

            this.ModeloBD.SP_Actualizar_USUARIO(Id, Cedula, this.txtNombre.Text, this.txtPrimerApellido.Text,
                txtSegundoApellido.Text, txtCorreo.Text, tel1, tel2, FechaNaci,
                txtGenero.Text, Id_Tipo_Usuario, Id_Cobertura_Poliza, Alias_Usuario, PassUsuario, Direccion);

            this.lblResultado.Text = " Registro modificado.";
            //redireccionar a la página de ListarUsuarios.
            Response.Redirect("~/Formularios/frmListaUsuarios.aspx");
        }
    }
}