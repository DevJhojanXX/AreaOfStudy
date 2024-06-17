using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceptos.Sintaxis
{
    internal class Variables
    {
        static void Varaibles()
        {

            // en el ID Vs solo es poner CW
            // las comillas simples son caracteres y las comillas dobles son son cadenas
            // Console.WriteLine("Hello world");
            // lg de tipado duro

            ///
            /// Variables
            /// 
            /// Tipo de datos: 
            /// int
            /// float
            /// decimal
            /// double
            /// string
            /// char 
            /// bool
            /// primero se pone el tipo de dato y luego nombre de la variable
            ///

            int myInteger = 20;
            float myFloat = 30;

            Console.WriteLine(myInteger);
            Console.WriteLine(myFloat);

            ///
            /// variable Var
            /// La variable var es una variable dinamica que da cualquier otro tipo de dato
            /// primero var, luego el nombre de la vairable y se inicializa para dectectar el tipo de dato
            ///

            var varInteger = 20;
            Console.WriteLine(varInteger);
        }
    }
}
