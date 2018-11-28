using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_QuickSort
{
    class Despliegue
    {
        public void Desplegar()
        {
            double[] a = { 11, 2, 3, 14, 18, 45, -3, -1, 6, 9 };                             // Se le asignan los valores a cada uno de los arrays
            double[] b = { 1, 3, 5, 7, 8, 3, 9, 0.7071, 16.5664, 12, 0, 10 };
            double[] c = { 3, 7, 15, 4 / 3, 155, 100, 15, 1.7320, 5, 2, 3, 2 };
            double[] d = { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };
            bool salir = true;
            while (salir)
            {
                try
                {
                    Console.Write("1.-   11, 2, 3, 14, 18, 45, -3, -1, 6, 9" +
                        "\n2.-   1, 3, 5, 7, 8, 3, 9, 0.7071, 16.5664, 12, 0, 10" +
                        "\n3.-   3, 7, 15, 4 / 3, 155, 100, 15, 1.7320, 5, 2, 3, 2" +
                        "\n4.-   8, 19, 7, 3, 15, 23, 34, 27, 89, 101" +
                        "\n\nTeclee el numero de la opcion que desee saber el ordenamiento: ");
                    int opc = Convert.ToInt32(Console.ReadLine());
                    if (opc == 1)
                    {
                        Proceso ordenara = new Proceso();                                        // Se instancia la clase
                        ordenara.QuickSort(a);                                                   // Y se mandan a llamar los metodos para realizar el ordenamiento
                        ordenara.Ordenado(a, a.Length);                                          // e impresion de los valores
                    }
                    else if (opc == 2)
                    {
                        Proceso ordenarb = new Proceso();
                        ordenarb.QuickSort(b);
                        ordenarb.Ordenado(b, b.Length);
                    }
                    else if (opc == 3)
                    {
                        Proceso ordenarc = new Proceso();
                        ordenarc.QuickSort(c);
                        ordenarc.Ordenado(c, c.Length);
                    }
                    else if (opc == 4)
                    {
                        Proceso ordenard = new Proceso();
                        ordenard.QuickSort(d);
                        ordenard.Ordenado(d, d.Length);
                    }
                    else if (opc == 5)
                    {
                        salir = false;
                        Console.WriteLine("\nGracias por utilizar mi bello y precioso programa \nHasta a proxima!!");
                        Console.ReadKey();
                    }
                    else
                    { Console.Write("\nLa opcion que introdujo es invalida \nPor favor introdusca una opcion que este dentro de nuetro menu"); Console.ReadKey(); Console.Clear(); }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); Console.ReadKey(); Console.Clear();
                }
            }
        }
    }
}
