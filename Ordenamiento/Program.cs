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
            //Lo que hace esta funcion es acomodar los elementos de menor a mayor
            //Comparando pares de datos SIN llegar hasta el ultimo indice del arreglo
            //En este caso el metodo "Ordenar" utiliza los indices como anclas para comparar los datos dentro del indice.
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
