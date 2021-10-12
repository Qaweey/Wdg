using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Wdg.Model;

namespace Wdg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string myDate;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtfirstname.Text==""||
                txtlastname.Text==""||
                txtemail.Text==""
           
               )
            {
                MessageBox.Show("Please fill all your credentials");

            }
            if (txtFemale.IsChecked==false&&txtMale.IsChecked==false)
            {
                MessageBox.Show("Please specify your gender");
            }
            if (!Regex.IsMatch(txtemail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Please enter a valid email");
            }
            else
            {
                

                var datamodel = new BiodataInfo
                {
                    FirstName = txtfirstname.Text,
                    LastName = txtlastname.Text,
                    Email = txtemail.Text,
                    Gender = (bool)txtMale.IsChecked ? "Male" : "Female",
                    DateOfBirth = myDate
                };
                
                Datastorage.Biodatas = new List<BiodataInfo>();
                Datastorage.Biodatas.Add(datamodel);

                Login login = new Login(Datastorage.Biodatas);
                this.Close();
                login.Show();

                // MessageBox.Show("Your registration was successful");
            }    
            



        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if( (sender as DatePicker).SelectedDate != null)
            {
                myDate = (sender as DatePicker).SelectedDate.ToString();
            }
            else
            {
                MessageBox.Show("pick a date");
            }
           
        }
    }
}
