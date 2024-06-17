using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceptos.POO
{
    public class Banco
    {
        private decimal _balance;

        public void Initial(decimal initial) => _balance = initial;

        public void AddBalance(decimal add) => _balance += add;

        public void WithdrawBalance(decimal withdraw, string code)
        {
            if (code == "90234532")
            {
                if (_balance < 0) Console.WriteLine("No hay balance en la cuenta");
                else if (_balance < withdraw) Console.WriteLine("El balance solicitado no se puede retirar");
                else _balance -= withdraw;
            }
            else
            {
                Console.WriteLine("Codigo de seguridad incorrecto");
            }
        }

        public decimal GetBalance(string user, string pass) {
            if (user == "pepita" && pass == "pepita123")return _balance; 
            else
            {
                Console.WriteLine("User o pass incorrectos");
                return 0; 
            }
        }
        
    }
}
