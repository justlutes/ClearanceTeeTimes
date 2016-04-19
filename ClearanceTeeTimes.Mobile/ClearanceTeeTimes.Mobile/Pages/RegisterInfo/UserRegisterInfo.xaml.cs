using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Text.RegularExpressions;

namespace ClearanceTeeTimes.Mobile
{
	public partial class UserRegisterInfo : ContentPage
	{
		public UserRegisterInfo ()
		{
			InitializeComponent ();
		}

		void OnReset(object sender, EventArgs e)
		{
			firstName.Text = null;
			lastName.Text = null;
			emailEntryBox.Text = null;
			phoneNumber.Text = null;
			password.Text = null;
			confirmPassword.Text = null;
			address1.Text = null;
			address2.Text = null;
			country.Text = null;
			zipEntryBox.Text = null;
			cityEntryBox.Text = null;
			stateEntryBox.Text = null;
			genderEntryBox.Text = null;
		}
	}
}