using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class TicketNegocio
    {
        public void facturar(decimal valor)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearParametro("@valor", valor);
                datos.Consulta("insert  into tickets (valor) values(@valor);");
                datos.Insertar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public decimal obtenerPromedio() {
            
            AccesoDatos datos = new AccesoDatos();
            decimal promedio = 0;
            decimal sumaValores = 0;
            int totalValores = 0;


            try
            {
                datos.Consulta("SELECT valor FROM tickets;");
                datos.Leer();
                while (datos.Lector.Read())
                {
                    decimal valor = datos.Lector.GetDecimal(0);
                    sumaValores += valor;
                    totalValores++;
                }
                promedio = totalValores > 0 ? sumaValores / totalValores : 0;
                return Math.Round(promedio,2);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void cierreCaja(Decimal cierre, DateTime fecha)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearParametro("@cierre", cierre);
                datos.setearParametro("@fecha", fecha);
                datos.Consulta("INSERT INTO cierresCaja (valorTotalFacturado, fecha) VALUES (@cierre, @fecha);");
                datos.Insertar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
