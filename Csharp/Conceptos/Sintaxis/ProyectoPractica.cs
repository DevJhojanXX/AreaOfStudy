using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceptos.Sintaxis
{
    class ProyectoPractica
    {
       
        public void Calculardora()
        {
            int sw = 0;
            while(sw != 1)
            {
                Console.WriteLine("Operación: ");
                string op = Console.ReadLine();
                if (op == "Off") sw = 1; 
                Console.WriteLine("Ingresa el número 1: ");
                int num1 = Int16.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el número 2: ");
                int num2 = Int16.Parse(Console.ReadLine());
                Console.WriteLine(ResultOperation(num1, op, num2));
            }
        }
        public int ResultOperation(int num1, string op, int num2)
        {
            int result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "%":
                    result = num1 % num2;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }
    }
}
