using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
// agregar
using System.Data.SqlClient;
using System.Data;
using System.ServiceModel.Channels;

namespace DemoServiceInfracciones
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        //Creamos instancias
        SqlConnection cnx = new SqlConnection(ConexionADO.GetCnx());
        SqlCommand cmd = new SqlCommand();
        DataSet dts = new DataSet();
        SqlDataAdapter ada;

        DataSet IService1.ListarPapeletasAuto_Fechas(String numPlaca, DateTime fecIni, DateTime fecFin)
        {
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarPapeletasAuto_Fechas";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@num_placa", numPlaca);
                cmd.Parameters.AddWithValue("@Fec_ini", fecIni);
                cmd.Parameters.AddWithValue("@fec_fin", fecFin);
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Papeletas");
                return dts;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: "+ ex.Message);
            }
        }

        DataSet IService1.EstadisticaMultas_AutoMensual(String numPlaca, Int16 año)
        {
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EstadisticaMultas_AutoMensual";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@num_placa", numPlaca);
                cmd.Parameters.AddWithValue("@año", año);
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Estadistica");
                return dts;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        DataSet IService1.EstadisticaPapeletas_AutoAnual(String numPlaca)
        {
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EstadisticaPapeletas_AutoAnual";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@num_placa", numPlaca);
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Estadistica2");
                return dts;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}
