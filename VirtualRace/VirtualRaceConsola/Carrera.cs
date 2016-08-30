using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualRaceConsola
{
    public class Carrera
    {

        public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;
        private static Random random;

        static Carrera()
        {
            random = new Random();
           
        }

        /* DEPRACATED: POR SOBRECARGA
        public void PorTiempo(int minutos)
        {
            int contadorMinutos;
            Auto mayor;
            Auto menor;
            Kilometro kilometroAux;

            for (contadorMinutos = 0; contadorMinutos < minutos; contadorMinutos++)
            {
                kilometroAux = new Kilometro(random.Next(10, 100));
                this.auto1.Agregar(kilometroAux);
                this.auto2.Agregar(new Kilometro(random.Next(10, 100)));
                this.auto3.Agregar(new Kilometro(random.Next(10, 100)));
                this.auto4.Agregar(new Kilometro(random.Next(10, 100)));
                this.auto5.Agregar(new Kilometro(random.Next(10, 100)));
                this.auto6.Agregar(new Kilometro(random.Next(10, 100)));
            }
            menor = mayor = auto1;
            if (this.auto2.ObtenerKilometros().Cantidad < menor.ObtenerKilometros().Cantidad)
                menor = auto2;
            if (this.auto2.ObtenerKilometros().Cantidad > mayor.ObtenerKilometros().Cantidad)
                mayor = auto2;
            if (this.auto3.ObtenerKilometros().Cantidad < menor.ObtenerKilometros().Cantidad)
                menor = auto3;
            if (this.auto3.ObtenerKilometros().Cantidad > mayor.ObtenerKilometros().Cantidad)
                mayor = auto3;
            if (this.auto4.ObtenerKilometros().Cantidad < menor.ObtenerKilometros().Cantidad)
                menor = auto4;
            if (this.auto4.ObtenerKilometros().Cantidad > mayor.ObtenerKilometros().Cantidad)
                mayor = auto4;
            if (this.auto5.ObtenerKilometros().Cantidad < menor.ObtenerKilometros().Cantidad)
                menor = auto5;
            if (this.auto5.ObtenerKilometros().Cantidad > mayor.ObtenerKilometros().Cantidad)
                mayor = auto5;
            if (this.auto6.ObtenerKilometros().Cantidad < menor.ObtenerKilometros().Cantidad)
                menor = auto6;
            if (this.auto6.ObtenerKilometros().Cantidad > mayor.ObtenerKilometros().Cantidad)
                mayor = auto6;

            Console.WriteLine("El que mÃ¡s recorriÃ³ fue un {0} y la distancia fue {1}", mayor.Fabricante, mayor.ObtenerKilometros());
            Console.WriteLine("El que menos recorriÃ³ fue un {0} y la distancia fue {1}", menor.Fabricante, menor.ObtenerKilometros());
            
            this.auto1.VolverACero();
            this.auto2.VolverACero();
            this.auto3.VolverACero();
            this.auto4.VolverACero();
            this.auto5.VolverACero();
            this.auto6.VolverACero();
        }
         */


        



        #region ejercicio 3


        public void CorrerCarrera(Tiempo tiempo)
        {
            int contadorMinutos;
            Auto mayor;
            Auto menor;

            for (contadorMinutos = 0; contadorMinutos <  (int)tiempo; contadorMinutos++)
            {
                this.auto1.Agregar((Tiempo)random.Next(10, 100));
                this.auto2.Agregar((Tiempo)random.Next(10, 100));
                this.auto3.Agregar((Tiempo)random.Next(10, 100));
                this.auto4.Agregar((Tiempo)random.Next(10, 100));
                this.auto5.Agregar((Tiempo)random.Next(10, 100));
                this.auto6.Agregar((Tiempo)random.Next(10, 100));
            }
            menor = mayor = auto1;
            if ((int)this.auto2.ObtenerKilometros() < (int)menor.ObtenerKilometros())
                menor = auto2;
            if ((int)this.auto2.ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                mayor = auto2;
            if ((int)this.auto3.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto3;
            if ((int)this.auto3.ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                mayor = auto3;
            if ((int)this.auto4.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto4;
            if ((int)this.auto4.ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                mayor = auto4;
            if ((int)this.auto5.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto5;
            if ((int)this.auto5.ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                mayor = auto5;
            if ((int)this.auto6.ObtenerKilometros() < menor.ObtenerKilometros())
                menor = auto6;
            if ((int)this.auto6.ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                mayor = auto6;

            Console.WriteLine("El que mÃ¡s recorriÃ³ fue un {0} y la distancia fue {1}", mayor.Fabricante, (int)mayor.ObtenerKilometros());
            Console.WriteLine("El que menos recorriÃ³ fue un {0} y la distancia fue {1}", menor.Fabricante, menor.ObtenerKilometros());
            
            this.auto1.VolverACero();
            this.auto2.VolverACero();
            this.auto3.VolverACero();
            this.auto4.VolverACero();
            this.auto5.VolverACero();
            this.auto6.VolverACero();
        }

        public void CorrerCarrera(Kilometro kilometro)
        {
            int contadorKilometros;
            Auto mayor;
            Auto menor;
            for (contadorKilometros = 0; contadorKilometros < (int)kilometro; contadorKilometros++)
            {
                this.auto1.Agregar((Tiempo)random.Next(10, 100));
                this.auto2.Agregar((Tiempo)random.Next(10, 100));
                this.auto3.Agregar((Tiempo)random.Next(10, 100));
                this.auto4.Agregar((Tiempo)random.Next(10, 100));
                this.auto5.Agregar((Tiempo)random.Next(10, 100));
                this.auto6.Agregar((Tiempo)random.Next(10, 100));
            }
            menor = mayor = auto1;
            if (this.auto2.ObtenerTiempo() < menor.ObtenerTiempo())
                menor = auto2;
            if (this.auto2.ObtenerTiempo() > mayor.ObtenerTiempo())
                mayor = auto2;
            if (this.auto3.ObtenerTiempo() < menor.ObtenerTiempo())
                menor = auto3;
            if (this.auto3.ObtenerTiempo() > mayor.ObtenerTiempo())
                mayor = auto3;
            if (this.auto4.ObtenerTiempo() < menor.ObtenerTiempo())
                menor = auto4;
            if (this.auto4.ObtenerTiempo() > mayor.ObtenerTiempo())
                mayor = auto4;
            if (this.auto5.ObtenerTiempo() < menor.ObtenerTiempo())
                menor = auto5;
            if (this.auto5.ObtenerTiempo() > mayor.ObtenerTiempo())
                mayor = auto5;
            if (this.auto6.ObtenerTiempo() < menor.ObtenerTiempo())
                menor = auto6;
            if (this.auto6.ObtenerTiempo() > mayor.ObtenerTiempo())
                mayor = auto6;

            Console.WriteLine("El que más tarde fue un {0} y el tiempo fue {1}", mayor.Fabricante, mayor.ObtenerTiempo());
            Console.WriteLine("El que menos tarde fue un {0} y el tiempo fue {1}", menor.Fabricante, menor.ObtenerTiempo());
            
            this.auto1.VolverACero();
            this.auto2.VolverACero();
            this.auto3.VolverACero();
            this.auto4.VolverACero();
            this.auto5.VolverACero();
            this.auto6.VolverACero();
        }

        #endregion 
        
        public void MostrarCarrera()
        {
            this.auto1.MostrarAuto();
            this.auto2.MostrarAuto();
            this.auto3.MostrarAuto();
            this.auto4.MostrarAuto();
            this.auto5.MostrarAuto();
            this.auto6.MostrarAuto();
        }

        public Carrera()
        {
            this.auto1 = new Auto();
            this.auto2 = new Auto();
            this.auto3 = new Auto();
            this.auto4 = new Auto();
            this.auto5 = new Auto();
            this.auto6 = new Auto();
          random = new Random();
        }

    }
}
