using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ProyectoNuevoFinal.Formularios
{
    public partial class frmListarAdicciones : System.Web.UI.Page
    {
        fiairap1Entities ModeloBD = new fiairap1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                CargarDatosGrid();
            }
        }


        void CargarDatosGrid()
        {
            List<RetornaAdicciones_Result> Sp_Resultado = ModeloBD.RetornaAdicciones().ToList();
            this.GridViewAdicciones.DataSource = Sp_Resultado;
            this.GridViewAdicciones.DataBind();
        }
    }
}