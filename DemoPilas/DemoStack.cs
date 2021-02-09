using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPilas
{
    class DemoStack
    {
        static void Main(string[] args)
        {
            Stack<string> miPila = new Stack<string>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------ DEMO PILAS -------------:");
                Console.WriteLine("1) Agregar elemento a la pila");
                Console.WriteLine("2) Mostrar pila");
                Console.WriteLine("3) Quitar elemento de la pila");
                Console.WriteLine("4) Mostrar tope de la pila");
                Console.WriteLine("0) Salir");
                Console.Write("\r\nSelecciona una opcion: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Ingresa un elemento:");
                        string valor = Console.ReadLine();
                        miPila.Push(valor);
                        break;
                    case "2":
                        if (miPila.Count == 0)
                        {
                            Console.WriteLine("La pila esta vacia"); ;
                        }
                        else
                        {

                            foreach (var item in miPila)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        if (miPila.Count == 0)
                        {
                            Console.WriteLine("La pila esta vacia"); ;
                        }
                        else
                        {
                            string eliminado = miPila.Pop();
                            Console.WriteLine("El elemento eliminado es: " + eliminado);
                        }
         
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("El tope de la pila es: " + miPila.Peek());
                        Console.ReadKey();
                        break;
                    case "0":
                        return;
                    default:
                        break;
                }

            }
        }
    }
}
