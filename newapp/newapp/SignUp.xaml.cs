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
        bool g1;
        bool ftb1=false;
        bool mv1=false;
        bool disc1=false;
        bool csgo1=false;
        public SignUp()
        {
            this.InitializeComponent();
        }

        private async void NewUserCreated_Click(object sender, RoutedEventArgs e)
        {   
            Person p1 = new Person
            {
                name = NameInput2.Text,
                pwd =PasswordInput2.Password,
                g = g1,
                ftb= ftb1,
                mv=mv1,
                disc=disc1,
                csgo=csgo1,
                age= AgeInput2.Text,
                contactno=ContactInput2.Text
             };
            await App.MobileService.GetTable<Person>().InsertAsync(p1);
           // GlobalVar.Globalname = p1.name;
           // GlobalVar.Globalcontact = p1.contactno;
            //var m1 = new MessageDialog("Data Inserted").ShowAsync();
            NameInput2.Text = "";
            AgeInput2.Text = "";
            ContactInput2.Text = "";
            MainPage page = new MainPage();
            this.Frame.Navigate(typeof(MainPage));
            
        }
        
        private void GenderRadMale_Checked(object sender, RoutedEventArgs e)
        {
            g1 = true;
        }

        private void GenderRadFemale_Checked(object sender, RoutedEventArgs e)
        {
            g1 = false;
        }

        private void FootballTick1_Checked(object sender, RoutedEventArgs e)
        {
            ftb1 = true;
        }

        private void MovieTick1_Checked(object sender, RoutedEventArgs e)
        {
            mv1 = true;
        }

        private void DiscussionTick1_Checked(object sender, RoutedEventArgs e)
        {
            disc1 = true;
        }

        private void CounterStrikeTick1_Checked(object sender, RoutedEventArgs e)
        {
           csgo1 = true;
        }
    }
}
