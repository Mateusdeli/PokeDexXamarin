using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Pokedex.Services
{


    public class TypeElementPokemonService
    {

        public static ImageSource ImageTypePokemon(string typeName)
        {
            switch (typeName)
            {
                case "normal":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/e/e6/NormalIC_Masters.png/64px-NormalIC_Masters.png"), CachingEnabled = false };
                case "water":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/3/3f/WaterIC_Masters.png/64px-WaterIC_Masters.png"), CachingEnabled = false };
                case "electric":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/1/1a/ElectricIC_Masters.png/64px-ElectricIC_Masters.png"), CachingEnabled = false };
                case "fighting":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/0/06/FightingIC_Masters.png/64px-FightingIC_Masters.png"), CachingEnabled = false };
                case "ground":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/7/74/GroundIC_Masters.png/64px-GroundIC_Masters.png"), CachingEnabled = false };
                case "psychic":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/9/99/PsychicIC_Masters.png/64px-PsychicIC_Masters.png"), CachingEnabled = false };
                case "rock":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/9/9e/RockIC_Masters.png/64px-RockIC_Masters.png"), CachingEnabled = false };
                case "dark":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/4/43/DarkIC_Masters.png/64px-DarkIC_Masters.png"), CachingEnabled = false };
                case "steel":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/3/39/SteelIC_Masters.png/64px-SteelIC_Masters.png"), CachingEnabled = false };
                case "fire":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/2/2e/FireIC_Masters.png/64px-FireIC_Masters.png"), CachingEnabled = false };
                case "grass":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/3/32/GrassIC_Masters.png/64px-GrassIC_Masters.png"), CachingEnabled = false };
                case "ice":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/9/9b/IceIC_Masters.png/64px-IceIC_Masters.png"), CachingEnabled = false };
                case "poison":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/f/f3/PoisonIC_Masters.png/64px-PoisonIC_Masters.png"), CachingEnabled = false };
                case "flying":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/2/2f/FlyingIC_Masters.png/64px-FlyingIC_Masters.png"), CachingEnabled = false };
                case "bug":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/8/82/BugIC_Masters.png/64px-BugIC_Masters.png"), CachingEnabled = false };
                case "ghost":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/6/68/GhostIC_Masters.png/64px-GhostIC_Masters.png"), CachingEnabled = false };
                case "dragon":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/d/d7/DragonIC_Masters.png/64px-DragonIC_Masters.png"), CachingEnabled = false };
                case "fairy":
                    return new UriImageSource() { Uri = new Uri("https://cdn.bulbagarden.net/upload/thumb/f/fa/FairyIC_Masters.png/64px-FairyIC_Masters.png"), CachingEnabled = false };
                default:
                    return "";
            }   
        }

        public static Color ColorTypePokemon(string typeName)
        {
            switch (typeName)
            {
                case "normal":
                    return Color.FromHex("#979693");
                case "water":
                    return Color.FromHex("#54b9e3"); 
                case "electric":
                    return Color.FromHex("#dcb602");
                case "fighting":
                    return Color.FromHex("#d87b47");
                case "ground":
                    return Color.FromHex("#9b5e3f");
                case "psychic":
                    return Color.FromHex("#e86e9b");
                case "rock":
                    return Color.FromHex("#a38e7a");
                case "dark":
                    return Color.FromHex("#545361");
                case "steel":
                    return Color.FromHex("#7e889b");
                case "fire":
                    return Color.FromHex("#dc4047");
                case "grass":
                    return Color.FromHex("#439f4d");
                case "ice":
                    return Color.FromHex("#6db6bb");
                case "poison":
                    return Color.FromHex("#83539b");
                case "flying":
                    return Color.FromHex("#5884f0");
                case "bug":
                    return Color.FromHex("#9fb659");
                case "ghost":
                    return Color.FromHex("#a3739b");
                case "dragon":
                    return Color.FromHex("#0786a3");
                case "fairy":
                    return Color.FromHex("#ef9cb7");
                default:
                    return Color.Black;
            }
        }


    }
}
