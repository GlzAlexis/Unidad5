using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_Bubble_Sort
{
    class Proceso
    {
        public void Bulbasaur(int[] valor)                                   //Metodo para el ordenamiento de los valores ingresados
        {
            Console.Write("Los valores ingresados son los siguientes: ");
            foreach(var despliegue in valor)                                 //Aqui se despliegan los valores ingresados con anterioridad
            {
                Console.Write("{0}  ", despliegue);
            }
            int temporal;
            for(int i = 0; i < valor.Length; i++)                            //Aqui se ordenan los valores
            {
                for (int j = 1; j < valor.Length; j++)     //Comparacion de los valores ingresados
                {
                    if(valor[j - 1] > valor[j])            //Si es que el valor es mayor que el actual pasa al siguiente
                    {
                        temporal = valor[j];               //Se guarda
                        valor[j] = valor[j - 1];           //Aqui se sustituye el anterior con el actual
                        valor[j - 1] = temporal;           //Y al anterior es asignado el actual
                    }
                }
            }
            Console.Write("\n\nLos valores ordenados son los siguientes: ");
            foreach(var despliegue in valor)                                   //Se despliegan los valores ya ordenados
            {
                Console.Write("{0}  ", despliegue);
            }
            Console.ReadKey();
        }
    }
}
