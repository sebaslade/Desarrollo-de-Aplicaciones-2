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
    public partial class VendedorMan03 : Form
    {
        ProxyVendedor.ServicioVendedorClient objServiceVendedor= new ProxyVendedor.ServicioVendedorClient();
        ProxyVendedor.VendedorDC objVendedorDC = new ProxyVendedor.VendedorDC();

        public VendedorMan03()
        {
            InitializeComponent();
        }
        // Propiedad para identificar el codigo  del vendedor a actualizar
        //private String _Codigo;

        public String Codigo
        {
            get ; set ; 

        }

        private void VendedorMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargamos el cboSupervisores...
                // Codifique....
                cboSupervisor.DataSource = objServiceVendedor.ListarSupervisores();
                cboSupervisor.ValueMember = "Cod_ven";
                cboSupervisor.DisplayMember = "Ape_ven";

                // Mostramos los datos del vendedor que se va actualizar...
                objVendedorDC = objServiceVendedor.ConsultarVendedor(Codigo);
                // Muestre la informacion del vendedor consultado....
                lblCodigo.Text = objVendedorDC.Cod_ven;
                txtnom.Text = objVendedorDC.Nom_ven;
                txtape.Text = objVendedorDC.Ape_ven;
                mskSueldo.Text = objVendedorDC.Sue_ven.ToString();
                txtEmail.Text = objVendedorDC.Email_ven;
                mskDNI.Text = objVendedorDC.DNI_ven;
                dtpFecIng.Value = objVendedorDC.Fec_ing;
                if(objVendedorDC.Tip_ven == 1)
                {
                    optSupervisor.Checked = true;
                }
                else
                {
                    optSupervisor.Checked = false;
                }
                cboSupervisor.SelectedValue = objVendedorDC.Cod_Supervisor;
                chkActivo.Checked = Convert.ToBoolean(objVendedorDC.Est_ven);
                
	            // Mostramos la cantidad de vendedores supervisados por el vendedor...
                // lblNumSupervisados.Text = ...termine la linea...


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
           try
	{

            // Agregar validaciones para nombres, apellidos, DNI y sueldo 
            if (txtnom.Text.Length == 0)
            {
                MessageBox.Show ("El Nombre no puede estar vacio.");
            }

            if (txtape.Text.Length == 0)
            {
                MessageBox.Show("El Apellido no puede estar vacio.");
            }

            if (mskSueldo.Text=="")
            {
                MessageBox.Show("Debe ingresar un sueldo valido.");
               
            }

            if (mskDNI.MaskFull == false)
            {
                throw new Exception("El DNI debe tener 8 caracteres.");
            }

                // Codifique...
                objVendedorDC.Cod_ven = lblCodigo.Text;
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
                    throw new Exception("Debe seleccionar un tipo");
                }
                objVendedorDC.Email_ven = txtnom.Text;
                objVendedorDC.Cod_Supervisor = cboSupervisor.SelectedValue.ToString();
                objVendedorDC.Usu_Ult_Mod = "cmontoya";
                objVendedorDC.Est_ven = Convert.ToInt16(chkActivo.Checked);

                //invocamos a la opetacion actualizar
                if (objServiceVendedor.ActualizarVendedor(objVendedorDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("Error, no se ejecuto la accion. Contacte con IT");
                }
            }
     
	 catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
