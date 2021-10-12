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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private readonly List<BiodataInfo> _biodatas;

        public Login(List<BiodataInfo> biodatas):this()
        {
            InitializeComponent();
            this._biodatas = biodatas;
        }
        public Login() 
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var m = _biodatas.FirstOrDefault(s => s.Email == txtloginemail.Text);
            Profile profile = new Profile(m);

            profile.Show();
           
            

        }
    }
}
