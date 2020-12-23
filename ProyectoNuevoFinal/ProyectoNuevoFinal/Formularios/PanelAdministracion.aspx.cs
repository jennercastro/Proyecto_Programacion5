using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ProyectoNuevoFinal.Formularios
{
    public partial class PanelAdministracion : System.Web.UI.Page
    {
        fiairap1Entities modeloBD = new fiairap1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                bool usuariologueado = Convert.ToBoolean(this.Session["usuariologueado"]);
                if (usuariologueado == true)
                {
                    this.VerificaPermisosMenu();
                }
                else
                {
                    this.Response.Redirect("~/Formularios/frmLogin.aspx");
                }

            }

        }

        protected void btnCoverturas_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("~/Formularios/frmListarCoberturaPoliza.aspx");
        }

        protected void btnAdicciones_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("~/Formularios/frmListarAdicciones.aspx");
        }

        protected void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("~/Formularios/frmListaUsuarios.aspx");
        }

        protected void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("~/Formularios/frmRegistroUsuarioAdmin.aspx");

        }
        protected void btnReporteAdicciones_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("~/Formularios/frmReporteAdiccionesPorCliente.aspx");

        }

        protected void btnReportePolizas_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("~/Formularios/frmReportePolizaPorCliente.aspx");
        }

        void VerificaPermisosMenu()
        {
            int tipoUsuario = Convert.ToInt16(this.Session["tipoUsuario"]);
            /// invocar al procedimiento almacenado
            RetornaCod_Usuario_Result resultadoSp =
                  this.modeloBD.RetornaCod_Usuario(tipoUsuario).FirstOrDefault();
            //verificar si el procedimiento retorna un valor 
            if (resultadoSp == null)
            {
                this.Response.Redirect("~/Formularios/frmInicio.aspx");
            }
            else
            {
                //esta cambiaria por el tipo de usuario para saber si es administrador o cliente 
                if (resultadoSp.Cod_Tipo_Usuario == 1)
                {
                    this.btnAdicciones.Visible = true;
                    this.btnCoverturas.Visible = true;
                    this.btnUsuarios.Visible = true;
                    this.btnRegistroUsuario.Visible = true;

                }
                else
                {
                    this.btnAdicciones.Visible = false;
                    this.btnCoverturas.Visible = false;
                    this.btnUsuarios.Visible = false;
                    this.btnRegistroUsuario.Visible = false;
                }
            }
        }


    }
}