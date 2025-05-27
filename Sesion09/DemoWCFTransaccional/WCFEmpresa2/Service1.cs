using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFEmpresa2
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        // se establece la necesidad de requerir el exito del metodo para el exito o no de la transaccion
        [OperationBehavior(TransactionScopeRequired = true)]
        public Int16 SumarSaldo(ClienteEmp2 objClienteEmp2)
        {
            try
            {
                Int16 filasAfectadas = 0;
                Empresa2Entities miEmpresa2 = new Empresa2Entities();
                filasAfectadas = Convert.ToInt16(miEmpresa2.usp_SumarSaldoCliente(objClienteEmp2.Cliente, objClienteEmp2.Monto));
                miEmpresa2.SaveChanges();
                return filasAfectadas;
            }
            catch (EntityException ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }
    }
}
