using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ProyectoNuevoFinal.Formularios
{
    public partial class frmLogin : Page
    {
        fiairap1Entities modeloBD = new fiairap1Entities();
        protected void btningresar_Click(object sender, EventArgs e)
        {
            ///validar que todas las validaciones se cumplan
            if (this.Page.IsValid)
            {
                ///variables de sesion es case sensitive
                ///permite compartir datos entre paginas
                ///permite almacenar cualquier objeto

                RetornaUsuario_Result resultadosp =
                    this.modeloBD.RetornaUsuario(
                        this.txtAliasUsuario.Text,
                        this.txtpass.Text).FirstOrDefault();

                if (resultadosp == null)
                {
                    this.lblResultado.Text = "Datos Invalidos debe Registrarse";
                    this.Session.Add("usuariologueado", false);

                }
                else
                {
                    this.Session.Add("aliaUsuario", resultadosp.Alias_Usuario);
                    this.Session.Add("passUsuario", resultadosp.Pass_Usuario);
                    this.Session.Add("tipoUsuario", resultadosp.Cod_Tipo_Usuario);
                    this.Session.Add("usuariologueado", true);
                    //redirecciona a la pagina principal
                    this.Response.Redirect("~/Formularios/PanelAdministracion.aspx");
                }

            }
        }

        protected void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("~/Formularios/frmRegistroUsuario.aspx");
        }
    }
}