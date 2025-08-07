using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactosWinForms
{
    public class Nodo
    {
        public Contacto Contacto { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Contacto contacto)
        {
            Contacto = contacto;
            Siguiente = null;
        }
    }
}
