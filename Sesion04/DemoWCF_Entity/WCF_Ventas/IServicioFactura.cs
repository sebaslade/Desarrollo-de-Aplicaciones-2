using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Ventas
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioFactura" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioFactura
    {
        [OperationContract]
        List<FacturaDC> ListarFacturasClienteFechas(String strCodigo, DateTime fecIni, DateTime fecFin);
        [OperationContract]
        List<FacturaDC> ListarFacturasVendedorFechas(String strCodigo, DateTime fecIni, DateTime fecFin);
    }

    //Definicion de la DataContractual de facturas..
    [DataContract]
    [Serializable]
    public class FacturaDC
    {
        [DataMember]
        public String Num_Fac { get; set; }
        [DataMember]
        public DateTime Fecha_Fac { get; set; }
        [DataMember]
        public DateTime? Fecha_Can { get; set; }
        [DataMember]
        public String Cod_Cli {  get; set; }
        [DataMember]
        public String Raz_soc_Cli {  get; set; }
        [DataMember]
        public Single Total { get; set; }
        [DataMember]
        public Int16 Est_Fac { get; set; }
        [DataMember]
        public String Est_Des { get; set; }
        [DataMember]
        public String Cod_Ven {  get; set; }
        [DataMember]
        public String ApeNom_Ven {get; set; }
    }
}
