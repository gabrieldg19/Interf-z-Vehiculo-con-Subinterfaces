using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfáz_Vehiculo_con_Subinterfaces
{
    public static class MenuInteraccion
    {
        public static void IniciarMenu()
        {
            List<IVehiculo> vehiculos = new List<IVehiculo>
        {
            new Automovil(),
            new Avion()
        };

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Seleccione un vehículo para interactuar:");
                Console.WriteLine("1. Automóvil (Terrestre)");
                Console.WriteLine("2. Avión (Aéreo)");
                Console.WriteLine("3. Salir");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 3)
                {
                    salir = true;
                    Console.WriteLine("Saliendo del programa.");
                    continue;
                }

                IVehiculo vehiculoSeleccionado = vehiculos[opcion - 1];

                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Acelerar");
                Console.WriteLine("2. Frenar");
                Console.WriteLine("3. Mostrar velocidad");

                if (vehiculoSeleccionado is IVehiculoTerrestre)
                {
                    Console.WriteLine("4. Cambiar marcha");
                }
                else if (vehiculoSeleccionado is IVehiculoAereo)
                {
                    Console.WriteLine("4. Despegar");
                    Console.WriteLine("5. Aterrizar");
                }

                int accion = int.Parse(Console.ReadLine());

                switch (accion)
                {
                    case 1:
                        vehiculoSeleccionado.Acelerar();
                        break;
                    case 2:
                        vehiculoSeleccionado.Frenar();
                        break;
                    case 3:
                        Console.WriteLine($"Velocidad actual: {vehiculoSeleccionado.ObtenerVelocidad()} km/h");
                        break;
                    case 4:
                        if (vehiculoSeleccionado is IVehiculoTerrestre terrestre)
                        {
                            Console.WriteLine("Ingrese la nueva marcha:");
                            int marcha = int.Parse(Console.ReadLine());
                            terrestre.CambiarMarcha(marcha);
                        }
                        else if (vehiculoSeleccionado is IVehiculoAereo aereo)
                        {
                            aereo.Despegar();
                        }
                        break;
                    case 5:
                        if (vehiculoSeleccionado is IVehiculoAereo aereo2)
                        {
                            aereo2.Aterrizar();
                        }
                        break;
                }

                Console.WriteLine("\n");
            }
        }
    }
}