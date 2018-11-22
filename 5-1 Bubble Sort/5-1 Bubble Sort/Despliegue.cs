using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_Bubble_Sort
{
    class Despliegue
    {
        public void Ingreso()
        {
            int elemento;
            int[] valor;                                //Se pide que se ingreses el numero de elementos
            Console.Write("Ingrese el numero de elementos: "); elemento = Convert.ToInt32(Console.ReadLine());
            valor = new int[elemento];
            Console.Write("\nIngrese los valores: \n");

            for (int i = 0; i < elemento; i++)          //Aqui se pide el valor de cada elemento
            {
                Console.Write("{0}.-- ", (i + 1)); valor[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            Proceso proceso = new Proceso();             //Se manda a llamar para comenzar el ordenamiento de los valores
            proceso.Bulbasaur(valor);
        }
    }
}
