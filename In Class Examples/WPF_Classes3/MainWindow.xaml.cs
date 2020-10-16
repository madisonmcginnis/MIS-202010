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

namespace GraduationHandout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();

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

            //creates new instances of student and address classes
            Student s = new Student();
            Address a = new Address();

            //verify if entered data is in correct format and print error message if not
            if (string.IsNullOrEmpty(txtFirstName.Text) == true)
            {
                MessageBox.Show("First name can't be empty!");
            }
            else if (string.IsNullOrEmpty(txtLastName.Text) == true)
            {
                MessageBox.Show("Last name can't be empty!");
            }
            else if (string.IsNullOrEmpty(txtMajor.Text) == true)
            {
                MessageBox.Show("Major can't be empty!");
            }
            else if (Double.TryParse(txtGPA.Text, out double GPAResult) == false)
            {
                MessageBox.Show("GPA not valid!");
            }
            else if (Double.TryParse(txtStreetNumber.Text, out double streetNumResult) == false)
            {
                MessageBox.Show("Street number not valid!");
            }
            else if (string.IsNullOrEmpty(txtStreetName.Text) == true)
            {
                MessageBox.Show("Street name can't be empty!");
            }
            else if (string.IsNullOrEmpty(txtState.Text) == true)
            {
                MessageBox.Show("State can't be empty!");
            }
            else if (string.IsNullOrEmpty(txtCity.Text) == true)
            {
                MessageBox.Show("City can't be empty!");
            }
            else if (Double.TryParse(txtZipCode.Text, out double ZipResult) == false)
            {
                MessageBox.Show("Zip Code is invalid!");
            }
            else
            {
                //assigns text box entries to appropriate variable
                a.StreetNumber = Convert.ToInt32(txtStreetNumber.Text);
                a.StreetName = txtStreetName.Text;
                a.State = txtState.Text;
                a.City = txtCity.Text;
                a.Zipcode = Convert.ToInt32(txtZipCode.Text);

                s.FirstName = txtFirstName.Text;
                s.LastName = txtLastName.Text;
                s.Major = txtMajor.Text;
                s.GPA = Convert.ToDouble(txtGPA.Text);
                s.Address = a;
                s.CalculateDistinction();

                //adds handout information to list and adds contents of list to listbox
                students.Add(s);
                lstHandout.Items.Add(s.ToString());

                //clear textboxes to allow user to enter another one
                txtFirstName.Clear();
                txtLastName.Clear();
                txtMajor.Clear();
                txtGPA.Clear();
                txtStreetNumber.Clear();
                txtStreetName.Clear();
                txtState.Clear();
                txtCity.Clear();
                txtZipCode.Clear();
            }
        }
    }
}