using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Microsoft.Reporting.WebForms;

namespace ProyectoNuevoFinal.Formularios
{
    public partial class frmReporteAdiccionesPorCliente : System.Web.UI.Page
    {
        fiairap1Entities modeloBD = new fiairap1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.cargaDatosRegistro();
            }
        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            this.contruirReporte();
        }

        void cargaDatosRegistro()
        {

            ///Variable que almacena el IDUsuario a la hora de iniciar sesión
            string dataUser = Session["aliaUsuario"].ToString();
            string mensaje = "";

            //validar si el parametro es correcto
            if (String.IsNullOrEmpty(Convert.ToString(dataUser)))
            {
                ///Generar el mensaje
                mensaje = "El parámetro es nulo";
                ///mostrar el mensaje
                Response.Write("<script>alert('" + mensaje + "')</script>");
            }

        }

        void contruirReporte()
        {

            ///indicar la ruta del reporte
            string rutaReporte = "~/Reportes/RptAdiccionesPorCliente.rdlc";
            ///construir la ruta física
            string rutaServidor = Server.MapPath(rutaReporte);
            ///Validar que la ruta física exista
            if (!File.Exists(rutaServidor))
            {
                this.lblResultado.Text =
                    "El reporte seleccionado no existe";
                return;
            }
            else
            {
                rpvClientes.LocalReport.ReportPath = rutaServidor;
                var infoFuenteDatos = this.rpvClientes.LocalReport.GetDataSourceNames();
                ///limpiar los datos de la fuente de datos
                rpvClientes.LocalReport.DataSources.Clear();
                ///obtener los datos del reporte
            var datosReporte = modeloBD.RetornaAdiccionesUsuario(this.txtPriApellido.Text, this.txtNombre.Text).ToList();
                ///crear la fuente de datos
                ReportDataSource fuenteDatos = new ReportDataSource();
                fuenteDatos.Name = infoFuenteDatos[0];
                fuenteDatos.Value = datosReporte;
                // agregar la fuente de datos al reporte
                this.rpvClientes.LocalReport.DataSources.Add(fuenteDatos);

                /// mostrar los datos en el reporte
                this.rpvClientes.LocalReport.Refresh();
            }
        }
    }
}
