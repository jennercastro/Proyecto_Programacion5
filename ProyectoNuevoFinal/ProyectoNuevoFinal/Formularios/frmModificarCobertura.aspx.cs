using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoNuevoFinal.Formularios
{
    public partial class frmModificarCobertura : System.Web.UI.Page
    {
        fiairap1Entities ModeloBD = new fiairap1Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                CargaDatosCoberturas();
            }
        }


        void CargaDatosCoberturas()
        {

            String CodigoCliente = this.Request.QueryString["Id"];

            if (!String.IsNullOrEmpty(CodigoCliente))
            {
                int Id = Convert.ToInt16(CodigoCliente);

                RetornaCobertura_PolizaWhere_Result RegistroCliente =
                    this.ModeloBD.RetornaCobertura_PolizaWhere(Id).FirstOrDefault();

                //Cargar la lista y el dropdwonlist


                //Cargar los valores del registro de clientes
                //En cada uno de los controles.
                this.HiddenUsuario1.Value = RegistroCliente.Id.ToString();
                this.txtId.Text = RegistroCliente.Id.ToString();
                this.txtNombre.Text = RegistroCliente.Nombre.ToString();
                this.txtDescripcion.Text = RegistroCliente.Descripcion.ToString();
                this.txtProcentaje.Text = RegistroCliente.Porcentaje.ToString();

            }

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt16(this.HiddenUsuario1.Value);
            float Porce = (float)System.Convert.ToSingle(this.txtProcentaje.Text.Replace('.', '.'));


            this.ModeloBD.SP_Actualizar_Cobertura_Poliza(Id, this.txtNombre.Text,
                this.txtDescripcion.Text
                , Porce);

            this.lblResultado.Text = " Registro modificado.";
            //redireccionar a la página de ListarUsuarios.
            Response.Redirect("~/Formularios/frmListarCoberturaPoliza.aspx");
        }
    }
}