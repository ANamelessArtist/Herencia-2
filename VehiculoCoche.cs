using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2
{
    internal class VehiculoCoche : BaseVehiculo
    {
        public VehiculoCoche() { }

        public int Puertas { get; set; }

        public VehiculoCoche(int id, string marca, string modelo, int año, int puertas)
            : base(id, marca, modelo, año)
        {
            Puertas = puertas;
        }
    }
}
