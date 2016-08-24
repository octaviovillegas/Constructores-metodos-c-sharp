using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualRaceConsola
{
    public class Rueda
    {
        public string marca;
        public int tamaño;
        /// <summary>
        /// constructor por defecto que inicializa el atributo marca con 'sin marca'
        /// </summary>
        public Rueda()
        {
            this.marca = "Sin marca";
        }
        public Rueda(string marca)
        {
            this.marca = marca;
        }
        public Rueda(int tamaño):this()
        {
            this.tamaño = tamaño;
        }
        public Rueda(string marca, int tamaño):this(tamaño)
        {
            this.marca = marca;
        }
        /*
         *Error . tiene la misma firma
        public Rueda(string marcados, int tamañodos)
        {
            this.marca = "Sin marca";
        }
          */
        public Rueda( int tamaño,string marca):this(marca,tamaño)
        {
          // no tiene implementacion , reutiliza código anterior
        }

    }
}
