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

		async void OnLogin(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Login());
		}

        async void OnRegister(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserRegisterInfo());
        }
	}
}
