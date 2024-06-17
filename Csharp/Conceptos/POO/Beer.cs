using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceptos.POO
{
    public class Beer
    {
        //private int _Alcohol { get; set; }
        //private int _Balance { get; set; }
        //private int _Cebada { get; set; }
        //private int _Levadura { get; set; }
        public int Alcohol { get; set; }
        public int Balance { get; set; }
        public int Cebada { get; set; }
        public int Levadura { get; set; }
 
        public Beer() { }
        public Beer( int alcohol, int balance, int cebada, int levadura)
        {
            Alcohol = alcohol;
            Balance = balance;
            Cebada = cebada;
            Levadura = levadura;
        }

        public virtual string Marca() => "No hay marca registrada";

        public string DrinkBeer()
        {
            return $"Alcohol= {Alcohol}°, Balance = {Balance} nw, Cebada = {Cebada} gr, Levadura = {Levadura} gr";
        }
    }
}
