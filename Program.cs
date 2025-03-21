using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2
{
    internal class Program
    {
        public enum menu { Agregarcoche = 1, Agregarcamion, Mostrar, ActualizarCoche, ActualizarCamion, EliminarCoche, EliminarCamion}
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();

            while(true)
            {
                switch (Menu())
                {
                    case menu.Agregarcoche:
                        acciones.AgregarCoche();
                        break;
                    case menu.Agregarcamion:
                        acciones.AgregarCamion();
                        break;
                    case menu.Mostrar:
                        acciones.MostrarVehiculos();
                        break;
                    case menu.ActualizarCoche:
                        acciones.ActualizarCoche();
                        break;
                    case menu.ActualizarCamion:
                        acciones.ActualizarCamion();
                        break;
                    case menu.EliminarCoche:
                        acciones.EliminarVehiculos();
                        break;
                    case menu.EliminarCamion:
                        acciones.EliminarCamion();
                        break;
                }
            }
        }
        static menu Menu()
        {
            Console.WriteLine("1) Agregar coches");
            Console.WriteLine("2) Agregar camiones");
            Console.WriteLine("3) Mostrar vehiculos");
            Console.WriteLine("4) Actualizar coche");
            Console.WriteLine("5) Actualizar camion");
            Console.WriteLine("6) Eliminar coche");
            Console.WriteLine("7) Eliminar camion");
            menu opc = (menu) Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
