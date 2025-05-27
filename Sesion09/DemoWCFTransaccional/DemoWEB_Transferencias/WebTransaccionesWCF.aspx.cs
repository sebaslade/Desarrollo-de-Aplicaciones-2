using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Agregar el using (previamente la referencia al System.Transactions)
using System.Transactions;
using DemoWEB_Transferencias.ProxyEmpresa1;
using DemoWEB_Transferencias.ProxyEmpresa2;
namespace DemoWEB_Transferencias
{
    public partial class WebTransaccionesWCF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTransferir_Click(object sender, EventArgs e)
        {
            // Codifique
            try
            {
                String codigo1 = txtCodCliente1.Text.Trim();
                String codigo2 = txtCodCliente2.Text.Trim();

                ProxyEmpresa1.ClienteEmp1 cliente1 = new ProxyEmpresa1.ClienteEmp1();
                ProxyEmpresa2.ClienteEmp2 cliente2 = new ProxyEmpresa2.ClienteEmp2();

                cliente1.Cliente = codigo1;
                cliente1.Monto = Convert.ToDecimal(txtMonto.Text.Trim());

                cliente2.Cliente = codigo2;
                cliente2.Monto = Convert.ToDecimal(txtMonto.Text.Trim());

                using(TransactionScope tx = new TransactionScope())
                {
                    ProxyEmpresa1.Service1Client servicioEmpresa1 = new ProxyEmpresa1.Service1Client();
                    ProxyEmpresa2.Service1Client servicioEmpresa2 = new ProxyEmpresa2.Service1Client();

                    Int16 filas1 = servicioEmpresa1.RestarSaldo(cliente1);
                    Int16 filas2 = servicioEmpresa2.SumarSaldo(cliente2);

                    //Simulamos una demora de 5 segundos
                    System.Threading.Thread.Sleep(5000);

                    //si las variables filas1 o filas2 son = 0, quiere decir que no se hicieron las actualizaciones
                    //por lo que la transaccion se cancela, de lo contrario la transaccion se confirmara.
                    if(filas1 <= 0 || filas2 <= 0)
                    {
                        //Cancelamos la transaccion
                        tx.Dispose();
                        throw new Exception("Codigo de cliente no existe o saldo insuficiente");
                    }
                    else
                    {
                        //se confirma
                        tx.Dispose();
                        lblMensajePopup.Text = "Transeferencia realizada satisfactoriamente";
                        PopMensaje.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
    }
}