using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arreglo Hash = new Arreglo(5);
            Hash.AgregarValor("HOLA");
            Hash.AgregarValor("IIII");
            Hash.AgregarValor("Nuevo");
            Hash.RecorrerArreglo();


            Console.ReadKey();
        }


       
    }
    
}
