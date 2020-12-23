using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ProyectoNuevoFinal.Formularios
{
    public partial class frmEliminarAdicciones : System.Web.UI.Page
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




                //Cargar los valores del registro de clientes
                //En cada uno de los controles.
                this.HiddenUsuario1.Value = RegistroCliente.Id.ToString();
                this.txtId.Text = RegistroCliente.Id.ToString();
                this.txtNombreAdiccion.Text = RegistroCliente.Nombre.ToString();



            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            this.PanelAlerta.Visible = true;
            if (this.ValidadRelacionesTablas() == false)
            {
                int Id_Adiccion = Convert.ToInt16(this.HiddenUsuario1.Value);
                this.ModeloBD.SP_ELIMINAR_ADICCION(Id_Adiccion);
                //redireccionar a la página de ListarUsuarios.
                Response.Redirect("~/Formularios/frmListarAdicciones.aspx");
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
            Adiccion_Usuario objetoModelo = ModeloBD.Adiccion_Usuario.Where(m => m.Cod_Adiccion == Id).FirstOrDefault();
            if (objetoModelo != null)
            {
                return true;
            }

            //RegistroVehiculo ObjRegistroVehiculo = miModeloDB.RegistroVehiculo.Where(m => m.Fk_idMarca == id_Marcas).FirstOrDefault();
            //validar que devuelva registros
            if (objetoModelo != null)
            {
                return true;
            }


            return resultado;

        }
    }
}