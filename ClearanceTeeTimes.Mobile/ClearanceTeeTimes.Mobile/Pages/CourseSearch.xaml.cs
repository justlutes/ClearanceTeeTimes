using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace ClearanceTeeTimes.Mobile
{
	public partial class CourseSearch : ContentPage
	{
		public CourseSearch ()
		{
			InitializeComponent ();
		}

		async void OnSearch(object sender, EventArgs e)
		{
			var country = countryEntry.Text;
			var state = stateEntry.Text;
			var city = cityEntry.Text;

			string url = "https://2-1-17-sandbox.api.gnsvc.com/rest/channel/5151/facilities?q=country-city-state&country-code=" +
			             country +
			             "&state-province-code=" +
			             state +
			             "&city=" +
			             city;

			List<Course> courses = CallRest(url);

			CourseName.ItemsSource = courses;
		}

		private List<Course> CallRest (string url)
		{
			List<Course> courses = null;

			var client = new HttpClient();
			var request = new HttpRequestMessage()
			{
				RequestUri = new Uri(url),
				Method = HttpMethod.Get,
			};

			request.Headers.Add("Username", "UCF_Developmenbt");
			request.Headers.Add("Password", "fUMLaucsrerjKg7G");
			var task = client.SendAsync(request)
				.ContinueWith((taskwithmsg) =>
					{
						var response = taskwithmsg.Result;
						var jsonTask = response.Content.ReadAsAsync<IEnumerable<Course>>();
						jsonTask.Wait();
						var jsonObject = jsonTask.Result;
						courses = jsonObject.ToList();
					});
			task.Wait();

			return courses;
		}
	}

	public class Address
	{
		public string City { get; set; }
		public string Country { get; set; }
		public string Line1 { get; set; }
		public string Line2 { get; set; }
		public string PostalCode { get; set; }
		public string StateProvinceCode { get; set; }
	}

	public class Course
	{
		public int ID { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public string Name { get; set; }
		public Address Address { get; set; }
		public string CurrencyCode { get; set; }
		public string Description { get; set; }
		public string EmailAddress { get; set; }
		public string Information { get; set; }
		public bool IsActive { get; set; }
		public bool IsMultiCourse { get; set; }
		public string PhoneNumber { get; set; }
		public List<object> Tags { get; set; }
		public string TeeTimePolicy { get; set; }
		public string ThumbnailImagePath { get; set; }
		public double TimeZoneOffset { get; set; }
		public string WebsiteAddress { get; set; }
	}
}

