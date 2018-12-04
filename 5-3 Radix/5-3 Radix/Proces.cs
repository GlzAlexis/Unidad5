using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_Radix
{
    class Proces
    {
        public void Ordenar(int[] tamaño)
        {
            RadixSort(ref tamaño);
            List<int> negativos = new List<int>(); // Esta es la lista de numeros negativos ordenados
            List<int> arreglo = new List<int>();   // Esta es la lista de numeros negativos ordenados
            foreach (var item in tamaño)
            {
                if (item < 0) { negativos.Add(item); }  // Si el numero es menor que 0 es agregado a la lista de numeros negativos
                else arreglo.Add(item);                 // De lo contrario es agregado a a la lista normal
            }
            foreach (var item in negativos) { Console.Write(item + " "); }   // Se imprime el arreglo ordenado
            foreach (var item in arreglo) { Console.Write(item + " "); }
        }
        private void RadixSort (ref int[] a)
        {
            int[] tamaño = new int[a.Length];
            int b = 4, c = 32;                             // Este es el tamaño en bits del grupo
            int[] contar = new int[1 << b];
            int[] dimen = new int[1 << b];
            int grupos = (int)Math.Ceiling(c / (double)b); // Es el numero de grupos
            int mascara = (1 << b) - 1;                    // Es la mascara para la identificacion de los grupos
            for (int i = 0, j = 0; i < grupos; i++, j+=b)  // Este es el algoritmo que se utilizara
            {
                for(int e = 0; e < contar.Length; e++) { contar[e] = 0; }
                for(int e = 0; e < a.Length; e++) { contar[(a[e] >> j) & mascara]++; }
                dimen[0] = 0;
                for(int e = 1; e < contar.Length; e++) { dimen[e] = dimen[e - 1] + contar[e - 1]; }
                for(int e = 0; e < a.Length; e++) { tamaño[dimen[(a[e] >> j) & mascara]++] = a[e]; }
                tamaño.CopyTo(a, 0);
            }
        }
    }
}
