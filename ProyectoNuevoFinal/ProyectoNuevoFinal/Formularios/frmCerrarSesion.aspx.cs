using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoNuevoFinal.Formularios
{
    public partial class frmCerrarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSi_Click(object sender, EventArgs e)
        {
            ///nombre de la    variable y      despues el valor de la variable
            this.Session.Add("aliasUsuario", null);
            this.Session.Add("passUsuario", null);
            this.Session.Add("usuariologueado", null);
            //redireccionar a login.aspx
            this.Response.Redirect("~/Formularios/frmInicio.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("~/Formularios/PanelAdministracion.aspx");
        }
    }
}