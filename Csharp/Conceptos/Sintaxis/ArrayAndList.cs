using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceptos.Sintaxis
{
    internal class ArrayAndList
    {
        public ArrayAndList() 
        {


            ///
            /// Arreglos y listas 
            ///
            /// Son un conjunto de datos almacenados en una sola vairable
            /// La diferencia esta: en que los arreglos tienen un limite 
            /// y las listas no
            /// 
            /// #Arreglos
            /// tipo[] nombre_variable = new tipo[limite];
            /// tipo[] nombre_variable = { datos a almacenar };
            ///
            /// #Listas
            /// List<tipo> nombre_variable = new List<tipo>();
            ///

            int[] numbers = new int[5]; // 0 > limite ( 0, 1, 2, 3, 4)
            numbers[0] = 20;
            numbers[1] = 30;
            numbers[2] = 10;
            numbers[3] = 24;
            numbers[4] = 49;
            numbers[5] = 10; 
            // mas numeros que sobre pasen el limite da error de copilación 
            // TODO: imprimir el arreglo numbers con el bucle for 
            Console.WriteLine(numbers[0]);

            List<int> list = new List<int>();
            list.Add(12);
            list.Add(24);
            list.Add(20);
            Console.WriteLine(list); // no se muestra la lista
            Console.WriteLine(list[1]); // 12
            foreach (int i in list)
            {
                Console.WriteLine(i); // imprime todos los números de la lista
            }
        }
    }
}
