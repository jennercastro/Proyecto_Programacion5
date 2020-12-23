using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ProyectoNuevoFinal.Formularios
{
    public partial class frmEliminarUsuario : System.Web.UI.Page
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
                this.txtTipo_Usuario.Text = RegistroCliente.Cod_Tipo_Usuario.ToString();
                this.txtTipoCobertura.Text = RegistroCliente.Cobertura.ToString();
                //this.ddlTipoCliente.SelectedValue = RegistroCliente.id_TipoCliente.toString();*/


            }

        }


        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            this.PanelAlerta.Visible = true;
            if (this.ValidadRelacionesTablas() == false)
            {
                int Id_Usuario = Convert.ToInt16(this.HiddenUsuario.Value);

                this.ModeloBD.SP_ELIMINAR_ADICCION(Id_Usuario);
                this.lblResultado.Text = "Los datos fueron eliminados.";
                //redireccionar a la página de ListarUsuarios.
                Response.Redirect("~/Formularios/frmListaUsuarios.aspx");
            }
            else
            {
                this.lblResultado.Text = "No se puede eliminar por relaciones existentes";
            }
        }

        public Boolean ValidadRelacionesTablas()
        {
            //FirstOrDefault ---> el primero o el valor por defecto que seria un nullo
            bool resultado = false;
            //obtener el id enviado
            String CodigoCliente = this.Request.QueryString["Id"];
            int Id = Convert.ToInt16(CodigoCliente);
            //tabla contra la tabla Modelos
            Adiccion_Usuario objetoModelo = ModeloBD.Adiccion_Usuario.Where(m => m.Cod_Usuario == Id).FirstOrDefault();
            if (objetoModelo != null)
            {
                return true;
            }

            if (objetoModelo != null)
            {
                return true;
            }


            return resultado;

        }
    }
}