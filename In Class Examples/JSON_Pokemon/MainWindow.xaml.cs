using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JSON_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string webService = @"https://pokeapi.co/api/v2/pokemon?limit=1100&offset=0";

            Pokemon characters;

            using (var client = new HttpClient())
            {
                var results = client.GetStringAsync(webService).Result;

                characters = JsonConvert.DeserializeObject<Pokemon>(results);
            }

            foreach (var character in characters.results)
            {
                cboPokemon.Items.Add(character);
            }
        }

        private void cboPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var character = (Pokemons)cboPokemon.SelectedItem;

            string newWebService = $"{character.url}";

            Sprites sprite;

            using (var clientTwo = new HttpClient())
            {
                var pokemonResults = clientTwo.GetStringAsync(newWebService).Result;

                sprite = JsonConvert.DeserializeObject<Sprites>(pokemonResults);
            }

            lblInfo.Content = $"{sprite.ToString()}";
            imgPokemon.Source = new BitmapImage(new Uri(sprite.front_default));

        }
    }
}
