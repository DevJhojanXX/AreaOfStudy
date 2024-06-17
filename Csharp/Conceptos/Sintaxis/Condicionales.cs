

namespace Conceptos.Sintaxis
{
    internal class Condicionales
    {
        static  Condicionales()
        {

            ///
            /// condicionales
            /// funciona deacuerdo si un dato es verdadero o falso
            /// 
            /// Operadores condicionales
            /// == igual a que
            /// >= mayor igual a que
            /// <= menor igual a que
            /// > mayor a que
            /// < Menor // a que
            /// != Diferente a que o distinto de a que
            /// 
            /// Operadores logicos
            /// && si esto y esto funciona ejecutame el codigo
            ///  if a && b && c 
            ///      ejecutame este codigo 
            ///      
            /// || si esto o esto funciona ejecutame el codigo
            ///  if a || b || c
            ///    ejecutame este codigo 
            ///

            int a = 1;
            int b = 2;

            if (a == b) Console.WriteLine("a es el mismo de b");
            else if (a >= b) Console.WriteLine("a es mayor que b");
            else if (a <= b) Console.WriteLine("a es menor que b");
            else Console.WriteLine("Error en la matrix");

            ///
            /// El condicional switch
            /// Es un sistema de condicional dado por casos según el valor de una variable
            /// ejemplo:
            /// >> en caso de que el dia sea el número 2, entonces ese día es martes
            /// >> en caso de que el día sea el número 1, ese día es lunes
            /// >> en caso de que el día sea el número 12, ese día no existe
            ///

            int dia_semana = Int16.Parse(Console.ReadLine());
            Console.ReadLine();
            //TODO: beats de cada variable
            switch (dia_semana)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("ese dia no existe");
                    break;
            }
        }
    }
}
