using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using pokedesk_Console.Models;
using pokedesk_Console.Core;
class Program
{
    static async Task Main(string[] args)
    {
        ShowPokemons? show = new ShowPokemons();
        AllPokemons? allPokemons = await show.ShowAllPokemons(1400);
        foreach (Result? result in allPokemons.results)
        {
            Pokemon? pokemon = await show.ShowOnePokemon(result.name);
            Console.Write($"{result?.name?.ToUpper()} || ");
            foreach(Ability? ability in pokemon?.abilities)
            {
                Console.Write($"<{ability.ability.name}> || ");
            }
            Console.WriteLine("\n");
        }
    }
}
