using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A data contract for Facilities.
    /// </summary>
    [DataContract]
    public class Facility
    {
        /// <summary>
        /// Gets or sets the id of the facility.
        /// </summary>
        [DataMember]
        public int ID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the facility.
        /// </summary>
        [DataMember]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the geographic latitude of the facility.
        /// </summary>
        [DataMember]
        public float? Latitude
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the geographic longitude of the facility.
        /// </summary>
        [DataMember]
        public float? Longitude
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the distance to the subject of the query (ie: geo lat/long or market).  This value does not apply to every query 
        /// and will be set to null when there is no subject.  When applicable, it will contain the distance, in miles, to the subject 
        /// of the query.
        /// </summary>
        [DataMember(EmitDefaultValue=false)]
        public float? Distance
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a list of ratesets for the facility (expandable).
        /// </summary>
        [DataMember(EmitDefaultValue=false)]
        public Expandable<TeeTimeRateset[]> Ratesets
        {
            get;
            set;
        }

        /// <summary>
        /// When expanded, shows the min price for tee times matching the query.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public Expandable<Money> MinPrice
        {
            get;
            set;
        }

        /// <summary>
        /// When expanded, shows the summary of the ratings and reviews for the facility.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public Expandable<RatingSummary> RatingSummary
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets course statistics for the facility.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public Expandable<CourseStatistics> Statistics
        {
            get;
            set;
        }
    }
}
