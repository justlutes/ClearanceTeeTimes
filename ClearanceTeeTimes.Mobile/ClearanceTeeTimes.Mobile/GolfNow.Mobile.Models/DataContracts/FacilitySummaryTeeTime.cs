using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// A tee time related to a particular facility.
    /// </summary>
    [DataContract]
    public class FacilitySummaryTeeTime
    {
        /// <summary>
        /// The tee time ID for this rate.
        /// </summary>
        [DataMember]
        public int TeeTimeID
        {
            get;
            set;
        }

        /// <summary>
        /// The time at which this tee time occurs.
        /// </summary>
        [DataMember]
        public DateTime TeeDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// The golf course ID associated with this tee time.
        /// </summary>
        [DataMember]
        public int GolfCourseID
        {
            get;
            set;
        }

        /// <summary>
        /// The golf facility ID associated with this tee time.
        /// </summary>
        [DataMember]
        public int GolfFacilityID
        {
            get;
            set;
        }

        /// <summary>
        /// The play facility ID associated with this tee time.
        /// </summary>
        [DataMember]
        public int PlayFacilityID
        {
            get;
            set;
        }

        /// <summary>
        /// The base special rate for this tee time.
        /// </summary>
        [DataMember]
        public decimal SpecialRate
        {
            get;
            set;
        }

        /// <summary>
        /// The value rate for this tee time.
        /// </summary>
        [DataMember]
        public decimal ValueRate
        {
            get;
            set;
        }

        /// <summary>
        /// The greens fees for this tee time (excluding tax and transaction fees).
        /// </summary>
        [DataMember]
        public decimal GreensFees
        {
            get;
            set;
        }

        /// <summary>
        /// The number of players allowed for this tee time.
        /// </summary>
        [DataMember]
        public short Rule
        {
            get;
            set;
        }

        /// <summary>
        /// Icons associated with this tee time.
        /// </summary>
        [DataMember]
        public string[] Icons
        {
            get;
            set;
        }

        /// <summary>
        /// A flag indicating whether the purchase price is due online or at the course.
        /// </summary>
        [DataMember]
        public bool DueOnline
        {
            get;
            set;
        }

        /// <summary>
        /// A flag indicating whether or not this facility accepts credit cards.
        /// </summary>
        [DataMember]
        public bool? AcceptCreditCard
        {
            get;
            set;
        }
    }
}
