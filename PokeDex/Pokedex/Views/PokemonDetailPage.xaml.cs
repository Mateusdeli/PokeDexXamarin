using Pokedex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokedex.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokemonDetailPage : ContentPage
    {
        private bool _isShiny = false;
        public PokemonDetailPage(PokemonModel pokemonModel)
        {

            if (pokemonModel != null)
                BindingContext = pokemonModel;

            InitializeComponent();

            SetShiny(pokemonModel);

            txtNome.Text = $"Nome: {pokemonModel.name[0].ToString().ToUpper()}{pokemonModel.name.Substring(1)}";
            txtWeight.Text = $"Weight: {pokemonModel.weight.ToString()}";
            SetStatPokemon(pokemonModel);
            SetElementTypeImage(pokemonModel);
            

        }

        private void SetShiny(PokemonModel pokemonModel)
        {

            if (!_isShiny)
            {

                imagePokemon.Source = new UriImageSource
                    {
                        CachingEnabled = false,
                        Uri = new Uri(pokemonModel.sprites.front_default),
                    };

                SetPokemonNavigationBar(pokemonModel.sprites.front_default, $"{pokemonModel.name[0].ToString().ToUpper()}{pokemonModel.name.Substring(1)}");

                txtNome.Text = $"Nome: {pokemonModel.name[0].ToString().ToUpper()}{pokemonModel.name.Substring(1)}";
            }
            else
            {

                imagePokemon.Source = new UriImageSource
                {
                    CachingEnabled = false,
                    Uri = new Uri(pokemonModel.sprites.front_shiny),
                };

                SetPokemonNavigationBar(pokemonModel.sprites.front_shiny, $"Shiny {pokemonModel.name[0].ToString().ToUpper()}{pokemonModel.name.Substring(1)}");

                txtNome.Text = $"Nome: Shiny {pokemonModel.name[0].ToString().ToUpper()}{pokemonModel.name.Substring(1)}";
            }

            _isShiny = !_isShiny;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

            var image = sender as Image;
            var gesture = image.GestureRecognizers[0] as TapGestureRecognizer;
            var pokemon = gesture.CommandParameter as PokemonModel;

            SetShiny(pokemon);
        }

        private void SetPokemonNavigationBar(string url, string nome)
        {
            NavigationPage.SetTitleIconImageSource(this, ImageSource.FromUri(new Uri(url)));
            Title = nome;
        }

        private void SetElementTypeImage(PokemonModel pokemonModel)
        {
            var random = new Random();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = pokemonModel.types[random.Next(0, pokemonModel.types.Count)].type.colorType;
            lvwElementPokemon.ItemsSource = pokemonModel.types;

        }

        private void SetStatPokemon(PokemonModel pokemonModel)
        {
            lvwStatsPokemon.ItemsSource = pokemonModel.stats;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#b81818");
        }

    }
}