using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A collection of ratings and reviews
    /// </summary>
    [DataContract]
    public class ReviewCollection : RatingSummary
    {
        public ReviewCollection(IEnumerable<Review> collection, int totalReviewCount, decimal? averageRating, int? productReviewId, int totalRecommended, IEnumerable<Subratings> subratings)
        {
            this.AverageRating = averageRating;
            this.TotalReviewCount = totalReviewCount;
            this.TotalRecommended = totalRecommended;
            this.ProductReviewID = productReviewId;
            this.Reviews = collection.ToArray();
            this.Subratings = subratings.ToArray();
        }

        public ReviewCollection()
        {

        }

        /// <summary>
        /// A collection of reviews that match the query.
        /// </summary>
        [DataMember]
        public Review[] Reviews
        {
            get;
            set;
        }

        /// <summary>
        /// The total number of reviewers who would recommend this course.
        /// </summary>
        [DataMember]
        public int? TotalRecommended
        {
            get;
            set;
        }

        /// <summary>
        /// A collection of subratings information as reported by a review provider object.
        /// </summary>
        [DataMember]
        public Subratings[] Subratings
        {
            get;
            set;
        }
    }
}
