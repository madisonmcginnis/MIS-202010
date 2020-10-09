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

namespace JSON_ChuckNorris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Jokes jokes;
        public List<string> categories { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            cboCategories.Items.Add("all");

            string webService = @"https://api.chucknorris.io/jokes/categories";

            using (var client = new HttpClient())
            {
                var results = client.GetStringAsync(webService).Result;
                categories = JsonConvert.DeserializeObject<List<string>>(results);
            }

            foreach (var category in categories)
            {
                cboCategories.Items.Add(category);
            }
        }

        private void btnGetQuote_Click(object sender, RoutedEventArgs e)
        {
            var selectedCategory = cboCategories.SelectedItem;

            if (selectedCategory.ToString()=="all")
            {
                string jokesWebService = @"https://api.chucknorris.io/jokes/random";

                using (var jokeClient = new HttpClient())
                {
                    var jokeResults = jokeClient.GetStringAsync(jokesWebService).Result;

                    jokes = JsonConvert.DeserializeObject<Jokes>(jokeResults);
                }

                txtJokes.Text = jokes.value;
            }
            else
            {
                string jokesWebService = $@"https://api.chucknorris.io/jokes/random?category={selectedCategory}";

                using (var jokeClient = new HttpClient())
                {
                    var jokeResults = jokeClient.GetStringAsync(jokesWebService).Result;

                    jokes = JsonConvert.DeserializeObject<Jokes>(jokeResults);
                }

                txtJokes.Text = jokes.value;
            }
        }
    }
}
