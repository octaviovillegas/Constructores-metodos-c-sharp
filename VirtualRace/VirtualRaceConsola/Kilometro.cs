using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualRaceConsola
{
    public class Kilometro
    {
        private int _cantidad;

        private Kilometro(int cantidad)
        {
            this._cantidad = cantidad;
        }

        public static Kilometro operator +(Kilometro kilometroAux, int valor)
        {
            kilometroAux._cantidad = kilometroAux._cantidad + valor;

            return kilometroAux;
        }

        public static Kilometro operator +(Kilometro kilometro1, Kilometro kilometro2)
        {
            return (kilometro1 + kilometro2._cantidad);
        }

        public static Kilometro operator -(Kilometro kilometroAux, int valor)
        {
            kilometroAux._cantidad = kilometroAux._cantidad - valor;

            return kilometroAux;
        }

        public static Kilometro operator -(Kilometro kilometro1, Kilometro kilometro2)
        {
            return (kilometro1 - kilometro2._cantidad);
        }

        public static bool operator ==(Kilometro kilometroAux, int valor)
        {
            return (kilometroAux._cantidad == valor);
        }

        public static bool operator ==(Kilometro kilometro1, Kilometro kilometro2)
        {
            return (kilometro1 == kilometro2._cantidad);
        }

        public static bool operator !=(Kilometro kilometroAux, int valor)
        {
            return !(kilometroAux == valor);
        }

        public static bool operator !=(Kilometro kilometro1, Kilometro kilometro2)
        {
            return !(kilometro1 == kilometro2);
        }

        public static implicit operator Kilometro(int numero)
        {
            return new Kilometro(numero);
        }

        public static explicit operator int(Kilometro kilometro)
        {
            return kilometro._cantidad;
        }
        public static bool operator <(Kilometro kilometro1, Kilometro kilometro2)
        {
            return (kilometro1._cantidad<  kilometro2._cantidad);
        }
        public static bool operator >(Kilometro kilometro1, Kilometro kilometro2)
        {
            return (kilometro1._cantidad > kilometro2._cantidad);
        }
    }
}
