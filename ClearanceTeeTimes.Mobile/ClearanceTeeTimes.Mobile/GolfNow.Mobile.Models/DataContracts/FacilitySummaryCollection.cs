using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// An object that contains a list of facility summary objects.
    /// </summary>
    [DataContract]
    public class FacilitySummaryCollection
    {
        /// <summary>
        /// The number of facilities in the items object.
        /// </summary>
        [DataMember]
        public int ResultCount
        {
            get;
            set;
        }

        /// <summary>
        /// The list of facility summary items.
        /// </summary>
        [DataMember]
        public List<FacilitySummaryListItem> Items
        {
            get;
            set;
        }

        /// <summary>
        /// When requested, this object contains a list of facilities that do not have inventory.
        /// </summary>
        [DataMember]
        public FacilityDetail[] EmptyFacilities { get; set; }

        /// <summary>
        /// The number of facilities in the empty facilities list.
        /// </summary>
        [DataMember]
        public int EmptyFacilityCount { get; set; }
    }
}
