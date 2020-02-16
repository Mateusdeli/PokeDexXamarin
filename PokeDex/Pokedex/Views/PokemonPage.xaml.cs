using Pokedex.Models;
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
    public partial class PokemonPage : ContentPage
    {
        private View _currentPage;
        private PokemonGeracaoModel _pokemonGeracaoModel;
        private LoadingView _loading = new LoadingView();
        public PokemonPage(PokemonGeracaoModel pokemonGeracaoModel)
        {
            InitializeComponent();
            _pokemonGeracaoModel = pokemonGeracaoModel;
            _currentPage = Content;
            Content = _loading;
            SetItemSource(pokemonGeracaoModel.PokemonMinimo, pokemonGeracaoModel.PokemonMaximo);
            
        }

        private async Task SetItemSource(int PokemonMinimo, int PokemonMaximo)
        {
            try
            {
                lvwPokemons.ItemsSource = await PokemonListService.GetPokemonByIds(PokemonMinimo, PokemonMaximo);
                Content = _currentPage;
            }
            catch(Exception ex)
            {
                await DisplayAlert("Erro ao carregar pokemons", ex.Message, "OK");
                PokemonListService.ClearListPokemon();
                await Navigation.PopAsync();
            }
            
        }

        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();
            PokemonListService.ClearListPokemon();
            return false;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            PokemonListService.ClearListPokemon();
        }

        private async void lvwPokemons_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var listaPokemon = sender as ListView;
            var pokemon = listaPokemon.SelectedItem as PokemonModel;
            var pokemonDetail = new PokemonDetailPage(pokemon);
            pokemonDetail.Title = $"{pokemon.name[0].ToString().ToUpper()}{pokemon.name.Substring(1)}";
            await Navigation.PushAsync(pokemonDetail);

        }

        private async void lvwPokemons_Refreshing(object sender, EventArgs e)
        {

            PokemonListService.ClearListPokemon();
            await SetItemSource(_pokemonGeracaoModel.PokemonMinimo, _pokemonGeracaoModel.PokemonMaximo);
            lvwPokemons.EndRefresh();

        }
    }
}