using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Summarizes the ratings and reviews for the query.
    /// </summary>
    [DataContract]
    public class RatingSummary
    {
        /// <summary>
        /// The total number of reviews that matched the query.
        /// </summary>
        [DataMember]
        public int TotalReviewCount
        {
            get;
            set;
        }

        /// <summary>
        /// The average rating of all reviews.
        /// </summary>
        [DataMember]
        public decimal? AverageRating
        {
            get;
            set;
        }

        /// <summary>
        /// Unique Course Id used for read/write review in current Ratings/Review platform, it is not the Facility Id.
        /// </summary>
        [DataMember]
        public int? ProductReviewID
        {
            get;
            set;
        }
    }
}
