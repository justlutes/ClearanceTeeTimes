using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ClearanceTeeTimes.Mobile
{
	public partial class UserTimeline : ContentPage
	{
		public UserTimeline ()
		{
			InitializeComponent ();
		}


		public string GetUserCourses(string selectCourses)
		{
			string userCourses = "https://2-1-17-sandbox.api.gnsvc.com/rest/channel/5151/facilities?q=country-city-state&country-code=US&state-province-code=FL&city=Orlando";
		
			return userCourses;
		}
	}
}


