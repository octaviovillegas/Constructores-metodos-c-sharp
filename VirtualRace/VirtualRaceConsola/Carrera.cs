using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualRaceConsola
{
    public class Carrera
    {
        /* depreticated por coleccion
        public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;
          */
        public string nombre;
        public string lugar;
        public string fecha;
        public List<Auto> ListaDeAutos;

        private static Random numeroRandom;

      

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
            Auto mayor= new Auto();
            Auto menor = new Auto();

            for (contadorMinutos = 0; contadorMinutos <  (int)tiempo; contadorMinutos++)
            {
                /* DEPRETICATED por colecciones
                     this.auto1.Agregar((Tiempo)numeroRandom.Next(10, 100));
                     this.auto2.Agregar((Tiempo)numeroRandom.Next(10, 100));
                     this.auto3.Agregar((Tiempo)numeroRandom.Next(10, 100));
                     this.auto4.Agregar((Tiempo)numeroRandom.Next(10, 100));
                     this.auto5.Agregar((Tiempo)numeroRandom.Next(10, 100));
                     this.auto6.Agregar((Tiempo)numeroRandom.Next(10, 100));
                        */
                   foreach (Auto item in this.ListaDeAutos)
                    {
                        item.Agregar((Kilometro)numeroRandom.Next(10, 100));
                    }


            }

            for (int elemento = 0; elemento < this.ListaDeAutos.Count; elemento++)
            {
                if (elemento == 0)
                {
                    menor = this.ListaDeAutos[elemento];
                    mayor = this.ListaDeAutos[elemento];
                    continue;
                }
                if ((int)this.ListaDeAutos[elemento].ObtenerKilometros() < (int)menor.ObtenerKilometros())
                    menor = this.ListaDeAutos[elemento];

                if ((int)this.ListaDeAutos[elemento].ObtenerKilometros() > (int)mayor.ObtenerKilometros())
                    mayor = this.ListaDeAutos[elemento];

                
            }

            /*DEPRETICATED por colecciones
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
             * */

            Console.WriteLine("El que más recorrió fue un {0} y la distancia fue {1}", mayor.Fabricante, (int)mayor.ObtenerKilometros());
            Console.WriteLine("El que menos recorri´0 fue un {0} y la distancia fue {1}", menor.Fabricante, (int)menor.ObtenerKilometros());




            /* DEPRETICATED por colecciones
               this.auto1.VolverACero();
               this.auto2.VolverACero();
               this.auto3.VolverACero();
               this.auto4.VolverACero();
               this.auto5.VolverACero();
               this.auto6.VolverACero();
                */
            foreach (Auto item in this.ListaDeAutos)
            {
                item.VolverACero();
            }

        }

        public void CorrerCarrera(Kilometro kilometro)
        {
           
            int contadorKilometros;
            Auto mayor=new Auto();
            Auto menor = new Auto();
            for (contadorKilometros = 0; contadorKilometros < (int)kilometro; contadorKilometros++)
            {
                /* DEPRETICATED por colecciones
                  this.auto1.Agregar((Tiempo)numeroRandom.Next(10, 100));
                  this.auto2.Agregar((Tiempo)numeroRandom.Next(10, 100));
                  this.auto3.Agregar((Tiempo)numeroRandom.Next(10, 100));
                  this.auto4.Agregar((Tiempo)numeroRandom.Next(10, 100));
                  this.auto5.Agregar((Tiempo)numeroRandom.Next(10, 100));
                  this.auto6.Agregar((Tiempo)numeroRandom.Next(10, 100));
                    */

                foreach (Auto item in this.ListaDeAutos)
	            {
                    item.Agregar((Tiempo)numeroRandom.Next(10, 100));
	            }

            }


            for (int i = 0; i < this.ListaDeAutos.Count; i++)
            {
                if (i == 0)
                {
                    menor = mayor = this.ListaDeAutos[1];
                    continue;
                }

                if (this.ListaDeAutos[i].ObtenerTiempo() < menor.ObtenerTiempo())
                    menor = this.ListaDeAutos[i];
                if (this.ListaDeAutos[i].ObtenerTiempo() > mayor.ObtenerTiempo())
                    mayor = this.ListaDeAutos[i];

            }


            /* DEPRETICATED por colecciones
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
             */

          Console.WriteLine("El que más tarde fue un {0} y el tiempo fue {1}", mayor.Fabricante, (int)mayor.ObtenerTiempo());
          Console.WriteLine("El que menos tarde fue un {0} y el tiempo fue {1}", menor.Fabricante, (int)menor.ObtenerTiempo());


          /* DEPRETICATED por colecciones
               this.auto1.VolverACero();
               this.auto2.VolverACero();
               this.auto3.VolverACero();
               this.auto4.VolverACero();
               this.auto5.VolverACero();
               this.auto6.VolverACero();*/
            foreach (Auto item in this.ListaDeAutos)
            {
                item.VolverACero();
                
            }
              
     }

     #endregion 
        
     public string  MostrarCarrera()
     {
         /* DEPRETICATED por colecciones
                this.auto1.MostrarAuto();
                this.auto2.MostrarAuto();
                this.auto3.MostrarAuto();
                this.auto4.MostrarAuto();
                this.auto5.MostrarAuto();
                this.auto6.MostrarAuto();
                 * */
         StringBuilder sb= new StringBuilder();
         sb.AppendLine("Carrera ");

            foreach (Auto auto in this.ListaDeAutos)
            {
                sb.AppendLine(auto.retornarString());
                //auto.MostrarAuto();
            }

            return sb.ToString();


        }

    

        #region constructores


        static Carrera()
        {
            numeroRandom = new Random();

        }

        public Carrera(string lugar, string fecha,string nombre)
        {
            this.fecha = fecha;
            this.nombre = nombre;
            this.lugar = lugar;
            /* depreticated por colecciones
            this.auto1 = new Auto();
            this.auto2 = new Auto();
            this.auto3 = new Auto();
            this.auto4 = new Auto();
            this.auto5 = new Auto();
            this.auto6 = new Auto();*/
            this.ListaDeAutos = new List<Auto>();
            //numeroRandom = new Random();
        }


        #endregion

        #region colecciones


        private bool agregarAuto(Auto unAuto)
        {
            this.ListaDeAutos.Add(unAuto);
            
            return true;
        }

        public static Carrera operator +(Carrera carrera, Auto auto)
        {
            carrera.agregarAuto(auto);
            return carrera;
        }



        #endregion



    }
}
