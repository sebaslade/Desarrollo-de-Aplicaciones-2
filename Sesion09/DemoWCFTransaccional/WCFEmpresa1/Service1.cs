using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFEmpresa1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        // se establece la necesidad de requerir el exito del metodo para el exito o no de la transaccion
        [OperationBehavior(TransactionScopeRequired = true)]
        public Int16 RestarSaldo(ClienteEmp1 objClienteEmp1)
        {
            try
            {
                Int16 filasAfectadas = 0;
                Empresa1Entities miEmpresa1 = new Empresa1Entities();
                
                filasAfectadas = Convert.ToInt16(miEmpresa1.usp_RestarSaldoCliente(objClienteEmp1.Cliente, objClienteEmp1.Monto));
                miEmpresa1.SaveChanges();
                return filasAfectadas;
            }
            catch (EntityException ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }
    }
}
