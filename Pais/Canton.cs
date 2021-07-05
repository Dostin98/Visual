using System;
using System.Collections.Generic;

namespace Pais
{
    class Canton
    {
        public int id { get; set; }

        public string Nombre { get; set; }

        public List<Parroquia> Parroquias { get; set; } = new List<Parroquia>();

        public int ObtenerNumeroDeHabitantes()
        {
            int acumulador = 0;
            foreach (Parroquia actual in Parroquias)
            {
                acumulador = acumulador + actual.Habitantes;
            }
            return acumulador;
        }


    }
}
