using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.UI.Popups;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Devices.Geolocation;
using System.Threading.Tasks;
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
    public sealed partial class Create : Page
    {
        bool ftb1 = false;
        bool mv1 = false;
        bool disc1 = false;
        bool csgo1 = false;
        public Create()
        {
            this.InitializeComponent();
        }


        private async void NewEventCreated_Click(object sender, RoutedEventArgs e)
        {
            // Geolocator is in the Windows.Devices.Geolocation namespace
            Geolocator geo = new Geolocator();
            // await this because we don't know hpw long it will take to complete and we don't want to block the UI
           Geoposition pos = await geo.GetGeopositionAsync(); // get the raw geoposition data
           double lat = pos.Coordinate.Point.Position.Latitude; // current latitude
           double longt = pos.Coordinate.Point.Position.Longitude; // current longitude

            Event e1 = new Event()
            {
                
                eventname = EventName.Text,
                hostname = GlobalVar.Globalname,
                venue = Venue.Text,
                time = EventTime.Text,
                ftb = ftb1,
                mv = mv1,
                disc = disc1,
                csgo = csgo1,
                p1name = " ",
                p2name = " ",
                p3name = " ",
                p1val = -1,
                p2val = -1,
                p3val = -1,
                latitude = (int)lat,
                longitude = (int)longt,
                contactno = GlobalVar.Globalcontact

        };

            await App.MobileService.GetTable<Event>().InsertAsync(e1);
            //var m1 = new MessageDialog("Data Inserted").ShowAsync();
            var dialog = new MessageDialog("Event was Broadcasted and saved on server");
            await dialog.ShowAsync();


        }


        private void FootballTick2_Checked(object sender, RoutedEventArgs e)
            {
                ftb1 = true;
            }

            private void MovieTick2_Checked(object sender, RoutedEventArgs e)
            {
                mv1 = true;
            }

            private void DiscussionTick2_Checked(object sender, RoutedEventArgs e)
            {
                disc1 = true;
            }

            private void CounterStrikeTick2_Checked(object sender, RoutedEventArgs e)
            {
                csgo1 = true;
            }
        }
    }




