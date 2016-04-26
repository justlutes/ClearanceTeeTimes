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

		void OnReset (object sender, EventArgs e)
		{
			firstName.Text = null;
			lastName.Text = null;
			emailEntryBox.Text = null;
			phoneNumber.Text = null;
			password.Text = null;
			confirmPassword.Text = null;
			address1.Text = null;
			address2.Text = null;
			zipEntryBox.Text = null;
			cityEntryBox.Text = null;
			stateEntryBox.Text = null;
			genderEntryBox.Title = null;
		}

/*		private void OnRegister (object sender, EventArgs e)
		{
			string connetionString = null;
			SqlConnection connection;
			SqlCommand command;
			string sql = null;
			SqlDataReader dataReader;
			connetionString = "Data Source=ServerName;" +
				"Initial Catalog=DatabaseName;" +
				"User ID=UserName;" +
				"Password=Password";
			sql = "Your SQL Statement Here , like Select * from product";
			connection = new SqlConnection (connetionString);
			try {
				connection.Open ();
				command = new SqlCommand (sql, connection);
				dataReader = command.ExecuteReader ();
				while (dataReader.Read ()) {
					DisplayAlert(dataReader.GetValue (0) + " - " 
						+ dataReader.GetValue (1) + " - " 
						+ dataReader.GetValue (2));
				}
				dataReader.Close ();
				connection.Close ();
			} catch (Exception ex) {
				DisplayAlert("Can not open connection!");
			}
		}*/
	}
}