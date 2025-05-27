using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Ventas
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCliente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCliente
    {
        [OperationContract]
        ClienteDC ConsultarCliente(string strCodigo);

        [OperationContract]
        Single CalcularDeudaCliente(string strCodigo);
    }
    [DataContract]
    [Serializable]
    public class ClienteDC
    {
        [DataMember]
        public String Cod_cli { get; set; }
        [DataMember]
        public String Raz_soc_cli { get; set; }
        [DataMember]
        public String Dir_cli { get; set; }
        [DataMember]
        public String Tel_cli { get; set; }
        [DataMember]
        public String Ruc_cli { get; set; }
        [DataMember]
        public String Contacto { get; set; }
        [DataMember]
        public String Departamento { get; set; }
        [DataMember]
        public String Provincia { get; set; }
        [DataMember]
        public String Distrito { get; set; }
        [DataMember]
        public DateTime Fec_reg { get; set; }
        [DataMember]
        public Int16 Tip_cli { get; set; }
        [DataMember]
        public Int16 Est_cli { get; set; }

        // Propiedades derivadas...
        [DataMember]
        public Single Deuda { get; set; }
        [DataMember]
        public Int16 Cant_FacturasPendientes { get; set; }
    }
}
