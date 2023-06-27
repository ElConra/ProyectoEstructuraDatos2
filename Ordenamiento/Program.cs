using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arreglo ordenamiento = new Arreglo(6);
            ordenamiento.Agregar(5);
            ordenamiento.Agregar(1);
            ordenamiento.Agregar(3);
            ordenamiento.Agregar(8);
            ordenamiento.Agregar(10);
            ordenamiento.Agregar(0);
            Console.WriteLine("Arreglo sin ordenar");
            ordenamiento.Imprimir();
            Console.WriteLine("Arreglo ordenado");
            ordenamiento.Ordenar();
            ordenamiento.Imprimir();



            Console.ReadKey();

        }
    }
}
