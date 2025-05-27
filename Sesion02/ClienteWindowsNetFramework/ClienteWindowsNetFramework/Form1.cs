using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregar 
using ClienteWindowsNetFramework.ServiceAuto;

namespace ClienteWindowsNetFramework
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
                //validacion
                if(txtPlaca.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar placa vehicular");
                }

                // Creamos instancia de servicio WS_Auto.asmx
                WS_AutoSoapClient objWSAuto = new WS_AutoSoapClient();

                //obtenemos la multa..
                Single sngMulta = objWSAuto.CalcularMulta(txtPlaca.Text.Trim());
                lblMulta.Text = sngMulta.ToString("###,###,##0.00");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
