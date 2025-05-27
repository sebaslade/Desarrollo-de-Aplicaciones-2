using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTestWCF_Infracciones
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //Declaramos el la instancia de Servicio WCF
        ProxyInfracciones.Service1Client objServicio = new ProxyInfracciones.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validacion
                if (txtAño.Text.Trim() == String.Empty || txtPlaca.Text.Trim() == String.Empty)
                {
                    throw new Exception("El año y la placa son necesarios");
                }

                grvDatos.DataSource = objServicio.EstadisticaMultas_AutoMensual(txtPlaca.Text, Convert.ToInt16(txtAño.Text)).Tables[0];
                grvDatos.DataBind();

                if (grvDatos.Rows.Count == 0)
                {
                    throw new Exception("El vehiculo o el año ingresado no presenta infracciones");
                }
            }
            catch(Exception ex) 
            {
                lblMensaje.Text = "Error" + ex.Message;
            }
        }
    }
}