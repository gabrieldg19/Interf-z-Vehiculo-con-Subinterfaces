using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfáz_Vehiculo_con_Subinterfaces
{
    public interface IVehiculo
    {
        void Acelerar();
        void Frenar();
        int ObtenerVelocidad();
    }

    // Subinterfaz IVehiculoTerrestre
    public interface IVehiculoTerrestre : IVehiculo
    {
        void CambiarMarcha(int marcha);
    }

    // Subinterfaz IVehiculoAereo
    public interface IVehiculoAereo : IVehiculo
    {
        void Despegar();
        void Aterrizar();
    }
}