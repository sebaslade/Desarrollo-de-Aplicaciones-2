using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Ventas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioVendedor" en el código y en el archivo de configuración a la vez.
    public class ServicioVendedor : IServicioVendedor
    {
        public VendedorDC ConsultarVendedor(String strCodigo)
        {
            try
            {
                VentasLeonEntities ventasLeonEntities = new VentasLeonEntities();

                VendedorDC objVendedorDC = new VendedorDC();

                var query = ventasLeonEntities.usp_ConsultarVendedor(strCodigo);

                foreach (var resultado in query)
                {
                    objVendedorDC.Cod_ven = resultado.Cod_ven;
                    objVendedorDC.Nom_ven = resultado.Nom_ven;
                    objVendedorDC.Ape_ven = resultado.Ape_ven;
                    objVendedorDC.ApellNom_Supervisor = resultado.NomSupervisor;
                    objVendedorDC.Sue_ven = resultado.Sue_ven;
                    objVendedorDC.Fec_ing = Convert.ToDateTime(resultado.Fec_ing);
                    objVendedorDC.DNI_ven = resultado.DNI_ven;
                    objVendedorDC.Tip_ven = Convert.ToInt16(resultado.Tip_ven);
                    objVendedorDC.Estado = resultado.Estado;
                    objVendedorDC.Est_ven = resultado.Est_ven;
                    objVendedorDC.Email_ven = resultado.Email_ven;
                }
                return objVendedorDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<VendedorDC> ListarVendedor() 
        {
            try
            {
                VentasLeonEntities ventasLeonEntities = new VentasLeonEntities();
                List<VendedorDC> objLista = new List<VendedorDC>();

                var query = (from vendedor in ventasLeonEntities.Tb_Vendedor
                             orderby vendedor.Ape_ven
                             select vendedor).ToList();

                foreach(var resultado in query)
                {
                    VendedorDC objVendedorDC = new VendedorDC();
                    objVendedorDC.Cod_ven = resultado.Cod_ven;
                    objVendedorDC.Nom_ven = resultado.Nom_ven;
                    objVendedorDC.Ape_ven = resultado.Ape_ven;
                    objVendedorDC.Sue_ven = resultado.Sue_ven;
                    objVendedorDC.Fec_ing = Convert.ToDateTime(resultado.Fec_ing);
                    objVendedorDC.DNI_ven = resultado.Dni_ven;
                    objVendedorDC.Tip_ven = Convert.ToInt16(resultado.Tip_ven);
                    objVendedorDC.Email_ven = resultado.Email_ven;
                    objVendedorDC.Cod_Supervisor = resultado.Cod_Supervisor;
                    objVendedorDC.ApellNom_Supervisor = resultado.Tb_Vendedor2.Ape_ven + " " + resultado.Nom_ven;
                    objVendedorDC.Est_ven = Convert.ToInt16(resultado.Est_ven);
                    if(objVendedorDC.Est_ven == 1)
                    {
                        objVendedorDC.Estado = "Activo";
                    }
                    else
                    {
                        objVendedorDC.Estado = "Inactivo";
                    }
                    objLista.Add(objVendedorDC);
                }
                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertarVendedor(VendedorDC objVendedorDC)
        {
            try
            {
                VentasLeonEntities ventasLeonEntities = new VentasLeonEntities();

                ventasLeonEntities.usp_InsertarVendedor(
                    objVendedorDC.Nom_ven, objVendedorDC.Ape_ven,
                    Convert.ToDecimal(objVendedorDC.Sue_ven),
                    Convert.ToDateTime(objVendedorDC.Fec_ing),
                    Convert.ToInt16(objVendedorDC.Tip_ven),
                    objVendedorDC.DNI_ven,
                    objVendedorDC.Email_ven, objVendedorDC.Cod_Supervisor,
                    objVendedorDC.Usu_Registro,
                    Convert.ToInt16(objVendedorDC.Est_ven));
                //Actualizamos el modelo
                ventasLeonEntities.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean ActualizarVendedor(VendedorDC objVendedorDC)
        {
            try
            {
                VentasLeonEntities ventasLeonEntities = new VentasLeonEntities();

                ventasLeonEntities.usp_ActualizarVendedor(
                    objVendedorDC.Cod_ven,
                    objVendedorDC.Nom_ven, objVendedorDC.Ape_ven,
                    Convert.ToDecimal(objVendedorDC.Sue_ven),
                    Convert.ToDateTime(objVendedorDC.Fec_ing),
                    Convert.ToInt16(objVendedorDC.Tip_ven),
                    objVendedorDC.DNI_ven,
                    objVendedorDC.Email_ven, objVendedorDC.Cod_Supervisor,
                    objVendedorDC.Usu_Ult_Mod,
                    Convert.ToInt16(objVendedorDC.Est_ven));

                //Actualizamos el modelo
                ventasLeonEntities.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean EliminarVendedor(String strCodigo)
        {
            try
            {
                VentasLeonEntities ventasLeonEntities = new VentasLeonEntities();

                ventasLeonEntities.usp_EliminarVendedor(strCodigo);

                //Actualizamos el modelo
                ventasLeonEntities.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<VendedorDC> ListarSupervisores()
        {
            try
            {
                VentasLeonEntities ventasLeonEntities = new VentasLeonEntities();
                List<VendedorDC> objLista = new List<VendedorDC>();

                var query = (from vendedor in ventasLeonEntities.Tb_Vendedor
                             where vendedor.Tip_ven == 1 && vendedor.Est_ven==1
                             orderby vendedor.Ape_ven
                             select vendedor).ToList();
                foreach ( var result in query )
                {
                    VendedorDC objVendedorDC = new VendedorDC();
                    objVendedorDC.Cod_ven = result.Cod_ven;
                    objVendedorDC.Ape_ven = result.Ape_ven+", "+result.Nom_ven;
                    objLista.Add(objVendedorDC);
                }
                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
