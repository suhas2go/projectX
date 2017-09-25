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
    public sealed partial class Profile2 : Page
    {

        Person Open_Profile = new Person();
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Open_Profile = (Person)e.Parameter;
            DisplayName.Text = Open_Profile.name;

            if (Open_Profile.g == true)
                GenderProperty.Text = "Male";
            else
                GenderProperty.Text = "Female";
            string interests = "";
            if (Open_Profile.ftb == true)
                interests += "Football\n";
            if (Open_Profile.mv == true)
                interests += "Movies\n";
            if (Open_Profile.disc == true)
                interests += "Discussions\n";
            if (Open_Profile.csgo == true)
                interests += "CS Go\n";
            FootballBool.Text = interests;
            AgeProperty.Text = "19";

        }

        public Profile2()
        {
            this.InitializeComponent();
        }

        private void Back_to_Alerts_Button_Click(object sender, RoutedEventArgs e)
        {
            if(this.Frame.CanGoBack)
            { this.Frame.GoBack(); }
        }
    }
}
