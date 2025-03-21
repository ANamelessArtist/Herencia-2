using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2
{
    internal class Acciones
    {
        Dictionary<int, VehiculoCoche> diccionarioCoche = new Dictionary<int, VehiculoCoche>();
        Dictionary<int, VehiculoCamion> diccionarioCamion = new Dictionary<int, VehiculoCamion>();
        VehiculoCamion a = new VehiculoCamion();
        VehiculoCoche b = new VehiculoCoche();

        public void AgregarCoche()
        {
            Console.WriteLine("Dame matricula: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame Id: ");
            b.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame marca: ");
            b.Marca = Console.ReadLine();
            Console.WriteLine("Dame modelo: ");
            b.Modelo = Console.ReadLine();
            Console.WriteLine("Dame año: ");
            b.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame numero de puertas: ");
            b.Puertas = Convert.ToInt32(Console.ReadLine());

            diccionarioCoche.Add(id, new VehiculoCoche(b.Id,b.Marca,b.Modelo,b.Año,b.Puertas));
        }
        public void AgregarCamion()
        {
            Console.WriteLine("Dame matricula: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame Id: ");
            a.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame marca: ");
            a.Marca = Console.ReadLine();
            Console.WriteLine("Dame modelo: ");
            a.Modelo = Console.ReadLine();
            Console.WriteLine("Dame año: ");
            a.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame numero de puertas: ");
            a.CapacidadCarga = Convert.ToInt32(Console.ReadLine());

            diccionarioCamion.Add(id, new VehiculoCamion(a.Id, a.Marca, a.Modelo, a.Año, a.CapacidadCarga));
        }
        public void MostrarVehiculos()
        {
            foreach (var a in diccionarioCamion)
            {
                Console.WriteLine($"MATRICULA: {a.Value}");
                Console.WriteLine($"ID: {a.Value.Id}");
                Console.WriteLine($"MARCA: {a.Value.Marca}");
                Console.WriteLine($"MODELO: {a.Value.Modelo}");
                Console.WriteLine($"AÑO: {a.Value.Año}");
                Console.WriteLine($"CAPACIDAD CARGA: {a.Value.CapacidadCarga}");
            }
            foreach (var b in diccionarioCoche)
            {
                Console.WriteLine($"MATRICULA: {b.Value}");
                Console.WriteLine($"ID: {b.Value.Id}");
                Console.WriteLine($"MARCA: {b.Value.Marca}");
                Console.WriteLine($"MODELO: {b.Value.Modelo}");
                Console.WriteLine($"AÑO: {b.Value.Año}");
                Console.WriteLine($"NUMERO DE PUERTAS: {b.Value.Puertas}");
            }

        }
        public void ActualizarCoche()
        {
            Console.WriteLine("Dame la matricula del coche qui quieres actualizar: ");
            int id = Convert.ToInt32( Console.ReadLine());
            var b = diccionarioCoche.FirstOrDefault(x => x.Value.Id == id);

            Console.WriteLine("Nueva id: ");
            b.Value.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nueva marca: ");
            b.Value.Marca = Console.ReadLine();
            Console.WriteLine("Nuevo modelo: ");
            b.Value.Modelo = Console.ReadLine();
            Console.WriteLine("Nuevo año: ");
            b.Value.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nueva cantidad de puertas: ");
            b.Value.Puertas = Convert.ToInt32(Console.ReadLine());
        }
        public void ActualizarCamion()
        {
            Console.WriteLine("Dame la matricula del coche qui quieres actualizar: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var a = diccionarioCamion.FirstOrDefault(x => x.Value.Id == id);

            Console.WriteLine("Nueva id: ");
            a.Value.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nueva marca: ");
            a.Value.Marca = Console.ReadLine();
            Console.WriteLine("Nuevo modelo: ");
            a.Value.Modelo = Console.ReadLine();
            Console.WriteLine("Nuevo año: ");
            a.Value.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nueva capacidad: ");
            a.Value.CapacidadCarga = Convert.ToInt32(Console.ReadLine());
        }
        public void EliminarVehiculos()
        {
            int id = Convert.ToInt32(Console.ReadLine());

            diccionarioCoche.Remove(id);
        }
        public void EliminarCamion()
        {
            int id = Convert.ToInt32(Console.ReadLine());

            diccionarioCamion.Remove(id);
        }
    }
}
