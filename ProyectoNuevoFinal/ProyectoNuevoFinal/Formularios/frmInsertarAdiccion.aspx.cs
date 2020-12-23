using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ProyectoNuevoFinal.Formularios
{
    public partial class frmInsertarAdiccion : System.Web.UI.Page
    {
        //Instancias de la base de datos.

        fiairap1Entities ModeloBD = new fiairap1Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

            }

        }




        //Método que sirve para agregar las adicciones.
        void AgregarAdiccion()
        {

            if (this.ValidaExistenciaAdiccion())
            {

                try
                {

                    this.ModeloBD.SP_INSERTA_ADICCION(this.txtNombreAdiccion.Text);

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

        //Esta función evita la duplicidad de las adicciónes  insertadas.

        public bool ValidaExistenciaAdiccion()
        {
            bool resultado = true;
            try
            {
                String valor = this.txtNombreAdiccion.Text;
                resultado = this.ModeloBD.Adiccion.Count(m => m.Nombre == valor) <= 0;
            }
            catch
            {
                this.lblResultado.Text = "Alerta! la adicción insertada ya se encuentra registrada";
            }

            return resultado;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            AgregarAdiccion();
        }
    }
}
