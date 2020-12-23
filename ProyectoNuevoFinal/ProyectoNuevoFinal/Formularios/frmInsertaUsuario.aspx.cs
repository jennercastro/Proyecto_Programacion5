using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace ProyectoNuevoFinal.Formularios
{

    public partial class frmInsertaUsuario : System.Web.UI.Page
    {
        //Instancias de la base de datos.

        fiairap1Entities ModeloBD = new fiairap1Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            //IsPostBack  es para cuando se refresca la página  o se carga la página
            if (!this.IsPostBack)
            {

                CargaTipoUsuario();

                CargaTipoPoliza();
            }
        }

        //Este método sirve para cargar los datos de la tabla tipo_Usuario al Dropdown

        void CargaTipoUsuario()
        {
            this.DroListTipoUsuario.DataSource = ModeloBD.Tipo_Usuario.ToList();
            this.DroListTipoUsuario.DataTextField = "Cod_Tipo_Usuario";
            this.DroListTipoUsuario.DataValueField = "Id";
            this.DroListTipoUsuario.DataBind();

        }

        //Este método sirve para cargar los datos de la tabla Cobertura_Poliza al Dropdown
        void CargaTipoPoliza()
        {
            this.DropListCobertura.DataSource = ModeloBD.Cobertura_Poliza.ToList();
            this.DropListCobertura.DataTextField = "Nombre";
            this.DropListCobertura.DataValueField = "Id";
            this.DropListCobertura.DataBind();
        }


        //Método que sirve para agregar a los usuarios.
        void AgregarUsuario()
        {
            this.PanelAlerta.Visible = true;
            //Válida que la  cédula no este repetida.
            if (this.ValidaExistenciaCedula())
            {

                try
                {

                    int Id_Tipo_Usuario = Convert.ToInt32(this.DroListTipoUsuario.SelectedValue);
                    int Id_Cobertura_Poliza = Convert.ToInt32(this.DropListCobertura.SelectedValue);
                    String Genero = (this.DropDownListGenero.SelectedValue);
                    int Cedula = Convert.ToInt32(this.txtCedula.Text);
                    int tel1 = Convert.ToInt32(this.txtTelefono1.Text);
                    int tel2 = Convert.ToInt32(this.txtTelefono2.Text);
                    DateTime FechaNaci = Convert.ToDateTime(this.txtFechaNacimiento.Text);
                    string Alias_Usuario = this.txtAliasUsuario.Text;
                    string PassUsuario = this.txtPassUsuario.Text;
                    string Direccion = this.txtDireccion.Text;

                    this.ModeloBD.SP_INSERTA_USUARIO(Cedula, this.txtNombre.Text, this.txtPrimerApellido.Text,
                        this.txtSegundoApellido.Text, this.txtCorreo.Text, tel1, tel2,
                       FechaNaci, Genero, Id_Tipo_Usuario, Id_Cobertura_Poliza, Alias_Usuario, PassUsuario, Direccion);
                    Response.Redirect("~/Formularios/frmListaUsuarios.aspx");
                    this.lblResultado.Text = "Registro Agregado correctamente.";

                }

                catch (Exception)
                {
                    this.lblResultado.Text = "Alerta! Error en la inserción";
                }
            }
            else
            {
                this.lblResultado.Text = "Alerta! Ya existe un usuario con la misma cedula registrado";

            }

        }


        //Esta función evita la duplicidad de Cédula de los usuarios insertados.

        public bool ValidaExistenciaCedula()
        {
            bool resultado = true;
            try
            {
                int valor = Convert.ToInt32(this.txtCedula.Text);
                resultado = this.ModeloBD.Usuario.Count(m => m.Cedula == valor) <= 0;
            }
            catch
            {
                this.lblResultado.Text = "Alerta! Error en la validación de la cedula";
            }

            return resultado;

        }


        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            AgregarUsuario();
        }
    }
}