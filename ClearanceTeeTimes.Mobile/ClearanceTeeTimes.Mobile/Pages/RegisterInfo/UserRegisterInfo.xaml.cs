using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ClearanceTeeTimes.Mobile
{
	public partial class UserRegisterInfo : ContentPage
	{
		public UserRegisterInfo ()
		{
			InitializeComponent ();
		}

		public string GetUserFirstName(string fName)
		{
			if (fNameEntryBox.Text == null) {
				DisplayAlert ("Error", "First name cannot be null! Please re-enter.");
				return;
			} else {
				fName = fNameEntryBox.Text;
			}
			return fName;
		}

		public string GetUserLastName(string lName)
		{
			if (lNameEntryBox.Text == null) {
				DisplayAlert ("Error", "Last name cannot be null! Please re-enter.");
				return;
			} else {
				fName = fNameEntryBox.Text;
			}
			return fName;
		}



	}
}
//ohhh i see//ok interesting ..