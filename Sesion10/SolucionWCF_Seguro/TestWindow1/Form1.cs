using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregar
using TestWindow1.ProxyPromediar;

namespace TestWindows1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPromediar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                if(txtUsuario.Text.Trim() == String.Empty || txtPassword.Text.Trim() == String.Empty )
                {
                    throw new Exception("El usuario y contraseña son obligatorios");
                }
                if(txtValor1.Text.Trim() == String.Empty||txtValor2.Text.Trim() == String.Empty )
                {
                    throw new Exception("El ingreso de los valores es obligatorio");
                }

                Service1Client miServ1 = new Service1Client();
                miServ1.ClientCredentials.UserName.UserName = txtUsuario.Text.Trim();
                miServ1.ClientCredentials.UserName.Password = txtPassword.Text.Trim();
                // De estar correctas, se invoca a la operación Promediar...
                Single sngPromedio = miServ1.Promediar(Convert.ToSingle(txtValor1.Text.Trim()), Convert.ToSingle(txtValor2.Text.Trim()));
                lbPromedio.Text = sngPromedio.ToString("N2");
            }
            catch(System.ServiceModel.Security.MessageSecurityException ex)
            {
                MessageBox.Show("Error por validacion de credenciales incorrectas");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
