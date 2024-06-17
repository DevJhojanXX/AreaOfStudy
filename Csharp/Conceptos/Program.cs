using Conceptos.POO;
using System; // importación

// clase
class Program
{
    // Comentarios de una sola linea
    /*
        comentario
        de varias
        lineas
     */

    ///
    /// Comentario para documentar codigo
    ///

    ///
    /// Metodos y modificadores de acceso
    ///
    static void Main(string[] args)
    {
        Andina andinaAzul = new Andina
        {
            Alcohol = 10,
            Cebada = 4,
            Color = "Azul",
            Balance = 5,
            Levadura = 1,
        };

        Console.WriteLine(andinaAzul.DrinkBeer());

        Andina andinaAmarilla = new Andina("Amarilla", 15, 7, 5, 2);
        Console.WriteLine(andinaAmarilla.DrinkBeer());
    }
}
