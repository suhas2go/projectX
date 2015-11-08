using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Devices.Geolocation;
using Windows.UI.Popups;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace newapp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Alerts : Page
    {
        public Alerts()
        {
            this.InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {// Geolocator is in the Windows.Devices.Geolocation namespace
            Geolocator geo = new Geolocator();
            // await this because we don't know hpw long it will take to complete and we don't want to block the UI
            Geoposition pos = await geo.GetGeopositionAsync(); // get the raw geoposition data
            double lat = pos.Coordinate.Point.Position.Latitude; // current latitude
            double longt = pos.Coordinate.Point.Position.Longitude; // current longitude

           List<Event> interestEvents = await App.MobileService.GetTable<Event>().Where(x => x.hostname != GlobalVar.Globalname & ((GlobalVar.Globalftb == true & x.ftb == GlobalVar.Globalftb) | (GlobalVar.Globalmv == true & x.mv == GlobalVar.Globalmv) | (GlobalVar.Globaldisc == true & x.disc == GlobalVar.Globaldisc) | (GlobalVar.Globalcsgo == true & x.csgo == GlobalVar.Globalcsgo))).ToListAsync();
           

            if (interestEvents.Count == 0)
            {
                //  GotoHome = false;
                var dialog = new MessageDialog("No nearby events found");
                await dialog.ShowAsync();
            }
            gridView.ItemsSource = interestEvents;
        }
        private bool func1(int lat1, int lon1, double lat2, double lon2)
        {
            double theta = lon1 - lon2;
            double dist = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta));
            dist = Math.Acos(dist);
            dist = rad2deg(dist);
            dist = dist * 60 * 1.1515;
            dist = dist * 1.609344;
            if (dist <= 10)
                return true;
            return false;
        }
        public static double deg2rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }

        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //::  This function converts radians to decimal degrees             :::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        public static double rad2deg(double rad)
        {
            return (rad / Math.PI * 180.0);
        }

        private async void gridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ev = (Event)e.ClickedItem;
            var dialog = new MessageDialog(ev.contactno);
            await dialog.ShowAsync();
        }
    }
}

