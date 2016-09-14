using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualRaceConsola
{
    public class Auto
    {
        // composicion: tiene otras clases dentro, como Rueda.
      
        private eFabricante _fabricante;

        public eFabricante Fabricante
        {
            set
            {
                if (value == eFabricante.Ford)
                {


                }
                else
                { 
                    this._fabricante = value; 
                
                }
               
            }
            get
            {

                return this._fabricante;
            }
        }


        public string NombrePiloto;
       
        public Rueda DI;
        public Rueda DD;
        public Rueda TI;
        public Rueda TD;
        private Kilometro KilometrosRecorridos;
        private Tiempo TiempoDemorado;
        public static int contadorDeObjetos;
        private static Random randomMarcas; // es unico para esta clase.




        public string datosEnString
        {
            get {
                return this.retornarStringParaListado();
            }
        
        }



        public Auto()
        {
            this.Fabricante = (eFabricante)(Auto.randomMarcas.Next(0, 3));
            this.DI = new Rueda();
            this.DD = new Rueda();
            this.TI = new Rueda();
            this.TD = new Rueda();
            this.KilometrosRecorridos = 0;
            this.TiempoDemorado =0;

            Auto.contadorDeObjetos++;
        }
        public Auto(string nombrePiloto,eFabricante fabricante):this()
        {
            this.NombrePiloto = nombrePiloto;
            this.Fabricante = fabricante;
        }

        // un constructor estatico no puede ser public. Se ejecuta en la primer llamada a la clase que haga
        // tiene que tener atributos estaticos
        // puedo hacerlo para inicializar variables estaticas, como contador de objetos creados
        // no se lo puede sobrecargar
        static Auto()
        {
            Auto.contadorDeObjetos = 0;
            Auto.randomMarcas = new Random();
        }

        public static bool CompararAuto(Auto auto1, Auto auto2)
        {
            if (auto1.Fabricante == auto2.Fabricante)
                return true;
            return false;
        }

        public void MostrarAuto()
        {
            Console.WriteLine("El fabricante es: " + this.Fabricante);
        }

        public string retornarString()
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Fabricante: "+this.Fabricante);
            sb.AppendLine("Kilometros: " + this.KilometrosRecorridos);
            sb.AppendLine("Tiempo: " + this.TiempoDemorado);



            return sb.ToString();
        
        }
        public string retornarStringParaListado()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("F:" + this.Fabricante +" - ");
            sb.AppendLine("P:" + this.NombrePiloto);     



            return sb.ToString();

        }

        public void VolverACero()
        {
           // this.kilometrosRecorridos;
        }

        public void AgregarKilometros(Kilometro kilometros)
        {
            //this.kilometrosRecorridos += kilometros;
        }

        public Kilometro ObtenerKilometros()
        {
            return this.KilometrosRecorridos;
        }
        public Tiempo ObtenerTiempo()
        {
            return this.TiempoDemorado;
        }

        /*
         * DEPRECATED: POR SOBRECARGA DE METODOS
        public void AgregarKilometro(int kilometros)
        {
            this.KilometrosRecorridos += kilometros;
        }

        public void AgregarTiempo(int tiempo)
        {
            this.TiempoDemorado += tiempo;
        }
        */




        public void Agregar(Tiempo tiempo)
        {
            this.TiempoDemorado = this.TiempoDemorado + tiempo;
        }

        public void Agregar(Kilometro kilometro)
        {
            this.KilometrosRecorridos = this.KilometrosRecorridos + kilometro;
        }




        #region ordenamiento

        public static int ordenarPorPilotoDesc(Auto auto1, Auto auto2)
        {
            return auto1.NombrePiloto.CompareTo(auto2.NombrePiloto);
        
        }
        public static int ordenarPorPilotoAsc(Auto auto1, Auto auto2)
        {
            return auto2.NombrePiloto.CompareTo(auto1.NombrePiloto);

        }
        public static int ordenarPorFabricanteDesc(Auto auto1, Auto auto2)
        {
            return auto1._fabricante.CompareTo(auto2._fabricante);

        }
        public static int ordenarPorFabricanteAsc(Auto auto1, Auto auto2)
        {
            return auto2._fabricante.CompareTo(auto1._fabricante);

        }

        #endregion
    }
}
