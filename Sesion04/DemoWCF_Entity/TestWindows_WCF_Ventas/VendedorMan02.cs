using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestWindows_WCF_Ventas
{
    public partial class VendedorMan02 : Form
    {
        ProxyVendedor.ServicioVendedorClient objServiceVendedor = 
                                     new ProxyVendedor.ServicioVendedorClient();
        ProxyVendedor.VendedorDC objVendedorDC = new ProxyVendedor.VendedorDC();

        public VendedorMan02()
        {
            InitializeComponent();
        }

        private void VendedorMan02_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                cboSupervisor.DataSource = objServiceVendedor.ListarSupervisores();
                cboSupervisor.ValueMember = "Cod_ven";
                cboSupervisor.DisplayMember = "Ape_ven";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }
      private void btnGrabar_Click(object sender, EventArgs e)
        {
           try
            {
                // Validamos que el nombre, apellido , DNI  y sueldo no esten vacios
                if (txtnom.Text.Length == 0)
                {
                    throw new Exception ("El Nombre no puede estar vacio.");
                }

                if (txtape.Text.Length == 0)
                {
                    throw new Exception ("El Apellido no puede estar vacio.");
                }

                if (mskSueldo.Text == "")
                {
                    throw new Exception ("Debe ingresar un sueldo valido.");

                }

                if (mskDNI.MaskFull  == false)
                {
                    throw new Exception("El DNI debe tener 8 caracteres.");

                }

                // Codifique
                objVendedorDC.Nom_ven = txtnom.Text;
                objVendedorDC.Ape_ven = txtape.Text;
                objVendedorDC.Sue_ven = Convert.ToDecimal(mskSueldo.Text);
                objVendedorDC.Fec_ing = dtpFecIng.Value.Date;
                objVendedorDC.DNI_ven = mskDNI.Text;

                if (optSupervisor.Checked == true)
                {
                    objVendedorDC.Tip_ven = 1;
                }
                else if (optSupervisor.Checked == true)
                {
                    objVendedorDC.Tip_ven = 2;
                }
                else
                {
                    throw new Exception ("Debe seleccionar un tipo");
                }
                objVendedorDC.Email_ven = txtnom.Text;
                objVendedorDC.Cod_Supervisor = cboSupervisor.SelectedValue.ToString();
                objVendedorDC.Usu_Registro = "jleon";
                objVendedorDC.Est_ven = Convert.ToInt16(chkActivo.Checked);

                if(objServiceVendedor.InsertarVendedor(objVendedorDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("Error, no se ejecuto la accion. Contacte con IT");
                }
           }
           catch ( Exception ex)
            {
           MessageBox .Show ("Se ha producido el error: " + ex.Message );
           }

         }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
