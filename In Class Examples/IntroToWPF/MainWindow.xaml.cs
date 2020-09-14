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

namespace IntroToWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtBirthday.Text = string.Empty;
            txtName.Clear();


        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            //change color of background
            btnGo.Background = new SolidColorBrush(Colors.Blue);
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            string name, birthday;
            name = txtName.Text;
            birthday = txtBirthday.Text;

            DateTime birthdayAsDate = Convert.ToDateTime(birthday);

            txtBirthday.Clear();
            txtName.Clear();

            var age = (DateTime.Now - birthdayAsDate).TotalDays/365;

            MessageBox.Show($"Welcome {name}, your birthday is {birthdayAsDate.ToShortDateString()}, you are {age:N2} years old");
        }

        private void btnGo_MouseLeave(object sender, MouseEventArgs e)
        {
            btnGo.Background = new SolidColorBrush(Colors.White);
        }
    }
}
