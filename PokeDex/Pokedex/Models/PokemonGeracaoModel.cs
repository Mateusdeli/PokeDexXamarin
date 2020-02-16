using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Pokedex.Models
{
    public class PokemonGeracaoModel
    {

        public string NomeGeracao { get; set; }
        public string ImagemGeracao { get; set; }
        public Color BackgroundColor { get; set; }
        public int PokemonMinimo { get; set; }
        public int PokemonMaximo { get; set; }

    }
}
