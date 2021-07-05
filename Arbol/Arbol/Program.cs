using System;

namespace Arbol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Arupo!");

            var raiz = new Nodo()
            {
                Valor = "*",
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "+",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "8"
                            },
                            new Nodo
                            {
                                Valor = "5"
                            }
                        }
                    },
                    new Nodo
                    {
                        Valor = "-",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "7"
                            },
                            new Nodo
                            {
                                Valor = "4"
                            }
                        }
                    }
                }
            };

            ManejadorArbol manejadorArbol = new ManejadorArbol();

            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz));

        }
    }
}
