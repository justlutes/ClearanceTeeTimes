using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Defines a facility with rates rolled into it.
    /// </summary>
    [DataContract]
    public class FacilitySummaryListItem
    {
        /// <summary>
        /// The facility ID for this item.
        /// </summary>
        [DataMember]
        public int ID
        {
            get;
            set;
        }

        /// <summary>
        /// This facility's name.
        /// </summary>
        [DataMember]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Address information for this facility.
        /// </summary>
        [DataMember]
        public Address Address
        {
            get;
            set;
        }

        /// <summary>
        /// A phone number for this facility.
        /// </summary>
        [DataMember]
        public string PhoneNumber
        {
            get;
            set;
        }

        /// <summary>
        /// The currency type used at this facility.
        /// </summary>
        [DataMember]
        public string CurrencyCode
        {
            get;
            set;
        }

        /// <summary>
        /// The geographic latitude for this facility.
        /// </summary>
        [DataMember]
        public float Latitude
        {
            get;
            set;
        }

        /// <summary>
        /// The geographic longitude for this facility.
        /// </summary>
        [DataMember]
        public float Longitude
        {
            get;
            set;
        }

        /// <summary>
        /// The distance from the input geolocation to this facility.
        /// </summary>
        [DataMember]
        public float Distance
        {
            get;
            set;
        }

        /// <summary>
        /// The number of reviews this facility has received.
        /// </summary>
        [DataMember]
        public int NumberOfReviews
        {
            get;
            set;
        }

        /// <summary>
        /// The average rating for this facility.
        /// </summary>
        [DataMember]
        public decimal AverageRating
        {
            get;
            set;
        }

        /// <summary>
        /// The date of the earliest tee time for this facility.
        /// </summary>
        [IgnoreDataMember]
        public DateTime MinDate
        {
            get;
            set;
        }

        /// <summary>
        /// The formatted minimum date.
        /// </summary>
        [DataMember(Name="MinDate")]
        public string MinDateFormatted
        {
            get;
            set;
        }

        /// <summary>
        /// The date of the latest tee time for this facility.
        /// </summary>
        [IgnoreDataMember]
        public DateTime MaxDate
        {
            get;
            set;
        }

        /// <summary>
        /// The formatted maximum date.
        /// </summary>
        [DataMember(Name="MaxDate")]
        public string MaxDateFormatted
        {
            get;
            set;
        }

        /// <summary>
        /// The minimum base special rate at this facility.
        /// </summary>
        [DataMember]
        public decimal MinPrice
        {
            get;
            set;
        }

        /// <summary>
        /// The maximum base special rate at this facility.
        /// </summary>
        [DataMember]
        public decimal MaxPrice
        {
            get;
            set;
        }

        /// <summary>
        /// A flag denoting whether or not this facility has a hot deal rate within the predicates specified.
        /// </summary>
        [DataMember]
        public bool HasHotDeal
        {
            get;
            set;
        }

        /// <summary>
        ///  The tags associated with this facility.
        /// </summary>
        [DataMember]
        public string[] Tags
        {
            get;
            set;
        }

        /// <summary>
        /// A URL pointing to the facility's image.
        /// </summary>
        [DataMember]
        public string ThumbnailImagePath
        {
            get;
            set;
        }

        /// <summary>
        /// Expandable. Imparts course demographic information (par, slope, yardage, etc.) for this facility.
        /// </summary>
        [DataMember]
        public Expandable<CourseStatistics> CourseStatistics
        {
            get;
            set;
        }

        /// <summary>
        /// A list of tee times associated with this facility.
        /// </summary>
        //[DataMember]
        //public List<CourseSearchTeeTime> TeeTimes
        //{
        //    get;
        //    set;
        //}

        /// <summary>
        /// Formats the list item's dates for serialization
        /// </summary>
        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            this.MinDateFormatted = this.MinDate.ToFormattedString();
            this.MaxDateFormatted = this.MaxDate.ToFormattedString();
        }

        /// <summary>
        /// Gets the datetimes from the string property and sets the date property after deserialization.
        /// </summary>
        [OnDeserialized]
        void OnDeserialized(StreamingContext context)
        {
            DateTime? dtMin = this.MinDateFormatted.ToDateTime(),
                      dtMax = this.MaxDateFormatted.ToDateTime();

            if (dtMin.HasValue)
            {
                this.MinDate = dtMin.Value;
            }

            if (dtMax.HasValue)
            {
                this.MaxDate = dtMax.Value;
            }
        }
    }
}
