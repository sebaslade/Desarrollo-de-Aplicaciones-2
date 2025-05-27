using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente_WEB_Ventas
{
    public partial class WebListarVendedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProxyVendedor.ServicioVendedorClient objServicioVendedor = new ProxyVendedor.ServicioVendedorClient();
            GridView1.DataSource = objServicioVendedor.ListarVendedor();
            GridView1.DataBind();
        }
    }
}