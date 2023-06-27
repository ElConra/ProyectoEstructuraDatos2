using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    public class Arreglo
    {
        Nodo nodoInicial;
        int indice;
        private string[] array;
        public Arreglo(int tamano)
        {
            nodoInicial = new Nodo();
            array = new string[tamano];
            for (int i = 0; i < tamano; i++)
            {
                array[i] = Recorrer();
            }
            
            
        }

        public void AgregarValor(string valor)
        {

                Nodo nodoActual = nodoInicial;
                while (nodoActual.Siguiente != null)
                {
                    nodoActual = nodoActual.Siguiente;
                }
                Nodo nodoNuevo = new Nodo(valor);
            if (ObtenerPosicion(nodoNuevo.Valor) == ObtenerPosicion(nodoActual.Valor))
            {
                nodoActual.Siguiente = nodoNuevo;
                nodoNuevo.Valor = valor;
            }
            else
            {
                nodoNuevo = nodoInicial;
                nodoInicial.Valor = valor;
            }
            Agregar(valor);
        }

        public string Recorrer()
        {
            string datos = string.Empty;
            if (nodoInicial.Siguiente == null)
            {
                return nodoInicial.Valor;
            }
            else
            {
                Nodo nodoActual = nodoInicial;
                while (nodoActual.Siguiente != null)
                {
                    nodoActual = nodoActual.Siguiente;
                    datos += nodoActual.Valor;
                }
                return datos;
            }
        }
        private int ObtenerPosicion (string valor)
        {
            byte[] bytes = Encoding.ASCII.GetBytes (valor);
            foreach(var car in bytes)
            {
                int datos = (int) car;
                int mod = car % array.Length;
                return mod;
            }
            return 0;
        }

        private void Agregar(string valor)
        {
            int posicion = ObtenerPosicion(valor);
            array[posicion] = valor;
        }
         
        public void RecorrerArreglo()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Posición {i}: ");
                foreach (var item in array[i])
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }



    }


    
}
