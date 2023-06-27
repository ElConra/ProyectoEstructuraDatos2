using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Listas ListaLigadaA = new Listas("A");
            ListaLigadaA.Agregar("F");
            ListaLigadaA.Agregar("E");
            ListaLigadaA.Recorrer();
            
            Listas ListaLigadaB = new Listas("F");
            ListaLigadaB.Agregar("E");
            ListaLigadaB.Agregar("C");
            ListaLigadaB.Agregar("G");
            ListaLigadaB.Recorrer();
            
            Listas ListaLigadaC = new Listas("G");
            ListaLigadaC.Agregar("A");
            ListaLigadaC.Agregar("C");
            ListaLigadaC.Agregar("D");
            ListaLigadaC.Recorrer();
            
            List<Listas> Grafo = new List<Listas>();
            Grafo.Add(ListaLigadaA);
            Grafo.Add(ListaLigadaB);
            Grafo.Add(ListaLigadaC);



            Console.ReadKey();
        }

    }
}
