using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace TestWindows_WCF_Ventas
{
    public partial class VendedorMan01 : Form
    {

        ProxyVendedor.ServicioVendedorClient objServiceVendedor= new ProxyVendedor.ServicioVendedorClient();
              
        public VendedorMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            //Codifique
            dtgVendedor.DataSource = objServiceVendedor.ListarVendedor();
            lblRegistros.Text = dtgVendedor.Rows.Count.ToString();
        }

        private void VendedorMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgVendedor.AutoGenerateColumns = false;
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

      
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                VendedorMan02 objVend02 = new VendedorMan02();
                objVend02.ShowDialog();

                // Refrescamos...
                CargarDatos();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "  + ex.Message );
            }
        }

      

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                VendedorMan03 objVend03 = new VendedorMan03();

                // Obtenemos el codigo del vendedor seleccionado en el dtgVendedor
                String strCodigo = dtgVendedor.CurrentRow.Cells[0].Value.ToString();
                objVend03.Codigo = strCodigo;
                objVend03.ShowDialog();

                // Refrescamos...
                CargarDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "  + ex.Message );
            }
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
