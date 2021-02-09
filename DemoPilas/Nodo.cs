using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPilas
{
    class Nodo<T>
    {
        private T dato;

        public T Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        private Nodo<T> siguiente;

        public Nodo<T> Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Nodo(T valor)
        {
            this.dato = valor;
            this.siguiente = null;
        }

        public Nodo()
        {

        }
    }
}
