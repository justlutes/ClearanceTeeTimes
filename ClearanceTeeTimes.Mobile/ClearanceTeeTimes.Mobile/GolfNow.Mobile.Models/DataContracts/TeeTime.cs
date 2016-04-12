using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public abstract class TeeTime
    {
        /// <summary>
        /// Gets or sets the facility id associated with this tee time.
        /// </summary>
        [DataMember]
        public int FacilityID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the date and time of the tee time (in the course's local time zone).
        /// </summary>
        [IgnoreDataMember]
        public DateTime Time
        {
            get;
            set;
        }

		/// <summary>
		/// The formatted tee time, for serialization purposes
		/// </summary>
		[DataMember(Name="Time")]
		private string TimeFormatted
		{
			get;
			set;
		}

		/// <summary>
		/// Formats the tee time for serialization
		/// </summary>
		[OnSerializing]
		private void OnSerializing(StreamingContext context)
		{
			this.TimeFormatted = this.Time.ToFormattedString();
		}

		/// <summary>
		/// Gets the tee time from the string property and sets the date property after deserialization
		/// </summary>
		[OnDeserialized]
		void OnDeserialized(StreamingContext context)
		{
			DateTime? dt = this.TimeFormatted.ToDateTime();
			if (dt.HasValue)
			{
				this.Time = dt.Value;
			}
		}
    }
}
