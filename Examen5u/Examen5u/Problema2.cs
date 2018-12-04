using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen5u
{
    class Problema2
    {
        public void Ordenar(int[] temporal)          // Este proceso los ordena y va desplegando todos y cada uno de los 80 numeros aleatorios
        {
            int contador = 1;
            RadixSort(ref temporal);
            foreach (var item in temporal) { Console.WriteLine(contador++ + ".- " + item); }
        }
        private void RadixSort(ref int[] a)
        {
            int[] tamaño = new int[a.Length];
            int b = 4, c = 32;                             // Este es el tamaño en bits del grupo
            int[] contar = new int[1 << b];
            int[] dimen = new int[1 << b];
            int grupos = (int)Math.Ceiling(c / (double)b); // Es el numero de grupos
            int mascara = (1 << b) - 1;                    // Es la mascara para la identificacion de los grupos
            for (int i = 0, j = 0; i < grupos; i++, j += b)  // Este es el algoritmo que se utilizara
            {
                for (int e = 0; e < contar.Length; e++) { contar[e] = 0; }
                for (int e = 0; e < a.Length; e++) { contar[(a[e] >> j) & mascara]++; }
                dimen[0] = 0;
                for (int e = 1; e < contar.Length; e++) { dimen[e] = dimen[e - 1] + contar[e - 1]; }
                for (int e = 0; e < a.Length; e++) { tamaño[dimen[(a[e] >> j) & mascara]++] = a[e]; }
                tamaño.CopyTo(a, 0);
            }
        }
        Random valor = new Random();
        public void aleatorio(ref int[] temporal)              // En este metodo se generaran numeros del 1 al 1000 sin repetirse
        {
            int contador1 = 0, contador2 = 0, contador3 = 0;
            for(contador3 = 0; contador3 < 80; contador3++)
            {
                temporal[contador3] = valor.Next(1, 1000);
                if (contador3 > 0)
                {
                    for (contador1 = 0; contador1 < 80; contador1++)
                    {
                        for (contador2 = 0; contador2 < contador3; contador2++)
                        {
                            if(temporal[contador3] == temporal[contador2]) { temporal[contador3] = valor.Next(1, 1000); }
                        }
                    }
                }
            }
        }
        public void Despliegue()           // Aqui se mandan a llamar a los metodos necesarios para la ejecucion de los mismos y el despligue de los numeros
        {
            Console.WriteLine("        ~~~~~~~~~ Problema 1 ~~~~~~~~\n");
            int[] valores = new int[80];
            aleatorio(ref valores);
            Ordenar(valores);
            Console.ReadKey();
        }
    }
}
