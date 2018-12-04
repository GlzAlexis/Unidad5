using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_Radix
{
    class Desplegar
    {
        public void Despliegue()
        {
            int opc = 0;
            bool salir = true;
            int[] a = new int[10] { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 };        // Se le asignan a los arreglos los valores predeterminados
            int[] b = new int[9] { 8, 3, 9, 3, 11, 7, 1, 27, 12 };
            int[] c = new int[8] { 10, 40, 36, 5, 24, 2, 5, 8 };
            int[] d = new int[9] { 55, 42, 0, -3, 0, -1, 2, 4, 7 };
            int[] e = new int[7] { 25, 108, 1024, 12, 351, 251, 39 };
            while (salir)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("                ~~~~~~~ Radix ~~~~~~~");  // Este es el menu que se desplegara
                    Console.Write("\n Series de numeros para ordenar:" +
                        "\n1.-  3, 6, 9, 5, 1, 4, 7, 2, 1, 3" +
                        "\n2.-  8, 3, 9, 3, 11, 7, 1, 27, 12" +
                        "\n3.-  10, 40, 36, 5, 24, 2, 5, 8" +
                        "\n4.-  55, 42, 0, -3, 0, -1, 2, 4, 7" +
                        "\n5.-  25, 108, 1024, 12, 351, 251, 39 " +
                        "\n6.-  Salir del programa" +
                        "\n\n Teclee el numero de la opcion que desea acceder: "); opc = Convert.ToInt32(Console.ReadLine());
                    Proces proceso = new Proces();        // Se instancia la clase
                    switch (opc)                                                                        // Opciones que se tendran como validas
                    {
                        case 1: Console.Write("\n "); proceso.Ordenar(a); Console.ReadKey(); break;     // Se manda a llamar al metodo
                        case 2: Console.Write("\n "); proceso.Ordenar(b); Console.ReadKey(); break;
                        case 3: Console.Write("\n "); proceso.Ordenar(c); Console.ReadKey(); break;
                        case 4: Console.Write("\n "); proceso.Ordenar(d); Console.ReadKey(); break;
                        case 5: Console.Write("\n "); proceso.Ordenar(e); Console.ReadKey(); break;
                        case 6: salir = false;  Console.WriteLine("\n Gracias por utilizar este bello y precioso programa"); Console.ReadKey(); break;
                        default: Console.WriteLine("\nEsta opcion no es valida \nPor favor introdusca una opcion que este dentro del menu"); Console.ReadKey(); Console.Clear(); break;

                    }
                }
                catch(Exception k) { Console.WriteLine(k.Message); Console.ReadKey(); Console.Clear(); }
            }
        }
    }
}
