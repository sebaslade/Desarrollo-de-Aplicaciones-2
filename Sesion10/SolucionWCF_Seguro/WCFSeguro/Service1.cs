using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFSeguro
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public Single Promediar(Single v1, Single v2)
        {
            try
            {
                Single sngPromedio = (v1 + v2) / 2;
                return sngPromedio;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
