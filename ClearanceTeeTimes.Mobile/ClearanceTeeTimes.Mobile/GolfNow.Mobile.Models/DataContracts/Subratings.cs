using System;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A container class for subrating information.
    /// </summary>
    [DataContract]
    public class Subratings
    {
        /// <summary>
        /// The label for this metric.
        /// </summary>
        [DataMember]
        public string Label
        {
            get;
            set;
        }

        /// <summary>
        /// The value for this metric.
        /// </summary>
        [DataMember]
        public decimal Value
        {
            get;
            set;
        }

        /// <summary>
        /// The order in which the metric should appear, according to the database.
        /// </summary>
        [DataMember]
        public int SortOrder
        {
            get;
            set;
        }
    }
}
