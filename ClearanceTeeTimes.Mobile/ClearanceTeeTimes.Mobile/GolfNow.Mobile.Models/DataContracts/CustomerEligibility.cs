using System.Runtime.Serialization;
using GolfNow.Mobile.Models.Enumerations;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Encapsulates the eligibility status of a customer.  The only supported eligibility supported at this time is military
    /// (active or veteran).
    /// </summary>
    [DataContract]
    public class CustomerEligibility
    {
        /// <summary>
        /// A value indicating whether a customer is a member of the US military, current or former.
        /// </summary>
        /// <value>
        /// <c>true</c> if this customer is a member of the military; otherwise, <c>false</c>.  If military status can not be
        /// confirmed, this value will be null.
        /// </value>
        [DataMember]
        public bool? IsMilitary { get; set; }

        /// <summary>
        /// The status of the customer eligibility.  A value of Confirmed means that the customer has been confirmed as eligible or
        /// not eligible.  A value of InProgress means that the review process is on-going.  A value of RquiresManualVerification
        /// means that the client should request documentation from the customer and call RequestEligibilityDocumentationReview.
        /// </summary>
        [DataMember]
        public CustomerEligibilityStatus Status { get; set; }

        /// <summary>
        /// The branch of service if the customer is military verified.
        /// </summary>
        [DataMember]
        public string BranchOfService { get; set; }

        /// <summary>
        /// A value representing whether or not the military verification status was looked up or actually performed.  The value 
        /// returns true if the value was looked up and false if this is the first time a validation was attempted.  The value is 
        /// NULL if the verification has not yet been confirmed.
        /// </summary>
        [DataMember]
        public bool? PreviouslyMilitaryVerified { get; set; }

        /// <summary>
        /// A value representing the affiliation type.
        /// </summary>
        [DataMember]
        public string Type { get; set; }
    }
}