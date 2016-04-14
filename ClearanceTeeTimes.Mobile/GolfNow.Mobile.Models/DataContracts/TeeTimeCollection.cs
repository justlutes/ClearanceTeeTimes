using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A collection of tee times and facilities for a tee time search.
    /// </summary>
    [DataContract]
    public class TeeTimeCollection
    {
        /// <summary>
        /// The total number of tee times that matched the query (reguardless of the paging options).
        /// </summary>
        [DataMember]
        public int TotalTeeTimes
        {
            get;
            set;
        }

        /// <summary>
        /// An indicator if the maximum limit of tee times was reached during processing.
        /// </summary>
        [DataMember]
        public Boolean LimitReached
        {
            get;
            set;
        }

        /// <summary>
        /// An optional set of facilities that match the query.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public Expandable<FacilityDetail[]> Facilities
        {
            get;
            set;
        }

        /// <summary>
        /// The tee times that match the query.
        /// </summary>
        [DataMember]
        public TeeTimeRateset[] TeeTimes
        {
            get;
            set;
        }
    }
}
