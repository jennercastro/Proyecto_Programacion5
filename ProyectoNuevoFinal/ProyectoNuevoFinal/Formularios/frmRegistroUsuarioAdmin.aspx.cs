using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace ProyectoNuevoFinal.Formularios
{
    public partial class frmRegistroUsuarioAdmin : System.Web.UI.Page
    {
        fiairap1Entities modeloBD = new fiairap1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //IsPostBack  es para cuando se refresca la página  o se carga la página
            if (!this.IsPostBack)
            {
                CargaTipoUsuario();
                CargaTipoPoliza();
            }

        }
        void CargaTipoUsuario()
        {
            this.DropListTipoUsuario.DataSource = modeloBD.Tipo_Usuario.ToList();
            this.DropListTipoUsuario.DataTextField = "Cod_Tipo_Usuario";
            this.DropListTipoUsuario.DataValueField = "Id";
            this.DropListTipoUsuario.DataBind();

        }
        //Este método sirve para cargar los datos de la tabla Cobertura_Poliza al Dropdown
        void CargaTipoPoliza()
        {
            this.DropListCobertura.DataSource = modeloBD.Cobertura_Poliza.ToList();
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

                    int Id_Tipo_Usuario = Convert.ToInt32(this.DropListTipoUsuario.SelectedValue);
                    int Id_Cobertura_Poliza = Convert.ToInt32(this.DropListCobertura.SelectedValue);
                    String Genero = (this.DropDownListGenero.SelectedValue);
                    int Cedula = Convert.ToInt32(this.txtCedula.Text);
                    int tel1 = Convert.ToInt32(this.txtTelefono1.Text);
                    int tel2 = Convert.ToInt32(this.txtTelefono2.Text);
                    DateTime FechaNaci = Convert.ToDateTime(this.txtFechaNacimiento.Text);
                    string Alias_Usuario = this.txtAliasUsuario.Text;
                    string PassUsuario = this.txtPassUsuario.Text;
                    string Direccion = this.txtDireccion.Text;

                    this.modeloBD.SP_INSERTA_USUARIO(Cedula,
                    this.txtNombre.Text,
                    this.txtPrimerApellido.Text,
                    this.txtSegundoApellido.Text,
                    this.txtCorreo.Text, tel1, tel2,
                    FechaNaci, Genero,
                    Id_Tipo_Usuario,
                    Id_Cobertura_Poliza,
                    Alias_Usuario,
                    PassUsuario,
                    Direccion);
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
                resultado = this.modeloBD.Usuario.Count(m => m.Cedula == valor) <= 0;
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
            Sendemail();
        }
        void Sendemail()
        {
            // Gmail Address from where you send the mail
            var fromAddress = "jenneraa@gmail.com";
            // any address where the email will be sending
            var toAddress = txtCorreo.Text;
            //Password of your gmail address
            const string fromPassword = "Alessand28";
            // Passing the values and make a email formate to display
            string subject = "Su cuenta en Seguros El Equipo del Siglo XXI.";
            string body = "Estimado cliente:" + " " + txtPrimerApellido.Text + " " + txtSegundoApellido.Text + " " + txtNombre.Text + " " + "gracias por confiar en Seguros el Equipo del Siglo XXI. Para nosotros es un placer servirle";
            // smtp settings
            var smtp = new SmtpClient();
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
               

               
            }
            /// Passing values to smtp object
            smtp.Send(fromAddress, toAddress, subject, body);

        }
    }
}