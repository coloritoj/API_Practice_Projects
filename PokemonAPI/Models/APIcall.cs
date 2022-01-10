using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokemonAPI.Models
{
    public class APIcall
    {
        private static HttpClient _realClient = null;

        public static HttpClient MyPokemonClient
        {
            get
            {
                if (_realClient == null)
                {
                    _realClient = new HttpClient();
                    _realClient.BaseAddress = new Uri("https://pokeapi.co/");
                }
                return _realClient;
            }
        }

        public static async Task<Pokemon> GetPokemonInfo(string pokemon)
        {
            var connection = await MyPokemonClient.GetAsync($"api/v2/pokemon/{pokemon.ToLower()}");
            Pokemon myPokemon = await connection.Content.ReadAsAsync<Pokemon>();
            return myPokemon;
        }
    }
}
