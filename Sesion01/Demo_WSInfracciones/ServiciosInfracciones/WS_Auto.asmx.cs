using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
//agregar las dependencias
using System.Data;
using System.Data.SqlClient;

namespace ServiciosInfracciones
{
    /// <summary>
    /// Summary description for WS_Auto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Auto : System.Web.Services.WebService
    {
        SqlConnection cnx = new SqlConnection(ConexionADO.GetCnx());
        SqlCommand cmd = new SqlCommand();
        DataSet dts = new DataSet();
        SqlDataAdapter ada;

        [WebMethod]
        public Single CalcularMulta(String strNumPlaca)
        {
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_AutoMulta";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@num_placa",strNumPlaca);
                cmd.Parameters.Add(new SqlParameter("@multa", SqlDbType.Money));
                cmd.Parameters["@multa"].Direction = ParameterDirection.Output;

                //abrimos conexion y ejecutamos
                cnx.Open();
                cmd.ExecuteScalar();
                Single sngMulta = Convert.ToSingle(cmd.Parameters["@multa"].Value);
                return sngMulta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnx.Close(); 
            }
        }

        [WebMethod]
        public String AutoPropietario(String strNumPlaca)
        {
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_AutoPropietario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@num_placa", strNumPlaca);
                cmd.Parameters.Add(new SqlParameter("@datos", SqlDbType.VarChar,50));
                cmd.Parameters["@datos"].Direction = ParameterDirection.Output;

                //abrimos conexion y ejecutamos
                cnx.Open();
                cmd.ExecuteScalar();
                String strDatos = cmd.Parameters["@datos"].Value.ToString();
                return strDatos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        [WebMethod]
        public DataSet PapeletasImpagas(String strNumPlaca)
        {
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_PapeletasImpagas";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@num_placa", strNumPlaca);

                //abrimos conexion y ejecutamos
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "PapeletasImpagas");
                return dts;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }
    }
}
