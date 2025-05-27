using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFEmpresa1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        // Se define que la operacion permita ser considerada una operacion con flujo transaccional
        [TransactionFlow(TransactionFlowOption.Allowed)]
        [OperationContract]
        Int16 RestarSaldo(ClienteEmp1 objClienteEmp1);
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    // Puede agregar archivos XSD al proyecto. Después de compilar el proyecto, puede usar directamente los tipos de datos definidos aquí, con el espacio de nombres "WCFEmpresa1.ContractType".
    [DataContract]
    [Serializable]
    public class ClienteEmp1
    {
        [DataMember]
        public string Cliente { get; set; }

        [DataMember]
        public Decimal Monto { get; set; }
    }
}
