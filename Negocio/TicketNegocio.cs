using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    class TicketNegocio
    {
        public void agregar(Ticket ticket)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.Consulta("insert into TICKETS values ("+ticket.valor+");");
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
