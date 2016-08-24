using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualRaceConsola
{
    public class Auto
    {
        private eFabricante fabricante;
        public Rueda ruedaDI;
        public Rueda ruedaDD;
        public Rueda ruedaTI;
        public Rueda ruedaTD;
        private int kilometrosRecorridos;
        private int tiempoDemorado;
        public static int contadorDeObjetos;
        private static Random random;


        public static bool CompararAuto(Auto auto1, Auto auto2)
        {
            if (auto1.fabricante == auto2.fabricante)
                return true;
            return false;
        }

        public void MostrarAuto()
        {
            Console.WriteLine("El fabricante es: " + this.fabricante);
        }

        public void VolverACero()
        {
            this.kilometrosRecorridos = 0;
        }

        public void AgregarTiempo(int tiempo)
        {
            this.tiempoDemorado += tiempo;
        }

        public void AgregarKilometros(int kilometros)
        {
            this.kilometrosRecorridos += kilometros;
        }

        public int GetKms()
        {
            return this.kilometrosRecorridos;
        }



        public Auto()
        {

            this.fabricante = (eFabricante)Auto.random.Next(0, 3);
            this.ruedaDD = new Rueda();
            this.ruedaDI = new Rueda();
            this.ruedaTD = new Rueda();
            this.ruedaTI = new Rueda();
            Auto.contadorDeObjetos++;
        }

        static Auto()
        {
            Auto.contadorDeObjetos = 0;
            Auto.random = new Random();
        }
    }
}
