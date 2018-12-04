using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen5u
{
    class Desplegar
    {
        public void desplegar()
        {
            bool salir = true;
            while (salir)
            {
                try
                {
                    Console.WriteLine("        ~~~~~~~~~ Examen ~~~~~~~~~");                         // Se crea un menu de las opciones del problea 1 y el problema 2 ya que mi numero de control termina en numero par
                    Console.Write("Las siguientes opciones son las siguientes:" +
                        "\n 1.- Problema 1" +
                        "\n 2.- Problema 2" +
                        "\n 3.- Salir del programa \n\n Teclee el numero de la opcion que desee: ");
                    int opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc)                                                                   // Opciones validas a elegir
                    {
                        case 1: Problema1 Bulbasaur = new Problema1(); Bulbasaur.IngresarDatos(); Console.Clear(); break;
                        case 2: Problema2 Radix = new Problema2(); Radix.Despliegue(); Console.Clear(); break;
                        case 3: salir = false; Console.WriteLine("Gracias por utilizar mi bello programa"); Console.ReadKey(); break;
                        default: Console.WriteLine("Esta opcion no se encuentra en el menu"); Console.ReadKey(); Console.Clear(); break; ;
                    }
                }
                catch(Exception e) { Console.WriteLine(e.Message); Console.ReadKey(); Console.Clear(); }
            }
        }
    }
}
