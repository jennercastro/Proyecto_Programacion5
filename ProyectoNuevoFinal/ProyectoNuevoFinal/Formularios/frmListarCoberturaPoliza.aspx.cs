using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ProyectoNuevoFinal.Formularios
{
    public partial class frmListarCoberturaPoliza : System.Web.UI.Page
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
            List<RetornaCobertura_Poliza_Result> Sp_Resultado = ModeloBD.RetornaCobertura_Poliza().ToList();
            this.GridViewCobertura.DataSource = Sp_Resultado;
            this.GridViewCobertura.DataBind();
        }
    }
}