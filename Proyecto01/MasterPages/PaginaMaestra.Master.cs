using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto01.Modelo;
using Proyecto01.Formularios;
using Proyecto01.Clases;

namespace Proyecto01.MasterPages
{
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {
       ProyectoProgra5Entities1 modeloBD = new ProyectoProgra5Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                bool usuariologueado = Convert.ToBoolean(this.Session["usuariologueado"]);
                if (usuariologueado == true)
                {
                    this.btnSesion.Visible = false;
                    string Datos = DateTime.Now.ToString();

                }
                else
                {
                    this.btnCerrarSesion.Visible = false;
                }

            }


        }

        protected void btnSesion_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("~/Formularios/frmLogin.aspx");

        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("~/Formularios/frmCerrarSesion.aspx");

        }
    }
}