using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public class WeatherForcast
    {
        /// <summary>
        /// Gets or sets a value indicating the forcasted high temerature for the day.
        /// </summary>
        [DataMember]
        public int HighTemperature
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating the forcasted low temerature for the day.
        /// </summary>
        [DataMember]
        public int LowTemperature
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the uri for an image to use for a weather icon.
        /// </summary>
        [DataMember]
        public string WeatherImageUri
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a date for the forcast.
        /// </summary>
        [IgnoreDataMember]
        public DateTime Date
        {
            get;
            set;
        }

		/// <summary>
		/// The formatted date, for serialization purposes
		/// </summary>
		[DataMember(Name = "Date")]
		private string DateFormatted
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets a value indicating the units for the temperature.
        /// </summary>
        /// <remarks>
        /// s for standard
        /// m for metric
        /// </remarks>
        [DataMember]
        public string Units
        {
            get;
            set;
        }

		/// <summary>
		/// Formats the date for serialization
		/// </summary>
		[OnSerializing]
		private void OnSerializing(StreamingContext context)
		{
			this.DateFormatted = this.Date.ToFormattedString();
		}

		/// <summary>
		/// Gets the date from the string property and sets the date property after deserialization
		/// </summary>
		[OnDeserialized]
		void OnDeserialized(StreamingContext context)
		{
			DateTime? dt = this.DateFormatted.ToDateTime();
			if (dt.HasValue)
			{
				this.Date = dt.Value;
			}
		}
    }
}
