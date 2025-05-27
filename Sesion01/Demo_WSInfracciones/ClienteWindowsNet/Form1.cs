// agregar referencia
using ServicioAuto;

namespace ClienteWindowsNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validamos el ingreso de placa
                if(txtNumPlaca.Text.Trim() == String.Empty ) 
                {
                    throw new Exception("Debe ingresar un número de placa válido");
                }

                // Creamos la instancia del servicio WS_Auto.asmx
                WS_AutoSoapClient objWsAuto= new WS_AutoSoapClient(WS_AutoSoapClient.EndpointConfiguration.WS_AutoSoap);

                // obtenemos el propietario y multa
                lblPropietario.Text = objWsAuto.AutoPropietario(txtNumPlaca.Text.Trim());
                Single sngMulta = objWsAuto.CalcularMulta(txtNumPlaca.Text.Trim());
                lblMulta.Text = sngMulta.ToString("###,###,##0.00");
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error: "+ex.Message,"Error");
            }

        }
    }
}
