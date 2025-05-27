using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Ventas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioFactura" en el código y en el archivo de configuración a la vez.
    public class ServicioFactura : IServicioFactura
    {
        public List<FacturaDC>ListarFacturasClienteFechas(String strCodigo,DateTime fecIni, DateTime fecFin)
        {
            try
            {
                //Creamos la instancia del modelo
                VentasLeonEntities ventasLeonEntities = new VentasLeonEntities();

                //Creamos la creacion de facturas a retornar
                List<FacturaDC> objListaFacturas = new List<FacturaDC>();

                //Obtenemos la facturacion del cliente
                var query = (from factura in ventasLeonEntities.Tb_Factura
                             where factura.Cod_cli == strCodigo && factura.Fec_fac >= fecIni && factura.Fec_fac <= fecFin
                             select factura);

                //Recorremos el query
                foreach (var resultado in query)
                {
                    FacturaDC objFacturaDC = new FacturaDC();
                    objFacturaDC.Num_Fac = resultado.Num_fac;
                    objFacturaDC.Fecha_Fac = resultado.Fec_fac;
                    objFacturaDC.Fecha_Can = resultado.Fec_can;
                    objFacturaDC.Cod_Cli = resultado.Cod_cli;
                    objFacturaDC.Raz_soc_Cli = resultado.Tb_Cliente.Raz_soc_cli;
                    objFacturaDC.Est_Fac = Convert.ToInt16(resultado.Est_fac);
                    if (objFacturaDC.Est_Fac == 1)
                    {
                        objFacturaDC.Est_Des = "Pendiendte";
                    }
                    else if (objFacturaDC.Est_Fac == 2)
                    {
                        objFacturaDC.Est_Des = "Cancelada";
                    }
                    else
                    {
                        objFacturaDC.Est_Des = "Anulada";
                    }
                    objFacturaDC.Cod_Ven = resultado.Cod_ven;
                    objFacturaDC.ApeNom_Ven = resultado.Tb_Vendedor.Ape_ven + " " + resultado.Tb_Vendedor.Nom_ven;
                    objFacturaDC.Total = (from detalle in ventasLeonEntities.Tb_Detalle_Factura
                                          where detalle.Num_fac == resultado.Num_fac
                                          select detalle.Can_ven * detalle.Pre_ven).Sum();
                    //Agrego la instancia objFacturaDC a la lista...
                    objListaFacturas.Add(objFacturaDC);
                }
                return objListaFacturas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<FacturaDC> ListarFacturasVendedorFechas(String strCodigo, DateTime fecIni, DateTime fecFin)
        {
            try
            {
                //Creamos la instancia del modelo
                VentasLeonEntities ventasLeonEntities = new VentasLeonEntities();

                //Creamos la creacion de facturas a retornar
                List<FacturaDC> objListaFacturas = new List<FacturaDC>();

                //Obtenemos las facturas del vendedor
                var query = ventasLeonEntities.usp_ListarFacturasVendedorFechas(strCodigo, fecIni, fecFin);
                //Recorremos el resultado
                foreach (var resultado in query)
                {
                    FacturaDC objFacturaDC = new FacturaDC();
                    objFacturaDC.Num_Fac = resultado.num_fac;
                    objFacturaDC.Fecha_Fac = resultado.fec_fac;
                    objFacturaDC.Fecha_Can = resultado.fec_can;
                    objFacturaDC.Est_Des = resultado.estado;
                    objFacturaDC.Cod_Cli = resultado.Cod_cli;
                    objFacturaDC.Raz_soc_Cli = resultado.Raz_soc_cli;
                    objFacturaDC.Total = Convert.ToSingle(resultado.total);

                    //Agrego la factura a la lista
                    objListaFacturas.Add(objFacturaDC);
                }

                return objListaFacturas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
