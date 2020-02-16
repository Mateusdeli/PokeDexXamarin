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
    public partial class HomePage : TabbedPage
    {
        private View _currentViewTitle = null;
        private SearchPokemon _searchPokemon = new SearchPokemon();
        private bool _viewTitle = false;
        public HomePage()
        {
            InitializeComponent();
            _currentViewTitle = NavigationPage.GetTitleView(this);
            imageNavigation.Source = ImageSource.FromResource("Pokedex.imagesTab.pokedexIcon.png");
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            if (!_viewTitle)
            {
                NavigationPage.SetTitleView(this, _searchPokemon);
                _searchPokemon.SearchBarText.Focus();
            }
            else
                NavigationPage.SetTitleView(this, _currentViewTitle);

            _viewTitle = !_viewTitle;
        }

    }
}