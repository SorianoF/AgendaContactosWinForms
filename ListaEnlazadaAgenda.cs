using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactosWinForms
{
    public class ListaEnlazadaAgenda
    {
        private Nodo cabeza;

        public void AgregarContacto(Contacto contacto)
        {
            Nodo nuevo = new Nodo(contacto);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        public bool EliminarContacto(string nombre)
        {
            if (cabeza == null) return false;

            if (cabeza.Contacto.Nombre == nombre)
            {
                cabeza = cabeza.Siguiente;
                return true;
            }

            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                if (actual.Siguiente.Contacto.Nombre == nombre)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }

        public List<Contacto> ObtenerContactos()
        {
            List<Contacto> lista = new List<Contacto>();
            Nodo actual = cabeza;
            while (actual != null)
            {
                lista.Add(actual.Contacto);
                actual = actual.Siguiente;
            }
            return lista;
        }
    }
}

