using Pokedex.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Services
{
    public class PokemonListService
    {

        private static ObservableCollection<PokemonModel> _listaPokemons;
        private static ObservableCollection<PokemonModel> _listaPokemonsPopulares;
        private static PokemonJsonService _pokemonJsonService = new PokemonJsonService();

        public PokemonListService()
        {
            _listaPokemons = new ObservableCollection<PokemonModel>();
            _listaPokemonsPopulares = new ObservableCollection<PokemonModel>();
        }

        public static async Task<PokemonModel> GetPokemonByName(string pokemonName)
        {
            try
            {
                return await _pokemonJsonService.GetOnePokemon(pokemonName);
            }
            catch
            {
                throw new Exception("Sem conexão com a internet.");
            }
        }

        public async static Task<ObservableCollection<PokemonModel>> GetPokemonByIds(int idMinimo, int idMaximo)
        {
            try
            {
                if (_listaPokemons == null)
                    return _listaPokemons = await _pokemonJsonService.GetIdsPokemons(idMinimo, idMaximo);

                return _listaPokemons;
            }
            catch
            {
                throw new Exception("Sem conexão com a internet.");
            }
        }
        public async static Task<ObservableCollection<PokemonModel>> GetPokemonPopulares()
        {
            try
            {
                return _listaPokemonsPopulares = await _pokemonJsonService.GetPokemonPopulares();
            }
            catch
            {
                throw new Exception("Sem conexão com a internet.");
            }
        }


        public static void ClearListPokemon()
        {
            _listaPokemons = null;
        }

    }
}
