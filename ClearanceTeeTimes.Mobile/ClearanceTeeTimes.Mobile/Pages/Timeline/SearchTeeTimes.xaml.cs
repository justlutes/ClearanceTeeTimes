using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Newtonsoft.Json;

using Xamarin.Forms;
using System.Net;
using System.IO;

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

          /*  string url = "https://2-1-17-sandbox.api.gnsvc.com/rest/channel/5151/facilities/tee-times?q=geo-location&latitude=" +
                         position.Latitude +
                         "&longitude=" +
                         position.Longitude +
                         "&proximity=" +
                         DistancePicker.SelectedIndex +
                         "&date-min=" +
                         TeeDatePicker.Date +
                         "T00%3a00%3a00&date-max=" +
                         TeeDatePicker.Date +
                         "T23%3a59%3a59&take=2";
            JsonReader json = await FetchTeeTimesAsync(url); */

        }

        /*  private async Task<JsonReader> FetchTeeTimesAsync (string url)
          {
              // Create an HTTP request using the URL
              HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
              request.ContentType = "application/json";
              request.Method = "GET";
              request.Credentials = new NetworkCredential("UCF_Developmenbt", "fUMLaucsrerjKg7G");

              using (WebResponse response = await request.GetResponseAsync())
              {
                  using (Stream stream = response.GetResponseStream())
                  {
                      JsonReader jsonDoc = await Task.Run(() => JsonObject.Load(stream));

                      return jsonDoc;
                  }
              } 

          } */
    }
}
