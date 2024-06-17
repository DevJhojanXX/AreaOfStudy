using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ConversorDivisasConsole.Conn;
using ConversorDivisasConsole.Core;
using ConversorDivisasConsole.Model;
namespace ApiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            CurrencyConverter currencyConverter = new CurrencyConverter();
            int sw = 0;
            string ApiKey = "ffcfcb0afd4c36587e0a6da3";

            while (sw != 1)
            {
                Console.WriteLine("Escribe la divisa actual: ");
                string currenDivise = Console.ReadLine();
                Console.WriteLine("Escribe la cantidad de dicha divisa: ");
                decimal amount = Decimal.Parse(Console.ReadLine());
                Console.WriteLine("Escribe la divisa a convertir: ");
                string convertDivise = Console.ReadLine();
                Console.WriteLine(currencyConverter.Converter(currenDivise.ToUpper(),convertDivise.ToUpper(),amount , ApiKey));
            }
            

        }
    }
}