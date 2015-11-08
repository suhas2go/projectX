using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238





namespace newapp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class SignUp : Page
    {
        public SignUp()
        {
            this.InitializeComponent();
        }

        private void NewUserCreated_Click(object sender, RoutedEventArgs e)
        {   /*
            Person p1 = new Person
            {
                name = NameInput2.Text,
                pwd =PasswordInput2.Password,
                g = ,
                ftbl=,
                mv=,
                disc=,
                csgo=,
                age= AgeInput2.Text,
                contactno=ContactInput2.Text
                 


            };
            wait App.MobileService.GetTable<Person>().InsertAsync(p1);
            var m1 = new MessageDialog("Data Inserted").ShowAsync();
            nameTxt.Text = "";
            emailTxt.Text = "";
            MainPage page = new MainPage();
            this.Frame.Navigate(typeof(MainPage));
            */
        }

        private void GenderRadMale_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void GenderRadFemale_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void FootballTick1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void MovieTick1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void DiscussionTick1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CounterStrikeTick1_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
