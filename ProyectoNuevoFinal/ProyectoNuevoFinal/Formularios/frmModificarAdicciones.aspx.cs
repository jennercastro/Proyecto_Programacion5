using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoNuevoFinal.Formularios
{
    public partial class frmModificarAdicciones : System.Web.UI.Page
    {
        fiairap1Entities ModeloBD = new fiairap1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                CargaDatosAdicciones();
            }
        }


        void CargaDatosAdicciones()
        {

            String CodigoCliente = this.Request.QueryString["Id"];

            if (!String.IsNullOrEmpty(CodigoCliente))
            {
                int Id = Convert.ToInt16(CodigoCliente);

                RetonarAdiccionID_Result RegistroCliente =
                    this.ModeloBD.RetonarAdiccionID(Id).FirstOrDefault();

                //Cargar la lista y el dropdwonlist


                //Cargar los valores del registro de clientes
                //En cada uno de los controles.
                this.HiddenUsuario1.Value = RegistroCliente.Id.ToString();
                this.txtId.Text = RegistroCliente.Id.ToString();
                this.txtNombreAdiccion.Text = RegistroCliente.Nombre.ToString();


            }

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

            int Id = Convert.ToInt16(this.HiddenUsuario1.Value);


            this.ModeloBD.SP_Actualizar_ADICCION(Id, this.txtNombreAdiccion.Text);

            this.lblResultado.Text = " Registro modificado.";
            //redireccionar a la página de ListarUsuarios.
            Response.Redirect("~/Formularios/frmListarCoberturaPoliza.aspx");
        }
    }
}