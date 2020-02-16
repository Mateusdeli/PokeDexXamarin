using Newtonsoft.Json;
using Pokedex.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pokedex.Services
{
    public class PokemonJsonService
    {
        private readonly string baseUri = "https://pokeapi.co/api/v2/pokemon/";
        public async Task<PokemonModel> GetOnePokemon(string pokemonName)
        {
            using (var http = new HttpClient())
            {
                PokemonModel pokemon = null;
                var url = $"{baseUri}{pokemonName}";
                http.BaseAddress = new Uri(url);

                if (http.BaseAddress == null)
                    throw new Exception("Sem conexão com a internet.");

                var resultGet = await http.GetAsync(url);

                if (resultGet.IsSuccessStatusCode)
                {
                    pokemon = JsonConvert.DeserializeObject<PokemonModel>(await resultGet.Content.ReadAsStringAsync());
                    
                }

                return pokemon;
            }
        }

        public async Task<ObservableCollection<PokemonModel>> GetIdsPokemons(int idMinimo, int idMaximo)
        {

            ObservableCollection<PokemonModel> pokemons = new ObservableCollection<PokemonModel>();

            for (int i = idMinimo; i <= idMaximo; i++)
            {
                using (var http = new HttpClient())
                {
                        var url = $"{baseUri}{i}";
                        http.BaseAddress = new Uri(url);

                        if (http.BaseAddress == null)
                            throw new Exception("Sem conexão com a internet.");
                    
                        var resultGet = await http.GetAsync(url);

                        if (resultGet.IsSuccessStatusCode)
                        {
                            var pokemon = JsonConvert.DeserializeObject<PokemonModel>(await resultGet.Content.ReadAsStringAsync());
                            pokemons.Add(pokemon);
                        }
                }
            }

            return pokemons;

        }

        public async Task<ObservableCollection<PokemonModel>> GetPokemonPopulares()
        {

            ObservableCollection<PokemonModel> pokemons = new ObservableCollection<PokemonModel>();
            var random = new Random();

            for (int i = 0; i < 3; i++)
            {
                using (var http = new HttpClient())
                {
                    var url = $"{baseUri}{random.Next(1, 964).ToString()}";
                    http.BaseAddress = new Uri(url);

                    if (http.BaseAddress == null)
                        throw new Exception("Sem conexão com a internet.");

                    var resultGet = await http.GetAsync(url);

                    if (resultGet.IsSuccessStatusCode)
                    {
                        var pokemon = JsonConvert.DeserializeObject<PokemonModel>(await resultGet.Content.ReadAsStringAsync());
                        pokemons.Add(pokemon);
                    }
                }
            }

            return pokemons;

        }

    }
}
