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

        void OnLogin (object sender, EventArgs e)
        {
            loginButton.Text = "Soon!";
        }
    }
}
