using System;

namespace LINQ
{
    class Pesonaje
    { 
        public int Numero { get; set; }
        public string Nombre { get; set; }

        public Pesonaje(int Numero, string Nombre)
        {
            this.Numero = Numero;
            this.Nombre = Nombre;
        }

        public string Imprime()
        {
            return Numero + " " + Nombre + "\n";
        }
    }
}
