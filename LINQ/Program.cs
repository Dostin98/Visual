using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesonaje[] lst =
            {
                new Pesonaje(1,"patito"),
                new Pesonaje(666, "diablito lara"),
                new Pesonaje(45, "juanito"),
                new Pesonaje(4, "pepito"),
                new Pesonaje(67, "carlitos"),
                new Pesonaje(8, "jualiana"),
                new Pesonaje(98, "foca"),
            };

            var personajes = (from d in lst
                              orderby d.Numero
                              select d); 

            foreach (var oElement in personajes)
            {
                Console.Write(oElement.Imprime());
            }
        }
    }
}
