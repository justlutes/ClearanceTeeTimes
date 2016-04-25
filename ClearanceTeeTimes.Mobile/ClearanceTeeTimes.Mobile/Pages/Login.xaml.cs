using ClearanceTeeTimes.Mobile.Pages.InitialAuthentication;
using System;
using System.Collections.Generic;
using Plugin.Geolocator;

using Xamarin.Forms;

namespace ClearanceTeeTimes.Mobile
{
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        async void OnSignin(object sender, EventArgs e)
        {
            // Geo-location 
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.GetPositionAsync(10000);


            System.Diagnostics.Debug.WriteLine("Position Status: {0}", position.Timestamp);
            System.Diagnostics.Debug.WriteLine("Position Latitude: {0}", position.Latitude);
            System.Diagnostics.Debug.WriteLine("Position Longitude: {0}", position.Longitude);
        }

        async void OnRegister(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserRegisterInfo());
        }

        async void OnForgotPassword(object sender, EventArgs e)
        {
			await Navigation.PushAsync (new ForgotPassword ());
        }
    }
}

