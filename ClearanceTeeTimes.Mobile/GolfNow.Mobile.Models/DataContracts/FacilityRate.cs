using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    public class FacilityRate
    {
        /// <summary>
        /// The Course ID associated with the rate
        /// </summary>
        [DataMember]
        public int CourseID
        {
            get;
            set;
        }

        /// <summary>
        /// The area id assocaited with the facility
        /// </summary>
        [DataMember]
        public int AreaID
        {
            get;
            set;
        }

        /// <summary>
        /// The full course name associated with the rate
        /// </summary>
        [DataMember]
        public string CourseFullName
        {
            get;
            set;
        }

        /// <summary>
        /// The trade rate
        /// </summary>
        [DataMember]
        public decimal TradeRate
        {
            get;
            set;
        }

        /// <summary>
        /// The course rate
        /// </summary>
        [DataMember]
        public decimal CourseRate
        {
            get;
            set;
        }

        /// <summary>
        /// The maximum discount percent
        /// </summary>
        [DataMember]
        public decimal? MaxDiscountPercent
        {
            get;
            set;
        }

        /// <summary>
        /// The date the rate is valid - null if n/a
        /// </summary>
        [IgnoreDataMember]
        public DateTime? ValidDate
        {
            get;
            set;
        }

		/// <summary>
		/// The formatted valid date, for serialization purposes
		/// </summary>
		[DataMember(Name="ValidDate", EmitDefaultValue = false)] 
		private string ValidDateFormatted
		{
			get;
			set;
		}

        /// <summary>
        /// The thumb nail image url
        /// </summary>
        [DataMember]
        public string ThumbNailImage
        {
            get;
            set;
        }

        /// <summary>
        /// The full-sized image url
        /// </summary>
        [DataMember]
        public string FullSizeImage
        {
            get;
            set;
        }

        /// <summary>
        /// The geographic latitude of the facility.
        /// </summary>
        [DataMember]
        public float? Latitude
        {
            get;
            set;
        }

        /// <summary>
        /// The geographic longitude of the facility.
        /// </summary>
        [DataMember]
        public float? Longitude
        {
            get;
            set;
        }

        /// <summary>
        /// The facility id.
        /// </summary>
        [DataMember]
        public int ID
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the rateset.
        /// </summary>
        [DataMember]
        public string Name
        {
            get;
            set;
        }

		/// <summary>
		/// Formats the valid date for serialization
		/// </summary>
		[OnSerializing]
		private void OnSerializing(StreamingContext context)
		{
			if (this.ValidDate.HasValue && this.ValidDate.Value != DateTime.MinValue)
			{
				this.ValidDateFormatted = this.ValidDate.Value.ToFormattedString();
			}
		}

		/// <summary>
		/// Gets the valid date from the string property and sets the date property after deserialization
		/// </summary>
		[OnDeserialized]
		void OnDeserialized(StreamingContext context)
		{
			DateTime? dt = this.ValidDateFormatted.ToDateTime();
			if (dt.HasValue)
			{
				this.ValidDate = dt.Value;
			}
		}
    }
}
