using System;
using System.Collections.Generic;

namespace Pais
{
    class Program
    {
        static void Main(string[] args)
        {
            var pais = new Pais()
            {
                PaisId = 1,
                Nombre = "Ecuador"
            };
            
            pais.Provincias = new List<Provincia>();
            var provincia1 = new Provincia();
            provincia1.Nombre = "Carchi";
            var provincia2 = new Provincia();
            provincia2.Nombre = "Zamora";
            pais.Provincias = new List<Provincia>()
            {
                provincia1,
                provincia2
            };

            var canton = new Canton();
            canton.Nombre = "Quito";
            var canton2 = new Canton();
            canton2.Nombre = "Rumiñahui";

            provincia1.Cantones = new List<Canton>();
            provincia1.Cantones.Add(canton);
            provincia1.Cantones.Add(canton2);

            var parroquia = new Parroquia();
            parroquia.Nombre = "Chillogallo";
            var parroquia2 = new Parroquia();
            parroquia2.Nombre = "La Santiago";
            parroquia.Habitantes = 1000;
            parroquia2.Habitantes = 500;

            canton.Parroquias = new List<Parroquia>();
            canton.Parroquias.Add(parroquia);
            canton2.Parroquias.Add(parroquia2);

            Console.WriteLine($"El resultado de los habitantes es:{pais.ObtenerNumeroDeHabitantes()}");

        }
    }
}
