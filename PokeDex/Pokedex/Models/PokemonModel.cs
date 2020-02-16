using Pokedex.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Pokedex.Models
{

    public class PokemonModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public Sprites sprites { get; set; }
        public List<TypeElement> types { get; set; }
        public List<Stat> stats { get; set; }
        public int weight { get; set; }
    }




    public class Sprites
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class TypeElement2
    {
        public string name { get; set; }
        public ImageSource imageType { get => TypeElementPokemonService.ImageTypePokemon(name); }
        public Color colorType { get => TypeElementPokemonService.ColorTypePokemon(name); }
        public string url { get; set; }
    }

    public class TypeElement
    {
        public int slot { get; set; }
        public TypeElement2 type { get; set; }
    }

    public class Stat2
    {
        private string name;

        public string Name
        {
            get { return name.Replace("-", " "); }
            set { name = value; }
        }

        public string url { get; set; }
    }

    public class Stat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat2 stat { get; set; }
    }

}
