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
using Wdg.Model;

namespace Wdg
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        private readonly BiodataInfo _biodata;

        public Profile()
        {
            InitializeComponent();
        }
        public Profile(BiodataInfo biodata)
        {
            this._biodata = biodata;
        }
     

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            txtdisplayfirstname.Content = _biodata.FirstName;
            txtdisplaylastname.Content = _biodata.LastName;
            txtdisplaymail.Content = _biodata.Email;
            txtdisplayDOB.Content = _biodata.DateOfBirth;
            txtdisplaygender.Content = _biodata.Gender;

        }
    }
}
