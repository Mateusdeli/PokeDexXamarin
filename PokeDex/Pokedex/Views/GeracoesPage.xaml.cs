using Pokedex.Models;
using Pokedex.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeracoesPage : ContentPage
    {
        PokemonGeracaoListService _pokemonGeracaoListService = new PokemonGeracaoListService();
        public GeracoesPage()
        {
            InitializeComponent();
            IconImageSource = ImageSource.FromResource("Pokedex.imagesTab.pokemonTabble.png");
            lvwGeracoes.ItemsSource = _pokemonGeracaoListService.ListaGeracaoPokemons;
        }
       
        private async void lvwPokemons_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selected = e.SelectedItem as PokemonGeracaoModel;
            var pokemonPage = new PokemonPage(selected);
            pokemonPage.Title = selected.NomeGeracao;
            await Navigation.PushAsync(pokemonPage);
            
        }
    }
}