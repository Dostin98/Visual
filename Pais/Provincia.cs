using System;
using System.Collections.Generic;

namespace Pais
{
    class Provincia
    {
        public int Id { get; set; }

        public string Nombre { get; set }

        public List<Canton> Cantones { get; set; } = new List<Canton>();
        public int ObtenerNumeroDeHabitantes()
        {
            int acumulador = 0;
            foreach (Canton actual in Cantones)
            {
                acumulador = acumulador + actual.ObtenerNumeroDeHabitantes();
            }
            return acumulador;
        }
    };
}
