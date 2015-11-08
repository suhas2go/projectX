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
    public sealed partial class Profile : Page
    {
        public Profile()
        {
            this.InitializeComponent();
            DisplayName.Text = GlobalVar.Globalname;
            if(GlobalVar.Globalg==true)
            GenderProperty.Text = "Male";
            else
            GenderProperty.Text = "Female";
            string interests = "";
            if (GlobalVar.Globalftb == true)
                interests += "Football\n";
            if (GlobalVar.Globalmv == true)
                interests += "Movies\n";
            if (GlobalVar.Globaldisc == true)
                interests += "Discussions\n";
            if (GlobalVar.Globalcsgo == true)
                interests += "CS Go\n";
            FootballBool.Text = interests;
            AgeProperty.Text = GlobalVar.Globalage;
        }

        private void DisplayName_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void GenderProperty_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
