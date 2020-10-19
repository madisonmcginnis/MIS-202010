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
using System.Windows.Shapes;

namespace WPF_Classes3
{
    /// <summary>
    /// Interaction logic for StudentInfo.xaml
    /// </summary>
    public partial class StudentInfoWindow : Window
    {
        //Student selectedStudent;
        public StudentInfoWindow()
        {
            InitializeComponent();
        }
        public void Setup()
        {
            //lblAddress.Content = selectedStudent.GetAddress();
            //lblName.Content = $"{selectedStudent.FirstName} {selectedStudent.LastName}";
        }
    }
}
