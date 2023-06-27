using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    internal class Listas
    {
        Nodo nodoInicial;
        public Listas(string valor)
        {
            nodoInicial = new Nodo(valor);
        }


        public string Recorrer()
        {
            string datos = string.Empty;
            Nodo nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                datos += nodoActual.Valor + "\n";
            }
            return datos;
        }
        public void Agregar(string valor)
        {
            Nodo nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }
            Nodo nodoNuevo = new Nodo(valor);
            nodoActual.Siguiente = nodoNuevo;
        }


    }
}
