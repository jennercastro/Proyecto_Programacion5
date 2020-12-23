using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoNuevoFinal.Formularios
{
    public partial class frmListaUsuarios : System.Web.UI.Page
    {
        fiairap1Entities ModeloBD = new fiairap1Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            //IsPostBack  es para cuando se refresca la página  o se carga la página
            if (!this.IsPostBack)
            {
                //Carga los datos al grid
                CargarDatosGrid();

            }


        }
        //Sirve para  traer los Datos de el procedimiento almacenado ListarUsuario(Tabla Usuario)
        void CargarDatosGrid()
        {
            List<listarUsuarios5_Result> Sp_Resultado = ModeloBD.listarUsuarios5().ToList();
            this.MiGridView.DataSource = Sp_Resultado;
            this.MiGridView.DataBind();
        }
    }
}