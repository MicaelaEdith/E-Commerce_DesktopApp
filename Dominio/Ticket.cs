using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ticket
    {
        public Ticket() { }
        public Ticket(decimal valor)
        {
            this.valor = valor;
        }

        public int id { get; set; }
        public decimal valor { get; set; }
        public static List<Ticket> cajaDiaria { get; set; }


    }
}
