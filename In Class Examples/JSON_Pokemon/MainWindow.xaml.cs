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
        Sprites sprite;
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


            using (var clientTwo = new HttpClient())
            {
                var pokemonResults = clientTwo.GetStringAsync(newWebService).Result;

                sprite = JsonConvert.DeserializeObject<Sprites>(pokemonResults);
            }

            //add height and weight to label
            lblInfo.Content = $"{sprite.ToString()}";

            //define the image with the url and correct id number
            sprite.front_default = @"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + $"{sprite.id}" + @".png";
            sprite.back_default = @"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/" +$"{sprite.id}"+@".png";
            
            //assigned the front image to the image on the window
            imgPokemon.Source = new BitmapImage(new Uri(sprite.front_default));
        }


        //these actions are named wrong because I accidentally did the label instead of the picture at first
        //wrong name, but correct action for the image
        private void lblInfo_MouseEnter(object sender, MouseEventArgs e)
        {
            //assigned back default when mouse enters image
            imgPokemon.Source = new BitmapImage(new Uri(sprite.back_default));
        }

        private void lblInfo_MouseLeave(object sender, MouseEventArgs e)
        {
            //assigns front default when mouse leaves image
            imgPokemon.Source = new BitmapImage(new Uri(sprite.front_default));
        }
    }
}
