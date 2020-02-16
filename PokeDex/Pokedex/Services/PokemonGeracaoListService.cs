using Pokedex.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Pokedex.Services
{
    public class PokemonGeracaoListService
    {
        public IEnumerable<PokemonGeracaoModel> ListaGeracaoPokemons { get; private set; }
        public PokemonGeracaoListService()
        {
            ListaGeracaoPokemons = ListaGeracoes();
        }

        private IEnumerable<PokemonGeracaoModel> ListaGeracoes()
        {
            return new List<PokemonGeracaoModel>
            {
                new PokemonGeracaoModel
                {
                    NomeGeracao = "Primeira Geração",
                    ImagemGeracao = "https://vignette.wikia.nocookie.net/pkmnshuffle/images/f/ff/Mega_Charizard_Y.png/revision/latest?cb=20170409222125",
                    BackgroundColor = Color.WhiteSmoke,
                    PokemonMinimo = 1,
                    PokemonMaximo = 1
                },
                new PokemonGeracaoModel
                {
                    NomeGeracao = "Segunda Geração",
                    ImagemGeracao = "https://vignette.wikia.nocookie.net/pkmnshuffle/images/2/2a/Steelix.png/revision/latest/scale-to-width-down/128?cb=20170407222929",
                    BackgroundColor = Color.WhiteSmoke,
                    PokemonMinimo = 152,
                    PokemonMaximo = 251
                },
                new PokemonGeracaoModel
                {
                    NomeGeracao = "Terceira Geração",
                    ImagemGeracao = "https://vignette.wikia.nocookie.net/pkmnshuffle/images/2/28/Gardevoir.png/revision/latest/scale-to-width-down/128?cb=20170407224428",
                    BackgroundColor = Color.WhiteSmoke,
                    PokemonMinimo = 252,
                    PokemonMaximo = 386
                },
                 new PokemonGeracaoModel
                {
                    NomeGeracao = "Quarta Geração",
                    ImagemGeracao = "https://vignette.wikia.nocookie.net/pkmnshuffle/images/5/5d/Budew.png/revision/latest/scale-to-width-down/128?cb=20170409015936",
                    BackgroundColor = Color.WhiteSmoke,
                    PokemonMinimo = 387,
                    PokemonMaximo = 493
                },
                  new PokemonGeracaoModel
                {
                    NomeGeracao = "Quinta Geração",
                    ImagemGeracao = "https://vignette.wikia.nocookie.net/pkmnshuffle/images/a/ae/Genesect.png/revision/latest/scale-to-width-down/128?cb=20170409032045",
                    BackgroundColor = Color.WhiteSmoke,
                    PokemonMinimo = 494,
                    PokemonMaximo = 649
                },
                   new PokemonGeracaoModel
                {
                    NomeGeracao = "Sexta Geração",
                    ImagemGeracao = "https://vignette.wikia.nocookie.net/pkmnshuffle/images/8/8b/Volcanion.png/revision/latest/scale-to-width-down/128?cb=20170409064725",
                    BackgroundColor = Color.WhiteSmoke,
                    PokemonMinimo = 650,
                    PokemonMaximo = 721
                }
            };
        }

    }
}
