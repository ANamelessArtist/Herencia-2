using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2
{
    class VehiculoCamion : BaseVehiculo
    {
        public VehiculoCamion() { }

        public int CapacidadCarga { get; set; }

        public VehiculoCamion(int id, string marca, string modelo, int año, int capacidadCarga)
            : base(id, marca, modelo, año)
        {
            CapacidadCarga = capacidadCarga;
        }
    }
}
