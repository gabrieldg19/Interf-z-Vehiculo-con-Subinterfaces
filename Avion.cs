using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfáz_Vehiculo_con_Subinterfaces
{
    public class Avion : IVehiculoAereo
    {
        private int velocidad;
        private bool enVuelo;

        public Avion()
        {
            velocidad = 0;
            enVuelo = false;
        }

        public void Acelerar()
        {
            velocidad += 50;
            Console.WriteLine("Avión acelerando.");
        }

        public void Frenar()
        {
            velocidad -= 30;
            if (velocidad < 0) velocidad = 0;
            Console.WriteLine("Avión frenando.");
        }

        public int ObtenerVelocidad() => velocidad;

        public void Despegar()
        {
            enVuelo = true;
            Console.WriteLine("El avión ha despegado.");
        }

        public void Aterrizar()
        {
            enVuelo = false;
            Console.WriteLine("El avión ha aterrizado.");
        }
    }
}