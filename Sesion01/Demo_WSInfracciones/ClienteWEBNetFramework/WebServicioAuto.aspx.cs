using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Agregar referencia
using ClienteWEBNetFramework.ServicioAuto;

namespace ClienteWEBNetFramework
{
    public partial class WebServicioAuto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Creamos la instancia del servicio WS_Auto.asmx
                WS_AutoSoapClient objWSAuto = new WS_AutoSoapClient();

                // Mostramos la multa
                Single sngMulta = objWSAuto.CalcularMulta(txtNumPlaca.Text.Trim());
                lblMulta.Text = sngMulta.ToString("###,###,##0.00");

                // Llenamos el gridView
                grdPapeletas.DataSource = objWSAuto.PapeletasImpagas(txtNumPlaca.Text.Trim()).Tables[0];
                grdPapeletas.DataBind();
                
                // Cantidad de papeletas impagas
                lblPapeletas.Text = grdPapeletas.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                lblPapeletas.Text = "Error: "+ex.Message;
            }
        }
    }
}