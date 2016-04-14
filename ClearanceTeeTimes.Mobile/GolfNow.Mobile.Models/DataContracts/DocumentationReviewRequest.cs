using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Encapsulates a request to manually review documentation supplied by a golfer.
    /// </summary>
    [DataContract]
    public class DocumentationReviewRequest
    {
        /// <summary>
        /// REQUIRED: The documentation to be used to manually verify golfer eligibility for special offers.
        /// </summary>
        [DataMember]
        public EligibilityReviewDocument[] Documentation { get; set; }

        /// <summary>
        /// OPTIONAL: Absolute URL to be used in an email that will allow the golfer to be placed back into an application 
        /// workflow.  MUST BE URL ENCODED.
        /// </summary>
        [DataMember]
        public string RedirectURL { get; set; }
    }
}