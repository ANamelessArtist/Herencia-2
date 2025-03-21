using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2
{
    internal class BaseVehiculo
    {
        public BaseVehiculo() { }
        public BaseVehiculo(int id, string marca, string modelo, int año)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
    }
}
