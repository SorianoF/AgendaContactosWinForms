using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactosWinForms
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public Contacto(string nombre, string telefono, string correo)
        {
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Teléfono: {Telefono}, Correo: {Correo}";
        }
    }
}
