using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceptos.Sintaxis
{
    internal class Loops
    {
        public Loops() 
        {
            //Loob / bucles
            ///
            /// Los bucles son ciclos que se repiten hasta cierto limite 
            /// o infinitamente si no se les declara el limite 
            ///

            /// 
            /// # For
            /// for( variable; condicional; incremento) { codigo }
            /// 

            Console.WriteLine("----------------");
            Console.WriteLine("Bucle For:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"[{i}]");
            }
            Console.WriteLine();
            Console.WriteLine("----------------");

            /// 
            /// #While / mientras
            /// while( condicion )  { codigo }
            ///
            Console.WriteLine("----------------");
            Console.WriteLine("Bucle While:");
            int j = 0;
            while (j < 5)
            {
                Console.Write($"[{j}]");
                j++;
            }
            Console.WriteLine();
            Console.WriteLine("----------------");
            ///
            /// #Do While
            /// do { codigo } while( condicion )
            ///
            Console.WriteLine("----------------");
            Console.WriteLine("Bucle Do While:");
            int x = 0;
            do
            {
                Console.Write($"[{x}]");
                x++;
            } while (x < 5);

            Console.WriteLine();
            Console.WriteLine("----------------");
            ///
            /// #foreach
            /// Es un iterador de arreglos y listas
            /// foreach( variable in arreglo ) 
            ///
            Console.WriteLine("----------------");
            Console.WriteLine("Bucle foreach:");
            string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
            foreach (string dia in dias)
            {
                Console.Write($"[{dia}]");
            }

            Console.WriteLine();
            Console.WriteLine("----------------");
        }
    }
}
