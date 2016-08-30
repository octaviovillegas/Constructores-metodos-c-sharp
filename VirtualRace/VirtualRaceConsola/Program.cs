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
            /*
         EFabricante fabricante;
         fabricante = EFabricante.Honda;
            
         Console.WriteLine(fabricante);
            
         fabricante = (EFabricante)1;
         Console.WriteLine(fabricante);
         */

            Rueda otraRueda = new Rueda(3);
            Rueda otraRueda2 = new Rueda("RuedaLoca");
            Rueda otraRueda3 = new Rueda("Firestone", 15);

            Carrera carrera = new Carrera();

            Auto nuevoAuto1 = new Auto();
            Auto nuevoAuto2 = new Auto();
            Auto nuevoAuto3 = new Auto();
            Auto nuevoAuto4 = new Auto();

            Tiempo tiempo = 5;
            Kilometro kilometro = 9;

            /*
            Console.WriteLine("{0} {1} {2} {3}",
                nuevoAuto1.Fabricante,
                nuevoAuto2.Fabricante,
                nuevoAuto3.Fabricante,
                nuevoAuto4.Fabricante);
             */

            // carrera.MostrarCarrera();
            // carrera.PorTiempo(5);

            carrera.CorrerCarrera(tiempo);

            carrera.CorrerCarrera(kilometro);

            carrera.CorrerCarrera(tiempo);

            tiempo = tiempo + 10; // funciona porque esta sobrecargado el operador

            Console.WriteLine("El tiempo es: " + (int)tiempo);

            Console.ReadKey();
        }
    }
}
