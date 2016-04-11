using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ClearanceTeeTimes.Mobile.Pages.InitialAuthentication
{
	public partial class WelcomePage : ContentPage
	{
		public WelcomePage()
		{
			InitializeComponent();
		}

		void OnLogin(object sender, EventArgs e)
		{
			loginButton.Text = "Login!";
		}

		void OnRegister(object sender, EventArgs e)
		{
<<<<<<< HEAD
			registerButton.Text = "Register!";
//			Command = new Command (async () => 
//				await Navigation.PushAsync (new UserRegisterInfo ()));
=======
			//Command = new Command (async () => 
				//await Navigation.PushAsync (new UserRegisterInfo ()));
>>>>>>> 7b9081d8e108d1f7805cf41e3dd3245ffc6baaa2
		}
	}

	public class FacebookLoginButton : Button
	{

	}
}
