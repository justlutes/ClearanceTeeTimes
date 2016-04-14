using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Resend confirmation/cancellation requests to multiple email addresses.
    /// </summary>
    [DataContract]
    public class ResendMultipleConfirmationRequest : ConfirmationEmailRequest
    {
        /// <summary>
        /// The email addresses to which the confirmation/cancellation should be sent.
        /// </summary>
        [DataMember]
        public string[] ToEmailAddresses
        {
            get;
            set;
        }
    }
}
