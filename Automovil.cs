using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfáz_Vehiculo_con_Subinterfaces
{
    public class Automovil : IVehiculoTerrestre
    {
        private int velocidad;
        private int marcha;

        public Automovil()
        {
            velocidad = 0;
            marcha = 1;
        }

        public void Acelerar()
        {
            velocidad += 10;
            Console.WriteLine("Automóvil acelerando.");
        }

        public void Frenar()
        {
            velocidad -= 5;
            if (velocidad < 0) velocidad = 0;
            Console.WriteLine("Automóvil frenando.");
        }

        public int ObtenerVelocidad() => velocidad;

        public void CambiarMarcha(int nuevaMarcha)
        {
            marcha = nuevaMarcha;
            Console.WriteLine($"Automóvil cambió a la marcha {marcha}.");
        }
    }
}