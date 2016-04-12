using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    [DataContract]
    /// <summary>
    /// Represents a user rating and review of a facility.
    /// </summary>
    public class Review
    {
        /// <summary>
        /// Gets or sets the name of the user who submits the review. Anonymous users are set as null.
        /// </summary>
        [DataMember]
        public string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the date and time that the review is submitted. 
        /// </summary>
        [IgnoreDataMember]
        public DateTime ReviewDate
        {
            get;
            set;
        }

		/// <summary>
		/// The formatted review date, for serialization purposes
		/// </summary>
		[DataMember(Name = "ReviewDate")]
		private string ReviewDateFormatted
		{
			get;
			set;
		}

        // TODO: Document what rating values mean.
        /// <summary>
        /// The value of the rating.
        /// </summary>
        [DataMember]
        public int Rating
        {
            get;
            set;
        }

        /// <summary>
        /// The title for the review.
        /// </summary>
        [DataMember]
        public string ReviewTitle
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the a free text review.
        /// </summary>
        [DataMember]
        public string ReviewText
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the facility id that the review is associated with.
        /// </summary>
        [DataMember]
        public int FacilityID
        {
            get;
            set;
        }

		/// <summary>
        /// The review's date of play. Note that if the DateOfPlay field is set to "0001-01-01T00:00:00", there was no
        /// date of play for this review: it should be filtered out accordingly. In a future API release, this field will
        /// be set to NULL in such instances
		/// </summary>
		[IgnoreDataMember]
		public DateTime DateOfPlay
		{
			get;
			set;
		}

		/// <summary>
        /// The formatted date of play for serialization purposes. Note that if the DateOfPlayFormatted field is set to 
        /// "0001-01-01T00:00:00", there was no date of play for this review: it should be filtered out accordingly. In a 
        /// future API release, this field will be set to NULL in such instances
		/// </summary>
		[DataMember(Name = "DateOfPlay")]
		public string DateOfPlayFormatted
		{
			get;
			set;
		}

		/// <summary>
		/// The review's helpfulness rating
		/// </summary>
		[DataMember]
		public decimal? Helpfulness
		{
			get;
			set;
		}

		/// <summary>
		/// Formats the review date for serialization
		/// </summary>
		[OnSerializing]
		private void OnSerializing(StreamingContext context)
		{
			this.ReviewDateFormatted = this.ReviewDate.ToFormattedString();
			this.DateOfPlayFormatted = this.DateOfPlay.ToFormattedString();
		}

		/// <summary>
		/// Gets the review date from the string property and sets the date property after deserialization
		/// </summary>
		[OnDeserialized]
		void OnDeserialized(StreamingContext context)
		{
			DateTime? dt = this.ReviewDateFormatted.ToDateTime();
			if (dt.HasValue)
			{
				this.ReviewDate = dt.Value;
			}

			dt = this.DateOfPlayFormatted.ToDateTime();
			if (dt.HasValue)
			{
				this.DateOfPlay = dt.Value;
			}
		}

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.ReviewDate, this.UserName);
        }

        /// <summary>
        /// How was the course's condition.
        /// </summary>
        [DataMember]
        public int? CourseConditions { get; set; }

        /// <summary>
        /// Was this the golfer's first time playing the course.
        /// </summary>
        [DataMember]
        public string FirstTimePlaying { get; set; }

        /// <summary>
        /// How was the quality of the food and beverages.
        /// </summary>
        [DataMember]
        public int? FoodAndBeverageQuality { get; set; }

        /// <summary>
        /// What is the golfer's handicap.
        /// </summary>
        [DataMember]
        public string GolferHandicap { get; set; }

        /// <summary>
        /// How was the condition of the facility overall.
        /// </summary>
        [DataMember]
        public int? FacilitiesCondition { get; set; }

        /// <summary>
        /// How was the 18 hole pace of play.
        /// </summary>
        [DataMember]
        public int? PaceOfPlay { get; set; }

        /// <summary>
        /// Does the golfer recommend this golf course.
        /// </summary>
        [DataMember]
        public bool? IsRecommended { get; set; }

        /// <summary>
        /// Did the golfer play nine holes.
        /// </summary>
        [DataMember]
        public string NineHoles { get; set; }

        /// <summary>
        /// How often does the golfer play golf.
        /// </summary>
        [DataMember]
        public string PlayFrequency { get; set; }

        /// <summary>
        /// How friendly was the staff.
        /// </summary>
        [DataMember]
        public int? StaffFriendliness { get; set; }

        /// <summary>
        /// Is the course a good value for the money.
        /// </summary>
        [DataMember]
        public int? ValueForTheMoney { get; set; }

        /// <summary>
        /// Did the golfer walk or ride the course.
        /// </summary>
        [DataMember]
        public string WalkOrRide { get; set; }
    }
}
