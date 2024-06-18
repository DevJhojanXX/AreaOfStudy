using pokedesk_Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace pokedesk_Console.Core
{
    public class ShowPokemons
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private static readonly string url = "https://pokeapi.co/api/v2/pokemon";
        private string stringResponse; 
        public async Task<AllPokemons?> ShowAllPokemons(int limit)
        {
            HttpResponseMessage responsePokeApi = await httpClient.GetAsync($"{url}?limit={limit}");
            try
            {
                stringResponse = await responsePokeApi.Content.ReadAsStringAsync();
                AllPokemons? allPokemons = JsonSerializer.Deserialize<AllPokemons>(stringResponse);
                return allPokemons; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {responsePokeApi.StatusCode} y {ex.Message}");
                return null;
            }
        }
        public async Task<Pokemon?> ShowOnePokemon(string? name)
        {
            HttpResponseMessage responsePokemon = await httpClient.GetAsync($"{url}/{name}");
            try
            {
                stringResponse = await responsePokemon.Content.ReadAsStringAsync();
                Pokemon? pokemon = JsonSerializer.Deserialize<Pokemon>(stringResponse);
                return pokemon;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {responsePokemon.StatusCode} y {ex.Message}");
                return null;
            }
        }
    }
}
