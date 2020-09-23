using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WPF2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Toy> Toys = new List<Toy>();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Toy t = new Toy();

            //confirm string
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                MessageBox.Show("Toy name can't be empty!");
            }
            else if (string.IsNullOrEmpty(txtManufacturer.Text) == true)
            {
                MessageBox.Show("Manufacturer can't be empty!");
            }
            //confirm double
            else if (Double.TryParse(txtPrice.Text, out double result) == false)
            {
                MessageBox.Show("Price isn't valid!");
            }
            else
            {
                t.Name = txtName.Text;
                t.Manufacturer = txtManufacturer.Text;
                t.Price = Convert.ToDouble(txtPrice.Text);

                Toys.Add(t);
                lstToys.Items.Add(t);

                txtName.Clear();
                txtManufacturer.Clear();
                txtPrice.Clear();
            }
        }

        private void lstToys_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //having an issue here
            Toy selectedToy = (Toy)lstToys.SelectedItem;

            MessageBox.Show($"{selectedToy.GetAisle()}");
        }
    }
}
