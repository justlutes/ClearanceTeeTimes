using System.Runtime.Serialization;

namespace GolfNow.Mobile.Models.DataContracts
{
    /// <summary>
    /// Forward a reservation confirmation to multiple friends.
    /// </summary>
    [DataContract]
    public class ForwardMultipleConfirmationRequest : ConfirmationEmailRequest
    {
        /// <summary>
        /// The email addresses to which to send the confirmation.
        /// </summary>
        [DataMember]
        public string[] ToEmailAddresses
        {
            get;
            set;
        }

        /// <summary>
        ///  Any and all comments from the client
        /// </summary>
        [XSSIntrusionPreventionIgnore]
        [DataMember]
        public string Comments
        {
            get;
            set;
        }
    }
}
