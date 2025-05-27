using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//agregar dependencias
using System.Configuration;

namespace DemoServiceInfracciones
{
    static class ConexionADO
    {
        public static String GetCnx()
        {
            String strCnx = ConfigurationManager.ConnectionStrings["Infracciones"].ConnectionString;
            if (strCnx == null)
            {
                return String.Empty;
            }
            else
            {
                return strCnx;
            }
        }
    }
}