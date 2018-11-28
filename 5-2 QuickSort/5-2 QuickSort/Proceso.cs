using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_QuickSort
{
    class Proceso
    {
        public void QuickSort(double[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        public void QuickSort(double[] array, int inicio, int final)   // Metodo QuickSort
        {
            if (inicio >= final)                 // Si el numero de la izquierda es mayor igual a de la derecha se retorna el valor
            {
                return;
            }
            double numero = array[inicio];       //Se toma como numero el primer valor del arreglo
            int i = inicio;
            int j = final;
            while(i < j)                         // Si inicio es menor a final procede
            {
                while(i < j && array[j] >= numero) 
                {
                    j--;
                }                                     // Se hacen las evaluaciones para cambiar de posicion los valores
                array[i] = array[j];                  // Y asi ir ordenandolos
                while(i < j && array[i] < numero)
                {
                    i++;
                }
                array[j] = array[i];
            }
            array[i] = numero;
            QuickSort(array, inicio, i - 1);
            QuickSort(array, i + 1, final);
        }
        public void Ordenado(double[] arreglo, int n) //En este método se despliega el arreglo ordenado
        {
            Console.Write("\nArreglo ordenado:  ");
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arreglo[i] + ", ");
            }
            Console.WriteLine("\n\nPresione cualquier tecla para elegir otra opcion. Especifique tecla y no boton");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
