using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualRaceConsola
{
    public class Tiempo
    {

        private int _cantidad;

        private Tiempo(int cantidad)
        {
            this._cantidad = cantidad;
        }

        /*
        public static Tiempo Sumar(Tiempo tiempoAux, int valor)
        {
            tiempoAux.Cantidad = tiempoAux.Cantidad + valor;

            return tiempoAux;
        }
         */

        // sobrecargo el operador +
        public static Tiempo operator +(Tiempo tiempoAux, int valor)
        {
            tiempoAux._cantidad = tiempoAux._cantidad + valor;

            return tiempoAux;
        }

        public static Tiempo operator +(Tiempo tiempo1, Tiempo tiempo2)
        {
            return (tiempo1 + tiempo2._cantidad);
        }

        public static Tiempo operator -(Tiempo tiempoAux, int valor)
        {
            tiempoAux._cantidad = tiempoAux._cantidad - valor;

            return tiempoAux;
        }

        public static Tiempo operator -(Tiempo tiempo1, Tiempo tiempo2)
        {
            return (tiempo1 - tiempo2._cantidad);
        }

        public static bool operator ==(Tiempo tiempoAux, int valor)
        {
            return (tiempoAux._cantidad == valor);
        }

        public static bool operator ==(Tiempo tiempo1, Tiempo tiempo2)
        {
            return (tiempo1 == tiempo2._cantidad);
        }

        public static bool operator !=(Tiempo tiempoAux, int valor)
        {
            return !(tiempoAux == valor);
        }

        public static bool operator !=(Tiempo tiempo1, Tiempo tiempo2)
        {
            return !(tiempo1 == tiempo2);
        }

        public static implicit operator Tiempo(int numero)
        {
            return new Tiempo(numero);
        }

        public static explicit operator int(Tiempo tiempo)
        {
            return tiempo._cantidad;
        }



        public static bool operator <(Tiempo tiempoUno, Tiempo tiempoDos)
        {
            return (tiempoUno._cantidad < tiempoDos._cantidad);
        }
        public static bool operator >(Tiempo tiempoUno, Tiempo tiempoDos)
        {
            return (tiempoUno._cantidad > tiempoDos._cantidad);
        }

    }
}
