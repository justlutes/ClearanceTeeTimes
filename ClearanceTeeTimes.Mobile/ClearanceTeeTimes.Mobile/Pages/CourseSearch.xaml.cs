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
        public CourseSearch()
        {
            InitializeComponent();

        }

        public Entry CountryEntry
        {
            get { return countryEntry; }
        }

        public Entry StateEntry
        {
            get { return stateEntry; }
        }

        public Entry CityEntry
        {
            get { return cityEntry; }
        }
        async void OnSearch(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CourseList());
            
        }



    }	
}

