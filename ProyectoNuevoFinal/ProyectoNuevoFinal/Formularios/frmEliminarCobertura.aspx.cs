using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ProyectoNuevoFinal.Formularios
{
    public partial class frmEliminarCobertura : System.Web.UI.Page
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

                RetornaCobertura_PolizaWhere_Result RegistroCliente =
                    this.ModeloBD.RetornaCobertura_PolizaWhere(Id).FirstOrDefault();

                //Cargar los valores del registro de clientes
                //En cada uno de los controles.
                this.HiddenUsuario1.Value = RegistroCliente.Id.ToString();
                this.txtId.Text = RegistroCliente.Id.ToString();
                this.txtNombre.Text = RegistroCliente.Nombre.ToString();
                this.txtDescripcion.Text = RegistroCliente.Descripcion.ToString();
                this.txtPorcentaje.Text = RegistroCliente.Porcentaje.ToString();

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            this.PanelAlerta.Visible = true;

            if (this.ValidadRelacionesTablas() == false)
            {

                int Id_Cobertura = Convert.ToInt16(this.HiddenUsuario1.Value);
                this.ModeloBD.SP_ELIMINAR_Cobertura_Poliza(Id_Cobertura);
                //redireccionar a la página de ListarUsuarios.
                Response.Redirect("~/Formularios/frmListarCoberturaPoliza.aspx");
            }
            else
            {
                this.lblResultado.Text = "Nose puede eliminar por relaciones existentes";
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
            Usuario objetoModelo = ModeloBD.Usuario.Where(m => m.Cod_Cobertura_Poliza == Id).FirstOrDefault();
            if (objetoModelo != null)
            {
                return true;
            }

            //validar que devuelva registros
            if (objetoModelo != null)
            {
                return true;
            }
            return resultado;
        }
    }
}