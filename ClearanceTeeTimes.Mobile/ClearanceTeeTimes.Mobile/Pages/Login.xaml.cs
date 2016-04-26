using ClearanceTeeTimes.Mobile.Pages.InitialAuthentication;
using System;
using System.Collections.Generic;


using Xamarin.Forms;
using ClearanceTeeTimes.Mobile.Pages;

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
            await Navigation.PushAsync(new CourseSearch());
            
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

