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
				DisplayAlert ("Error", "First name cannot be empty! Please re-enter.", "Ok");
				return fName;
			} else {
				fName = fNameEntryBox.Text;
			}
			return fName;
		}

		public string GetUserLastName(string lName)
		{
			if (lNameEntryBox.Text == null) {
				DisplayAlert ("Error", "Last name cannot be empty! Please re-enter.", "Ok");
				return lName;
			} else {
				lName = lNameEntryBox.Text;
			}
			return lName;
		}


		public string GetUserSex(string mf)
		{
			if (maleFemaleEntryBox.Text == null) {
				DisplayAlert ("Error", "Sex cannot be empty! Please re-enter.", "Ok");
				return mf;
			} else {
				mf = maleFemaleEntryBox.Text;
			}
			return mf;
		}

		public string GetUserCity(string city)
		{
			if (cityEntryBox.Text == null) {
				DisplayAlert ("Error", "City cannot be empty! Please re-enter.", "Ok");
				return city;
			} else {
				city = cityEntryBox.Text;
			}
			return city;
		}

		public string GetUserState(string state)
		{
			if (stateEntryBox.Text == null) {
				DisplayAlert ("Error", "State cannot be empty! Please re-enter.", "Ok");
				return state;
			} else {
				state = stateEntryBox.Text;
			}
			return state;
		}

		public string GetUserZip(string zip)
		{
			if (zipEntryBox.Text == null) {
				DisplayAlert ("Error", "Zip code cannot be empty! Please re-enter.", "Ok");
				return zip;
			} else {
				zip = zipEntryBox.Text;
			}
			return zip;
		}

		public string GetUserEmail(string email)
		{
			if (emailEntryBox.Text == null) {
				DisplayAlert ("Error", "Email cannot be empty! Please re-enter.", "Ok");
				return email;
			} else {
				email = emailEntryBox.Text;
			}
			return email;
		}


	}
}
//ohhh i see//ok interesting ..