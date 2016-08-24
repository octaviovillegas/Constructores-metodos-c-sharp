using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualRaceConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Rueda nuevaRueda;
           nuevaRueda = new Rueda();
            
           eFabricante fabricante;

           fabricante = eFabricante.Honda;
           Console.WriteLine(fabricante);
           fabricante = (eFabricante)1;
           Console.WriteLine(fabricante);
           Console.ReadKey();*/

            Carrera carrera = new Carrera();
            carrera.MostrarCarrera();
            Console.ReadKey();
        }
    }
}
