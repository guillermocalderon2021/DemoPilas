using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPilas
{
    class Pila<T>
    {
        private Nodo<T> tope;

        public Pila()
        {
            tope = null;
        }

        public void Push(T valor)
        {
            Nodo<T> nuevo = new Nodo<T>(valor);
            if (tope == null) //Si la pila esta vacia
            {
                tope = nuevo;
                nuevo.Siguiente = null;
            }
            else
            {
                nuevo.Siguiente = tope;
                tope = nuevo;
            }

        }

        // Método que recorre e imprime los elementos de la cola
        public void Imprimir()
        {
            Nodo<T> actual = new Nodo<T>();
            actual = tope;
            if (tope == null)
            {
                Console.WriteLine("La pila esta vacia");
                return;
            }
            while (actual != null)
            {
                Console.WriteLine(actual.Dato);
                actual = actual.Siguiente;
            }
        }

        public Nodo<T> Peek()
        {
            return tope;
        }

        public Nodo<T> Pop()
        {
            Nodo<T> eliminado = tope;
            if (tope != null) // Si la pila no esta vacia
            {
                tope = tope.Siguiente;
                eliminado.Siguiente = null;
                
            }
            return eliminado;
        }
    }
}
