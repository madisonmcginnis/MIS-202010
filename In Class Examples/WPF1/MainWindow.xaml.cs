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

namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<EntryForm> applications = new List<EntryForm>();

        EntryForm entry = new EntryForm();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_MouseEnter(object sender, MouseEventArgs e)
        {
            btnSubmit.Background = new SolidColorBrush(Colors.Gray);
        }

        private void btnSubmit_MouseLeave(object sender, MouseEventArgs e)
        {
            btnSubmit.Background = new SolidColorBrush(Colors.White);
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //assigns user entry to variables
            entry.Name = txtName.Text;
            entry.Address = txtAddress.Text;
            entry.ZipCode = Convert.ToInt32(txtZipcode.Text);

            //creates the application and adds it to a list
            applications.Add(entry);
            lstApplications.Items.Add(applications);

            //clear textboxes so user can enter another application
            txtName.Clear();
            txtAddress.Clear();
            txtZipcode.Clear();
                        
            //MessageBox.Show($"name: {entry.Name} address: {entry.Address} zipcode: {entry.ZipCode}");
        }
    }
}
