using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Ventas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCliente" en el código y en el archivo de configuración a la vez.
    public class ServicioCliente : IServicioCliente
    {
        VentasLeonEntities ventasLeonEntities = new VentasLeonEntities();
        public ClienteDC ConsultarCliente(string strCodigo)
        {
            try
            {
                //Definimos la instancia a retornar
                ClienteDC objClienteDC = new ClienteDC();

                //Con LinQ obtenemos los datos
                Tb_Cliente objConsulta = (from cliente in ventasLeonEntities.Tb_Cliente
                                          where cliente.Cod_cli == strCodigo
                                          select cliente).FirstOrDefault();
                if (objConsulta != null)
                {
                    objClienteDC.Cod_cli=objConsulta.Cod_cli;
                    objClienteDC.Raz_soc_cli = objConsulta.Raz_soc_cli;
                    objClienteDC.Dir_cli=objConsulta.Dir_cli;
                    objClienteDC.Ruc_cli=objConsulta.Ruc_cli;
                    objClienteDC.Tel_cli=objConsulta.Tel_cli;
                    objClienteDC.Contacto=objConsulta.Contacto;
                    objClienteDC.Departamento=objConsulta.Tb_Ubigeo.Departamento;
                    objClienteDC.Provincia=objConsulta.Tb_Ubigeo.Provincia;
                    objClienteDC.Distrito=objConsulta.Tb_Ubigeo.Distrito;
                    objClienteDC.Tip_cli=Convert.ToInt16(objClienteDC.Tip_cli);
                    objClienteDC.Est_cli=Convert.ToInt16(objClienteDC.Est_cli);
                    objClienteDC.Deuda = 0;
                    objClienteDC.Cant_FacturasPendientes = Convert.ToInt16((from factura in ventasLeonEntities.Tb_Factura
                                                            where factura.Cod_cli == strCodigo && factura.Est_fac == 1
                                                            select factura).Count());
                }
                else
                {
                    objClienteDC.Cod_cli = String.Empty;
                }
                //Retornamos la instancia
                return objClienteDC;
            }
            catch (EntityException ex)
            {
                throw new Exception("Error:"+ex.Message);
            }
        }

        public Single CalcularDeudaCliente(string strCodigo)
        {
            try
            {
                //Definimos la instancia a retornar
                Single sngDeuda = 0;

                // Preguntamos si el cliente tiene facturas pendientes
                if ((from miFactura in ventasLeonEntities.Tb_Factura
                     where miFactura.Cod_cli == strCodigo && miFactura.Est_fac == 1
                     select miFactura).Count() == 0)
                {
                    sngDeuda = 0;
                }
                else
                {
                    sngDeuda = Convert.ToSingle
                        (
                            (from miFactura in ventasLeonEntities.Tb_Factura
                             join misDetalles in ventasLeonEntities.Tb_Detalle_Factura
                             on miFactura.Num_fac equals misDetalles.Num_fac
                             where miFactura.Cod_cli == strCodigo && miFactura.Est_fac == 1
                             select misDetalles.Can_ven * misDetalles.Pre_ven
                            ).Sum()
                        );
                }
                //Retornamos la instancia
                return sngDeuda;
            }
            catch (EntityException ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }
    }
}
