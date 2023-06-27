using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento
{
    internal class Arreglo
    {
        int indice;
        private int[] array;
        private int max;
        private int tope;
        public Arreglo(int tamano)
        {
            array = new int[tamano];
            tope = 0;
            max = array.Length - 1;
        }

        private bool ValidaVacio()
        {
            return (tope < 1);
        }
        private bool ValidaLleno()
        {
            return (tope > max);
        }
        public void Agregar(int elemento)
        {
            try
            {
                if (ValidaLleno())
                {
                    throw new Exception("El arreglo esta lleno.");
                }
                array[tope] = elemento;
                tope++;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        public void Imprimir()
        {
            try
            {
                if (ValidaVacio())
                {
                    throw new Exception("Esta Vacio");
                }
                for (int i = 0; i <= max; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void Ordenar()
        {
            for (int x = 0; x < array.Length; x++)
            {

                for (int indiceActual = 0; indiceActual < array.Length - 1;
                     indiceActual++)
                {
                    int indiceSiguienteElemento = indiceActual + 1;

                    if (array[indiceActual] > array[indiceSiguienteElemento])
                    {
                        int temporal = array[indiceActual];
                        array[indiceActual] = array[indiceSiguienteElemento];
                        array[indiceSiguienteElemento] = temporal;
                    }
                }
            }
        }
    }
}
