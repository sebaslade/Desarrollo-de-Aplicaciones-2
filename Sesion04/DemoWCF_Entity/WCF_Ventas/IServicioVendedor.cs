using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Ventas
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioVendedor" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioVendedor
    {
        [OperationContract]
        VendedorDC ConsultarVendedor(String strCodigo);

        [OperationContract]
        List<VendedorDC> ListarVendedor();

        [OperationContract]
        Boolean InsertarVendedor(VendedorDC objVendedorDC);

        [OperationContract]
        Boolean ActualizarVendedor(VendedorDC objVendedorDC);

        [OperationContract]
        Boolean EliminarVendedor(String strCodigo);

        [OperationContract]
        List<VendedorDC> ListarSupervisores();
    }
    [DataContract]
    [Serializable]
    public class VendedorDC
    {
        [DataMember]
        public String Cod_ven { get; set; }

        [DataMember]
        public String Nom_ven { get; set; }

        [DataMember]
        public String Ape_ven { get; set; }

        [DataMember]
        public Decimal? Sue_ven { get; set; }

        [DataMember]
        public DateTime Fec_ing { get; set; }

        [DataMember]
        public Int16 Tip_ven { get; set; }

        [DataMember]
        public String DNI_ven { get; set; }

        [DataMember]
        public String Email_ven { get; set; }

        [DataMember]
        public String Cod_Supervisor { get; set; }

        [DataMember]
        public String ApellNom_Supervisor { get; set; }

        [DataMember]
        public DateTime? Fec_Registro { get; set; }

        [DataMember]
        public String Usu_Registro { get; set; }

        [DataMember]
        public DateTime? Fec_Ult_Mod { get; set; }

        [DataMember]
        public String Usu_Ult_Mod { get; set; }

        [DataMember]
        public Int32? Est_ven { get; set; }

        [DataMember]
        public String Estado { get; set; }
    }
}
