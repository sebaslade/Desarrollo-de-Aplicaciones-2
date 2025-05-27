namespace TestWindows_WCF_Ventas
{
    public partial class frmFacturacionCliente : Form
    {
        // Instancias del servicio...
        ProxyCliente.ServicioClienteClient objServicioCliente = new ProxyCliente.ServicioClienteClient();
        ProxyFactura.ServicioFacturaClient objServicioFactura = new ProxyFactura.ServicioFacturaClient();

        ProxyCliente.ClienteDC objClienteDC = new ProxyCliente.ClienteDC();
        ProxyFactura.FacturaDC objFacturaDC = new ProxyFactura.FacturaDC();
        public frmFacturacionCliente()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                if (txtCod.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar un codigo valido");
                }
                if (dtpFecIni.Value.Date > dtpFecFin.Value.Date)
                {
                    throw new Exception("La fecha de inicio no puede ser mayor que la de fin");
                }

                //Pasando las validaciones
                objClienteDC = objServicioCliente.ConsultarCliente(txtCod.Text.Trim());
                if (objClienteDC.Cod_cli == String.Empty)
                {
                    throw new Exception("El cliente no existe");
                }
                lblRS.Text = objClienteDC.Raz_soc_cli;
                lblRUC.Text = objClienteDC.Ruc_cli;
                //Faltan mostrar mas datos...

                //Llenamos el grid
                dtgFacturas.DataSource = objServicioFactura.ListarFacturasClienteFechas(txtCod.Text.Trim(), dtpFecIni.Value.Date, dtpFecFin.Value.Date);
                lblRegistros.Text = dtgFacturas.RowCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgFacturas.AutoGenerateColumns = false;
        }
    }
}