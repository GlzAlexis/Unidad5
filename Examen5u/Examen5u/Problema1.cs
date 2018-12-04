using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen5u
{
    class Problema1
    {
        public void Bulbasaur(List<int> lista)                                   //Metodo para el ordenamiento de los valores ingresados
        {
            int[] valor = new int[lista.Count];
            for (int i = 0; i < lista.Count; i++) { valor[i] = lista.ElementAt(i); }
            Console.Clear();
            Console.Write("Los valores ingresados son los siguientes: ");
            foreach (var despliegue in valor)                                 //Aqui se despliegan los valores ingresados con anterioridad
            {
                Console.Write("{0}  ", despliegue);
            }
            int temporal;
            for (int i = 0; i < valor.Length; i++)                            //Aqui se ordenan los valores
            {
                for (int j = 1; j < valor.Length; j++)     //Comparacion de los valores ingresados
                {
                    if (valor[j - 1] > valor[j])            //Si es que el valor es mayor que el actual pasa al siguiente
                    {
                        temporal = valor[j];               //Se guarda
                        valor[j] = valor[j - 1];           //Aqui se sustituye el anterior con el actual
                        valor[j - 1] = temporal;           //Y al anterior es asignado el actual
                    }
                }
            }
            Console.Write("\n\nLos valores ordenados son los siguientes: ");
            foreach (var despliegue in valor)                                   //Se despliegan los valores ya ordenados
            {
                Console.Write("{0}  ", despliegue);
            }
            Console.ReadKey();
        }
        List<int> Datos = new List<int>();
        int valores;
        int opc= 1;
        string cadena = "";

        public void IngresarDatos()
        {                                           // En este metodo se despliegan las opciones y se ingresaran los valores que quiera
            bool salir = true;
            while (salir) 
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("        ~~~~~~~~~ Problema 1 ~~~~~~~~~");
                    Console.Write("Opciones: \n1.- Ingresar datos \n2.- Ordenar \n3.- Salir \n\nOpcion elegida: ");
                    opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            Console.Write("Ingrese el valor: ");
                            cadena = Console.ReadLine();
                            valores = Convert.ToInt32(cadena);
                            if (cadena.Contains("3") || cadena.Contains("4") || cadena.Contains("5") || cadena.Contains("6") || cadena.Contains("7") || cadena.Contains("8") || cadena.Contains("9"))
                            {
                                Console.WriteLine("Valor incorrecto");                   // Si la cadena contiene los valores anteriores saltara el siguiente mensaje
                                Console.ReadKey();                                       // De lo contrario se agregara
                            }
                            else
                                Datos.Add(valores);
                            break;
                        case 2:
                            Bulbasaur(Datos);
                            Datos.Clear();
                            break;
                        case 3:
                            salir = false;
                            Console.WriteLine("Bye");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Opcion incorrecta.");
                            Console.ReadKey();
                            break;
                    }
                }
                catch(Exception e) { Console.WriteLine(e.Message); Console.ReadKey(); }
            }


        }
    }
}
