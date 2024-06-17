using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceptos.POO
{
    public class Andina: Beer
    {
        public string Color { get; set; }
        public Andina() { }
        public Andina(string color, int alcohol, int balance, int cebada, int levadura) 
            : base (alcohol, balance, cebada, levadura)
        {
            Color = color;
        }
        public override string Marca() => $"Andina {Color}";
        

        public string DrinkBeer()
        {
            return $"{Marca()}, Caracteristicas: \n {base.DrinkBeer()}";
        }
    }
}
