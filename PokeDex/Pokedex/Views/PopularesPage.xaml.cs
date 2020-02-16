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
    public partial class PopularesPage : ContentPage
    {

        private View _currentNavigationView = null;

        public PopularesPage()
        {
            InitializeComponent();
            _currentNavigationView = NavigationPage.GetTitleView(this);
            IconImageSource = ImageSource.FromResource("Pokedex.imagesTab.promocaoTabble.png");
            SetPokemonPopularesList();
        }


        private async void SetPokemonPopularesList()
        {
            try
            {
                lvwPokemonFavoritos.ItemsSource = await PokemonListService.GetPokemonPopulares();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro ao carregar pokemons", ex.Message, "OK");
                PokemonListService.ClearListPokemon();
                await Navigation.PopAsync();
            }
        }

        private async void lvwPokemonFavoritos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var pokemon = e.Item as PokemonModel;
            await Navigation.PushModalAsync(new PokemonDetailPage(pokemon));
        }


        private void lvwPokemonFavoritos_Refreshing_1(object sender, EventArgs e)
        {
            SetPokemonPopularesList();
            lvwPokemonFavoritos.EndRefresh();
        }
       
    }
}