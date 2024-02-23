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
    }
}
