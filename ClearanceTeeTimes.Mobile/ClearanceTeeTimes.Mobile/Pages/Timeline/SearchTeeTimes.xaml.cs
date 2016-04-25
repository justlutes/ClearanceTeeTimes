using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;

using Xamarin.Forms;

namespace ClearanceTeeTimes.Mobile.Pages.Timeline
{
    public partial class SearchTeeTimes : ContentPage
    {
        public SearchTeeTimes()
        {
            InitializeComponent();
        }

        async void OnSearch(object sender, EventArgs e)
        {
            // Geo-location 
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.GetPositionAsync(10000);


            System.Diagnostics.Debug.WriteLine("Position Status: {0}", position.Timestamp);
            System.Diagnostics.Debug.WriteLine("Position Latitude: {0}", position.Latitude);
            System.Diagnostics.Debug.WriteLine("Position Longitude: {0}", position.Longitude);
        }
    }
}
