using Pokedex.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPokemon : ContentView
    {

        public SearchBar SearchBarText { get => searchBarPokemon; }

        public SearchPokemon()
        {
            InitializeComponent();
        }

        private async void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            try
            {
                var pokemon = await PokemonListService.GetPokemonByName(searchBarPokemon.Text.ToLower());
                await Navigation.PushAsync(new PokemonDetailPage(pokemon));
                searchBarPokemon.Text = "";
            }
            catch
            {
                await Navigation.PopToRootAsync();
            }
        }
    }
}