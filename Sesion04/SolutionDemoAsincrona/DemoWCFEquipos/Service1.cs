using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoWCFEquipos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public List<String> ObtenerJugadores()
        {
            List<String> lstJugadores = new List<String>();
            //Simulamos un ratardo es 10 segundos en la ejecutamos..
            System.Threading.Thread.Sleep(10000);
            lstJugadores.Add("Pele");
            lstJugadores.Add("Maradona");
            lstJugadores.Add("Messi");
            lstJugadores.Add("Ronaldo");
            lstJugadores.Add("Neymar");
            return lstJugadores;
        }

        public List<String> ObtenerCiudades()
        {
            List<String> lstCiudades = new List<String>();
            lstCiudades.Add("Lima");
            lstCiudades.Add("Santiago de Chile");
            lstCiudades.Add("Bogota");
            lstCiudades.Add("Londres");
            lstCiudades.Add("Madrid");
            return lstCiudades;
        }
    }
}
